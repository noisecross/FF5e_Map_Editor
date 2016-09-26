/**
* |------------------------------------------|
* | FF5e_Map_editor                          |
* | File: Compressor.cs                      |
* | v1.3, July 2016                          |
* | Author: noisecross                       |
* |------------------------------------------|
* 
* @author noisecross
* @version 1.3
* 
*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF5e_Text_Editor
{
    public class Compressor
    {
        /*
        FFV have some ROM areas of texts, graphics, data and even code which are compressed.
        To decompress that data, the game includes some functions.
        One of them read the first byte to check the type of decompression to apply
          and the other one presuppose decompression "type 02".
        
        Subroutine 7F/C00D
        ------------------------------------------
        At the beginning of the game, some code is written to bank 7F.
        The function stored in 7F/C00D is a decompressor which waits for headed data.
        The pointer to the source to decompress for is stored in $D0 and the pointer to the
          destination of the decompressed data is stored in $D3.
        The first byte pointed by $D0 is read and to choose the decompression algorithm.
        I am going to call them Type 00, Type 01 and Type 02.
        If the first byte is a number over 2, the function just returns.
         
        Subroutine C3/0053
        ------------------------------------------
        The function addressed at C3/0053 performs a Decompression Type 02.
        The pointer to the source to decompress for is stored in $D0 and the pointer to the
          destination of the decompressed data is stored in $D3.
        The first byte pointed by $D0 is not a header in this case.
        
        Decompression Type 00
        ------------------------------------------
        No decompression here.
        The first two bytes after the header are a 16 bit value which represents the
          number of bytes to read forward from $D0.
        Every byte which is read from $D0 is stored in $D3.
        
        Decompression Type 01
        ------------------------------------------
        The data is stored here as packages with one byte heading every package.
        I'm going to call that byte "action byte".
        While the decompressing is happening, the "action byte" is taken from $D0 and choose
          the next action to perform:
         
        If the action byte is 0:
          The decompression ends.
        If the action byte is 01 to 7F:
          Store action byte as n.
          Read next byte from $D0 and store it as byteToRepeat.
          Write byteToRepeat in $D3 n times.
        If the action byte is 80 to FF:
          Store action byte as n.
          Ignore the higher bit of n. (n is now in the range of 00 to 7F)
          Read n bytes from $D0 and write them in $D3
         
        Decompression Type 02
        ------------------------------------------
        The first two bytes after the header are a 16 bit value which represents the number of
        bytes to write in $D3. The decompression ends when that number of bytes has been written.
        This algorithm counts with a temporal circular buffer stored in 7F/F7FF, with a size of #$0800 bytes,
          initially filled with zeroes and with an initial offset of #$07DE.
        The data is stored as packages with one byte heading every package.
        I'm going to call that byte "bitmap byte".
        Every time a bitmap byte is read, it marks the next eight lectures.
        Beginning with the lesser bit of the bitmap byte and ending with the higher:

        If the bit is 1:
          Read next byte from $D0
          Write it on the circular buffer
          Write it on $D3
        If the bit is 0:
          Read 16 bit value from $D0
          That value contains an 'offset' and a 'length': O07 O06 O05 O04 O03 O02 O01 O00 | O10 O09 O08 L04 L03 L02 L01 L00
          Do (length + 3) times
              Read a byte from the circular buffer with the given offset
              Write the byte on the circular buffer
              Write the byte on $D3
              Increment offset (if offset > #$07FF then offset = #$0000)
        
        After consuming the 8 bits from the bitmap byte, a new bitmap byte is read from $D0.
        */



        /**
        * findInBuffer
        * 
        * Look for a given sequence inside the circular buffer. Auxiliar function to compress Type 02.
        *
        * @param input: The sequence to look for inside the buffer.
        * @param inputBuffer: The buffer.
        * @param writtenData: Number of bytes written into the buffer.
        * @param initBuffer: The index where the first byte was written into the buffer (it will be always #$07DE)
        * @param bufferSize: The size of the buffer (it will be always #$0800 bytes)
        * 
        * @return: The index where the sequence has been found or -1 if the sequence couldn't be found.
        */
        private static int findInBuffer(List<Byte> input, Byte[] inputBuffer, int writtenData, int initBuffer, int bufferSize)
        {
            int output = -1;
            int condition = 0;

            if (writtenData < input.Count || input.Count < 3)
                return output;

            condition = initBuffer + writtenData - input.Count + 1;

            for (int i = initBuffer; i < condition; i++)
            {
                List<Byte> rangeToCheck = new List<byte>();
                for (int j = 0; j < input.Count; j++)
                {
                    rangeToCheck.Add(inputBuffer[(i + j) & (bufferSize - 1)]);
                }

                if (rangeToCheck.SequenceEqual(input))
                {
                    output = i & (bufferSize - 1);
                    break;
                }
            }

            return output;
        }



        /**
        * compress
        * 
        * Perform a compression Type 02 of a given data.
        *
        * @param input: The sequence to compress.
        * @param progress: A reference to a System.Windows.Forms.ProgressBar to display the progress of the compression.
        * @param initBuffer: The index where the first byte was written into the buffer (it will be always #$07DE)
        * @param bufferSize: The size of the buffer (it will be always #$0800 bytes)
        * 
        * @return: The compressed sequence.
        */
        public static List<Byte> compress(List<Byte> input, System.Windows.Forms.ProgressBar progress = null, int initBuffer = 0x07DE, int bufferSize = 0x0800)
        {
            List<Byte> output = new List<Byte>();
            List<Byte> compressionBuffer = new List<Byte>();
            List<bool> bitmap = new List<bool>();
            Byte[] buffer = new Byte[bufferSize];

            if (progress != null)
                progress.Maximum = input.Count;

            /* Compress */
            /* init index 0x07DE */
            /* buffer mask 0x07FF */
            int bufferMask = bufferSize - 1;
            int index = initBuffer;
            int prevCandidate = -1;
            int candidate = -1;
            int writtenData = 0;
            int nextByteToBuffer = -1;
            int compressedBytes = 0;

            /* Optimize compression: begin_with_zeros */
            int firstNonzero = input.FindIndex(x => x != 0);
            if (firstNonzero > 2)
            {
                if (firstNonzero > 34)
                    firstNonzero = 34;

                compressedBytes += compressionBuffer.Count;
                int sizeToRead   = firstNonzero - 3;
                int offsetToRead = 0;
                Byte firstByte   = (Byte)(offsetToRead & 0x00FF);
                Byte secondByte  = (Byte)(sizeToRead + ((offsetToRead >> 3) & 0x00E0));

                output.Add(firstByte);
                output.Add(secondByte);

                bitmap.Add(true);
                input.RemoveRange(0, firstNonzero);

                writtenData += firstNonzero;
                index       += firstNonzero;
            }


            /* Read input buffer */
            while (input.Count > 0 || compressionBuffer.Count > 0)
            {
                if (input.Count > 0)
                {
                    nextByteToBuffer = input[0];
                    compressionBuffer.Add((Byte)nextByteToBuffer);
                    input.RemoveAt(0);
                }
                else
                {
                    nextByteToBuffer = -1;
                }


                if (compressionBuffer.Count > 2 || input.Count == 0)
                {
                    candidate = findInBuffer(compressionBuffer, buffer, writtenData, initBuffer, bufferSize);

                    if (candidate < 0 || compressionBuffer.Count == 34 || input.Count == 0)
                    {
                        if (candidate >= 0)
                        {
                            /* This is candidate */
                            /* Last string or 34 matches in a row */
                            compressedBytes += compressionBuffer.Count;
                            int sizeToRead = compressionBuffer.Count - 3; /* (secondByte & 0x1F) + 3; */
                            int offsetToRead = (candidate) /*& bufferMask*/;  /* (firstByte + (secondByte >> 5) * 0x0100) & 0x07FF;*/
                            Byte firstByte = (Byte)(offsetToRead & 0x00FF);
                            Byte secondByte = (Byte)(sizeToRead + ((offsetToRead >> 3) & 0x00E0));

                            output.Add(firstByte);
                            output.Add(secondByte);

                            compressionBuffer.Clear();
                            candidate = -1;
                            bitmap.Add(true);
                        }
                        else if (prevCandidate < 0)
                        {
                            /* Uncompressed byte */
                            compressedBytes++;
                            output.Add(compressionBuffer[0]);
                            compressionBuffer.RemoveAt(0);
                            bitmap.Add(false);
                        }
                        else
                        {
                            /* Prev one was candidate */
                            compressedBytes += compressionBuffer.Count - 1;
                            int sizeToRead = compressionBuffer.Count - 4;    /* (secondByte & 0x1F) + 3; */
                            int offsetToRead = prevCandidate /* & bufferMask*/; /* (firstByte + (secondByte >> 5) * 0x0100) & 0x07FF;*/
                            Byte firstByte = (Byte)(offsetToRead & 0x00FF);
                            Byte secondByte = (Byte)(sizeToRead + ((offsetToRead >> 3) & 0x00E0));

                            output.Add(firstByte);
                            output.Add(secondByte);

                            compressionBuffer.RemoveRange(0, compressionBuffer.Count - 1);
                            bitmap.Add(true);
                        }
                    }

                    prevCandidate = candidate;
                }


                if (nextByteToBuffer >= 0)
                {
                    buffer[index] = (Byte)nextByteToBuffer;
                    index = (index + 1) & bufferMask;
                    writtenData++;

                    if (writtenData > bufferSize)
                    {
                        initBuffer = (initBuffer + 1) & bufferMask;
                        writtenData = bufferSize;
                    }
                }


                if (progress != null && compressedBytes % 0x40 == 0)
                {
                    progress.Value = compressedBytes;
                }
            }


            index = 0;
            while (index < output.Count)
            {
                int nextGroupSize = 9;

                Byte newMask = 0xFF;
                for (int i = 0; i < 8; i++)
                {
                    newMask = (byte)(newMask >> 1);

                    if (bitmap.Count > 0)
                    {
                        if (bitmap[0])
                        {
                            /* Compressed */
                            nextGroupSize++;
                        }
                        else
                        {
                            newMask += 0x80;
                        }
                        bitmap.RemoveAt(0);
                    }
                    else
                    {
                        newMask += 0x80;
                    }
                }

                output.Insert(index, newMask);
                index += nextGroupSize;
            }


            if (progress != null)
                progress.Value = 0;

            return output;
        }



        /**
        * compressType01
        * 
        * Perform a compression Type 01 of a given data.
        *
        * @param input: The sequence to compress.
        * 
        * @return: The compressed sequence.
        */
        public static List<Byte> compressType01(List<Byte> input)
        {
            List<Byte> output    = new List<Byte>();
            List<Byte> bufferRep = new List<Byte>();
            List<Byte> bufferNRe = new List<Byte>();

            if (input.Count == 0)
            {
                output.Add(0);
                return output;
            }


            int candidate   = -1;

            foreach (Byte item in input)
            {
                /* Choose list to insert in */
                if (item == candidate)
                {
                    /* Repeated byte */
                    /* Delete the last item from  */
                    if (bufferNRe.Count > 0 && bufferNRe.Last() == item)
                    {
                        bufferNRe.RemoveAt(bufferNRe.Count - 1);
                    }
                    bufferRep.Add(item);

                    /* Send bufferNRe to output if bufferRep > 2 */
                    if (bufferRep.Count > 2 && bufferNRe.Count > 0)
                    {
                        output.Add(BitConverter.GetBytes(bufferNRe.Count)[0]);
                        output.AddRange(bufferNRe);
                        bufferNRe.Clear();
                    }
                }
                else
                {
                    /* Non repeated byte */
                    
                    if (bufferRep.Count < 3 && bufferRep.Count > 0)
                    {
                        /* Insert items in NRe */
                        bufferNRe.AddRange(bufferRep);
                        bufferRep.Clear();
                    }
                    else if (bufferRep.Count > 3)
                    {
                        /* Insert items in output */
                        output.Add(BitConverter.GetBytes(bufferRep.Count + 0x80)[0]);
                        output.Add(bufferRep[0]);
                        bufferRep.Clear();
                    }

                    bufferNRe.Add(item);
                }
                candidate = item;

                /* 0x7F elements reached */
                if (bufferRep.Count == 0x7F)
                {
                    output.Add(BitConverter.GetBytes(bufferRep.Count + 0x80)[0]);
                    output.Add(bufferRep[0]);
                    bufferRep.Clear();
                    candidate = -1;
                }
                else if (bufferNRe.Count >= 0x7F)
                {
                    output.Add(BitConverter.GetBytes(Math.Min(0x7F, bufferNRe.Count))[0]);
                    output.AddRange(bufferNRe.GetRange(0, 0x7F));
                    bufferNRe.RemoveRange(0, 0x0F);
                }
            }

            /* All items read. Flush buffer elements */
            if (bufferNRe.Count > 0)
            {
                /* Add bufferRep to bufferNRe */
                bufferNRe.AddRange(bufferRep);
                bufferRep.Clear();

                /* Write bufferNRe in output */
                output.Add(BitConverter.GetBytes(Math.Min(0x7F, bufferNRe.Count))[0]);
                output.AddRange(bufferNRe.GetRange(0, Math.Min(0x7F, bufferNRe.Count)));
                bufferNRe.RemoveRange(0, Math.Min(0x7F, bufferNRe.Count));

                /* Write bufferNRe again if some elements remains */
                if (bufferNRe.Count > 0)
                {
                    output.Add(BitConverter.GetBytes(bufferNRe.Count)[0]);
                    output.AddRange(bufferNRe);
                    bufferNRe.Clear();
                }
            }
            else if (bufferRep.Count > 0)
            {
                /* Write buffer rep */
                output.Add(BitConverter.GetBytes(bufferRep.Count + 0x80)[0]);
                output.Add(bufferRep[0]);
                bufferRep.Clear();
            }

            /* Return compressed data */
            return output;
        }



        /**
        * uncompress
        * 
        * Perform a uncompression of a given data in a given file.
        *
        * @param address: The sequence to compress.
        * @param br: The System.IO.BinaryReader pointing to the FFV file.
        * @param headerOffset: The offset of the file if it has a SMC header.
        * @param unheaded: True to skip the head of the compressed data and forcing Type 02 uncompress.
        * @param silent: False to allow this function to display popup messages.
        * 
        * @return: The uncompressed data.
        */
        public static List<Byte> uncompress(long address, System.IO.BinaryReader br, int headerOffset, bool unheaded = false, bool silent = false)
        {
            long size = 0;
            return uncompress(address, br, headerOffset, out size, unheaded, silent);
        }



        /**
        * uncompress
        * 
        * Perform a uncompression of a given data in a given file.
        *
        * @param address: The sequence to compress.
        * @param br: The System.IO.BinaryReader pointing to the FFV file.
        * @param headerOffset: The offset of the file if it has a SMC header.
        * @param size: Output parameter. Returns the size of the data when it was compressed.
        * @param unheaded: True to skip the head of the compressed data and forcing Type 02 uncompress.
        * @param silent: False to allow this function to display popup messages.
        * 
        * @return: The uncompressed data.
        */
        public static List<Byte> uncompress(long address, System.IO.BinaryReader br, int headerOffset, out long size, bool unheaded = false, bool silent = false)
        {
            Byte compressionType;
            size = 0;

            try
            {
                br.BaseStream.Position = address + headerOffset;

                if (unheaded)
                {
                    /* Unheaded compressed files are decompressed as Type 02 by function C3/0053 */
                    return uncompressType02(br, out size, false, silent);
                }
                else
                {
                    /* Headed compressed can be decompressed in three flavours by function 7F/C00D */
                    compressionType = br.ReadByte();

                    switch (compressionType)
                    {
                        case 00:
                            return uncompressType00(br);
                        case 01:
                            return uncompressType01(br);
                        case 02:
                            return uncompressType02(br, out size, true, silent);
                        default:
                            return new List<Byte>();
                    };

                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error reading the file: " + e.ToString(), "Error");
            }

            return new List<Byte>();
        }



        /**
        * uncompressType00
        * 
        * Perform a uncompression Type 00 of a given data from the current br.BaseStream.Position.
        *
        * @param br: The System.IO.BinaryReader pointing to the compressed data in the FFV file.
        * 
        * @return: The uncompressed data.
        */
        public static List<Byte> uncompressType00(System.IO.BinaryReader br)
        {
            List<Byte> output = new List<Byte>();

            int remainingBytes = 0;

            try
            {
                remainingBytes = (br.ReadByte() + br.ReadByte() * 0x0100);

                while (remainingBytes-- > 0)
                {
                    output.Add(br.ReadByte());
                }
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Error reading the file: " + err.ToString(), "Error");
                output.Clear();
            }

            if (output.Count > 0)
            {
                long endData = br.BaseStream.Position;
                System.Windows.Forms.MessageBox.Show("Compression Type 00.\r\nThe compressed data ends at " +
                    (endData - 1).ToString("X6") + "\r\nAddress " + endData.ToString("X6") +
                    " and forward must never be overwritten if this data\r\nis edited and re-imported.", "Info");
            }

            return output;
        }



        /**
        * uncompressType01
        * 
        * Perform a uncompression Type 01 of a given data from the current br.BaseStream.Position.
        *
        * @param br: The System.IO.BinaryReader pointing to the compressed data in the FFV file.
        * 
        * @return: The uncompressed data.
        */
        public static List<Byte> uncompressType01(System.IO.BinaryReader br)
        {
            List<Byte> output = new List<Byte>();

            Byte remainingBytes = 0;
            Byte nextAction     = 0;
            Byte byteToRepeat   = 0;

            try
            {

                while (true)
                {
                    nextAction = br.ReadByte();

                    if (nextAction == 0)
                    {
                        if (output.Count > 0)
                        {
                            long endData = br.BaseStream.Position;
                            System.Windows.Forms.MessageBox.Show("Compression Type 01.\r\nThe compressed data ends at " +
                                (endData - 1).ToString("X6") + "\r\nAddress " + endData.ToString("X6") +
                                " and forward must never be overwritten if this data\r\nis edited and re-imported.", "Info");
                        } 
                        
                        return output;
                    }
                    else if (nextAction < 0x80)
                    {
                        remainingBytes = nextAction;
                        byteToRepeat = br.ReadByte();
                        while (remainingBytes-- > 0)
                        {
                            output.Add(byteToRepeat);
                        }
                    }
                    else
                    {
                        remainingBytes = (Byte)(nextAction & 0x7F);
                        while (remainingBytes-- > 0)
                        {
                            output.Add(br.ReadByte());
                        }
                    }
                }

            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Error reading the file: " + err.ToString(), "Error");
                output.Clear();
            }

            return output;
        }



        /**
        * uncompressType02
        * 
        * Perform a uncompression Type 02 of a given data from the current br.BaseStream.Position.
        *
        * @param br: The System.IO.BinaryReader pointing to the compressed data in the FFV file.
        * @param size: Output parameter. Returns the size of the data when it was compressed.
        * @param unheaded: True to skip the head of the compressed data and forcing Type 02 uncompress.
        * @param silent: False to allow this function to display popup messages.
        * 
        * @return: The uncompressed data.
        */
        public static List<Byte> uncompressType02(System.IO.BinaryReader br, out long size, bool headed = false, bool silent = false)
        {
            List<Byte> output = new List<Byte>();

            Byte[] buffer = new Byte[0x0800];
            int index = 0x07DE;
            long initAddress = br.BaseStream.Position;

            try
            {
                int remainingBytes = (br.ReadByte() + br.ReadByte() * 0x0100);

                while (remainingBytes > 0)
                {
                    byte bitmap = br.ReadByte();

                    for (int i = 0; i < 8; i++)
                    {
                        if ((bitmap & 0x01) != 0)
                        {
                            /* Non compressed value */
                            byte nextChar = br.ReadByte();
                            output.Add(nextChar);
                            buffer[index] = nextChar;
                            index = (++index) & 0x07FF;
                            remainingBytes--;
                        }
                        else
                        {
                            /* Compressed value */
                            int firstByte = br.ReadByte();
                            int secondByte = br.ReadByte();
                            int sizeToRead = (secondByte & 0x1F) + 3;
                            int offsetToRead = (firstByte + (secondByte >> 5) * 0x0100) & 0x07FF;

                            for (int j = 0; j < sizeToRead; j++)
                            {
                                buffer[index] = buffer[offsetToRead];
                                output.Add(buffer[offsetToRead]);
                                offsetToRead = (++offsetToRead) & 0x07FF;
                                index = (++index) & 0x07FF;
                            }

                            remainingBytes -= sizeToRead;
                        }

                        bitmap = (byte)(((int)bitmap) >> 1);

                        if (remainingBytes < 1)
                            break;
                    }
                }
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Error reading the file: " + err.ToString(), "Error");
                output.Clear();
            }

            long endData = br.BaseStream.Position;
            long extension = endData - initAddress;

            if (headed)
                extension += 1;

            size = extension;

            if (output.Count > 0 && !silent)
            {

                System.Windows.Forms.MessageBox.Show("Compression Type 02.\r\nThe compressed data ends at " +
                    (endData - 1).ToString("X6") + "\r\nAddress " + endData.ToString("X6") +
                    " and forward must never be overwritten if this data\r\nis edited and re-imported.\r\nThe" +
                    " maximum extension of the injecion must be lesser or equal than " + extension.ToString("X4") +
                    ".", "Info");
            }

            return output;
        }



        /**
        * uncompressType02
        * 
        * Perform a uncompression Type 02 of a given data input.
        *
        * @param input: The compressed data to uncompress.
        * 
        * @return: The uncompressed data.
        */
        public static List<Byte> uncompressType02(List<Byte> input)
        {
            List<Byte> output = new List<Byte>();

            Byte[] buffer = new Byte[0x0800];
            int index = 0x07DE;

            try
            {
                int remainingBytes = (input[1] + input[2] * 0x0100);
                input.RemoveRange(0, 3);

                while (remainingBytes > 0)
                {
                    byte bitmap = input[0];
                    input.Remove(0);

                    for (int i = 0; i < 8; i++)
                    {
                        if ((bitmap & 0x01) != 0)
                        {
                            /* Non compressed value */
                            byte nextChar = input[0];
                            input.Remove(0);
                            output.Add(nextChar);
                            buffer[index] = nextChar;
                            index = (++index) & 0x07FF;
                            remainingBytes--;
                        }
                        else
                        {
                            /* Compressed value */
                            int firstByte = input[0];
                            input.Remove(0);
                            int secondByte = input[0];
                            input.Remove(0);
                            int sizeToRead = (secondByte & 0x1F) + 3;
                            int offsetToRead = (firstByte + (secondByte >> 5) * 0x0100) & 0x07FF;

                            for (int j = 0; j < sizeToRead; j++)
                            {
                                buffer[index] = buffer[offsetToRead];
                                output.Add(buffer[offsetToRead]);
                                offsetToRead = (++offsetToRead) & 0x07FF;
                                index = (++index) & 0x07FF;
                            }

                            remainingBytes -= sizeToRead;
                        }

                        bitmap = (byte)(((int)bitmap) >> 1);

                        if (remainingBytes < 1)
                            break;
                    }
                }
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Error reading the stream: " + err.ToString(), "Error");
                output.Clear();
            }

            return output;
        }



        /**
        * uncompressTypeWorldMap
        * 
        * Perform a uncompression Type CustomWorldMap of a given data input.
        *
        * @param br: The System.IO.BinaryReader pointing to the compressed data in the FFV file.
        * 
        * @return: The uncompressed data.
        */
        public static List<Byte> uncompressTypeWorldMap(System.IO.BinaryReader br)
        {
            List<Byte> output = new List<Byte>();

            try
            {
                List<Byte> compressed = br.ReadBytes(0x0100).ToList();

                int i = 0;
                while (i < 0x0100)
                {
                    Byte onRead = compressed[i++];

                    if (onRead >= 0xC0)
                    {
                        int nBytes = onRead - 0xBF;
                        if (i >= 0x0100) break;
                        onRead = compressed[i++];

                        for (int j = 0; j < nBytes; j++)
                            output.Add(onRead);
                    }
                    else if (onRead == 0x0C || onRead == 0x1C || onRead == 0x2C)
                    {
                        output.Add(onRead++);
                        output.Add(onRead++);
                        output.Add(onRead);
                    }
                    else
                    {
                        output.Add(onRead);
                    }

                    if (output.Count >= 0x0100) break;
                }
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show("Error reading the stream: " + err.ToString(), "Error");
                output.Clear();
            }

            return output;
        }



        /**
        * compressTypeWorldMap
        * 
        * Perform a compression Type CustomWorldMap of a given data input.
        *
        * @param input: The sequence to compress.
        * 
        * @return: The compressed data.
        */
        public static List<Byte> compressTypeWorldMap(List<Byte> inputUm)
        {
            List<Byte> output = new List<Byte>();
            int lastByte = inputUm.Count - 1;

            List<Byte> input = new List<Byte>(inputUm);
            input.ForEach(x => Convert.ToByte(x & 0x3F));

            for (int i = 0; i < input.Count; i++)
            {
                Byte onRead = input[i];

                //Read last byte and end
                if (i == lastByte)
                {
                    output.Add(onRead);
                    continue;
                }


                //Check for compression 0C-0D-0E
                if ((onRead == 0x0C || onRead == 0x1C || onRead == 0x2C) && i < input.Count - 2)
                {
                    if (input[i + 1] == onRead + 1 && input[i + 2] == onRead + 2)
                    {
                        output.Add(onRead);
                        i += 2;
                    }
                    else
                    {
                        output.Add(0xC0);
                        output.Add(onRead);
                    }

                    continue;
                }
                

                //Check for multiple equal tiles compression
                if (onRead == input[i + 1])
                {
                    //Check for a maximum of 0x40 repeats
                    int j = 1;

                    while (i + j < input.Count && j < 0x40)
                    {
                        if (input[i + j] != onRead)
                        {
                            j--;
                            break;
                        }

                        j++;
                    }
                    if (j == 0x40) { j--; }
                    if (i + j == input.Count) j--;
                    i += j;

                    output.Add((Byte)(0xC0 + j));
                    output.Add(onRead);

                    continue;
                }


                //No compression
                output.Add(onRead);
            }

            return output;
        }



    }
}
