/**
* |------------------------------------------|
* | FF5e_Map_editor                          |
* | File: Main_Map_Editor.cs                 |
* | v0.87, September 2016                    |
* | Author: noisecross                       |
* |------------------------------------------|
* 
* @author noisecross
* @version 0.87
* 
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FF5e_Text_Editor;



namespace FF5e_Map_Editor
{
    public partial class Main_Map_Editor : Form
    {
        // Global variables
        const string windowName      = "FF5e_Map_Editor";
        const string version         = "Ver. v0.87 (September 2016)";
        int          headerOffset    = 0;
        MAP_Manager  mapManager;

        double       mapZoom         = 1;

        bool         mapIsDrawable   = false;
        bool         nUNDUpdatable   = true;
        int          currentMap      = -1;
        Bitmap       mapBg00U        = new Bitmap(1, 1);
        Bitmap       mapBg00D        = new Bitmap(1, 1);
        Bitmap       mapBg01U        = new Bitmap(1, 1);
        Bitmap       mapBg01D        = new Bitmap(1, 1);
        Bitmap       mapBg02U        = new Bitmap(1, 1);
        Bitmap       mapBg02D        = new Bitmap(1, 1);
        Bitmap       mapBgWalls      = new Bitmap(1, 1);
        Bitmap       mapNPCs         = new Bitmap(1, 1);
        Bitmap       mapMiscs        = new Bitmap(1, 1);
        Bitmap       tilesetVRAM     = new Bitmap(1, 1);
        Bitmap       bgPalette       = new Bitmap(1, 1);
        Bitmap       mapMixedDisplay = new Bitmap(1, 1);

        TBL_Manager  tblManager      = new TBL_Manager();

        //Tileset Form
        DisplayTileset tilesetForm = new DisplayTileset();

        //Tileset tab
        List<tile16x16> tileSetMap = new List<tile16x16>();
        Bitmap tileSetBitmap = new Bitmap(0x0100, 0x0100);

        //Properties tab
        Bitmap npc = new Bitmap(1, 1);

        // SMC file to edit
        string fileUnderEdition  = "";
        string fileUnderEditionS = "";
        bool   fileToEditIsAvailable = false;



        public Main_Map_Editor()
        {
            InitializeComponent();

            /* Images buffering */
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            labelLocationName.Text = "";
            UpdateStyles();

            // DEPRECATED Tileset tab page
            this.tabPage2.Dispose();
        }



        #region loadingFunctions



        public List<String> loadSpeech(System.IO.BinaryReader br)
        {
            List<String> speechTxt = new List<String>();

            Byte newChar = 0x00;

            /* Const (Bartz) */
            List<Byte> bartz = new List<Byte>();
            if (tblManager.TBL_Injector1bpp.TryGetValue("(", out newChar)) bartz.Add(newChar);
            if (tblManager.TBL_Injector1bpp.TryGetValue("B", out newChar)) bartz.Add(newChar);
            if (tblManager.TBL_Injector1bpp.TryGetValue("a", out newChar)) bartz.Add(newChar);
            if (tblManager.TBL_Injector1bpp.TryGetValue("r", out newChar)) bartz.Add(newChar);
            if (tblManager.TBL_Injector1bpp.TryGetValue("t", out newChar)) bartz.Add(newChar);
            if (tblManager.TBL_Injector1bpp.TryGetValue("z", out newChar)) bartz.Add(newChar);
            if (tblManager.TBL_Injector1bpp.TryGetValue(")", out newChar)) bartz.Add(newChar);

            /* Reset speech */
            List<int> speechPtr = new List<int>();
            List<List<Byte>> speech = new List<List<byte>>();


            /* Read Speech */
            br.BaseStream.Position = 0x2013F0;

            for (int i = 0; i < 2160; i++)
            {
                int newPtr = br.ReadByte() + br.ReadByte() * 0x0100 + (br.ReadByte() - 0xC0) * 0x010000;
                speechPtr.Add(newPtr);
            }

            foreach (int item in speechPtr)
            {
                List<Byte> newRegister = new List<byte>();
                br.BaseStream.Position = item;

                Byte newByte = br.ReadByte();
                while (newByte != 0)
                {
                    if (newByte != 0x02)
                    {
                        newRegister.Add(newByte);
                    }
                    else
                    {
                        /* (Bartz)*/
                        newRegister.AddRange(bartz);
                    }
                    newByte = br.ReadByte();
                }

                String newLine = "";
                foreach(Byte subitem in newRegister)
                {
                    newLine += tblManager.TBL_Reader1bpp[subitem];
                }

                speechTxt.Add(newLine);
                speech.Add(newRegister);

            }

            return speechTxt;
        }



        private List<String> appendToExportList(System.IO.BinaryReader br, Dictionary<Byte, String> inputTBL, int address, int nRegisters, int registersSize)
        {
            List<String> output = new List<String>();

            try
            {
                br.BaseStream.Position = address + headerOffset;

                for (int i = 0; i < nRegisters; i++)
                {
                    String newLine = "";

                    for (int j = 0; j < registersSize; j++)
                    {
                        newLine += inputTBL[br.ReadByte()];
                    }

                    output.Add(newLine);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading the file: " + e.ToString(), "Error");
            }

            return output;
        }



        private List<String> appendToExportListSU(System.IO.BinaryReader br, Dictionary<Byte, String> inputTBL, int offsetsAdress, int address, int nRegisters)
        {
            List<String> output = new List<String>();
            List<int> offsets = new List<int>();

            if (!fileToEditIsAvailable)
            {
                openSMCToolStripMenuItem_Click(null, null);
                if (!fileToEditIsAvailable)
                    return output;
            }

            try
            {
                if (!fileToEditIsAvailable)
                    return output;

                br.BaseStream.Position = offsetsAdress + headerOffset;
                for (int i = 0; i < nRegisters; i++)
                {
                    offsets.Add(br.ReadByte() + 0x0100 * br.ReadByte());
                }

                offsets.Add(2304);

                for (int i = 0; i < nRegisters; i++)
                {
                    br.BaseStream.Position = address + headerOffset + offsets[i];
                    String newLine = "";

                    byte newByte = br.ReadByte();
                    for (int j = 0; j < offsets[i + 1] - offsets[i]; j++)
                    {
                        newLine += inputTBL[newByte];
                        newByte = br.ReadByte();
                    }

                    output.Add(newLine);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading the file: " + e.ToString(), "Error");
            }

            return output;
        }



        private bool checkSNESHeader(System.IO.BinaryReader br)
        {
            /* Too small size */
            if (br.BaseStream.Length < 0x200000)
                return false;

            if (br.BaseStream.Length % 1024 == 0)
            {
                headerOffset = 0x0000;
                br.BaseStream.Position = 0xFFC0;
                byte[] headerName = br.ReadBytes(21);
                return System.Text.Encoding.UTF8.GetString(headerName) == "FINAL FANTASY 5      ";
            }
            else if (br.BaseStream.Length % 1024 == 512)
            {
                headerOffset = 0x0200;
                br.BaseStream.Position = (0xFFB0 + 0x0200);
                byte[] headerName = br.ReadBytes(21);
                return System.Text.Encoding.UTF8.GetString(headerName) == "FINAL FANTASY 5      ";
            }
            else
            {
                return false;
            }
        }



        private void openSMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToEditIsAvailable = false;
            mapIsDrawable = false;
            nUNDUpdatable = true;

            tilesetForm.resetClipboard();

            /* Displays an OpenFileDialog so the user can select a res */
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SNES ROM Files (*.smc, *.sfc)|*.smc;*.sfc";
            openFileDialog.Title  = "Choose a ROM file";

            /* Show the Dialog */
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog.FileName != "")
                {
                    System.IO.BinaryReader br = new System.IO.BinaryReader(System.IO.File.Open(openFileDialog.FileName, System.IO.FileMode.Open));

                    try
                    {
                        if (!checkSNESHeader(br))
                        {
                            br.Close();
                            openFileDialog.Dispose();
                            openFileDialog = null;
                            return;
                        }
                        
                        List<String> speechTxt     = new List<String>();
                        List<String> itemNames     = new List<String>();
                        List<String> spellNames    = new List<String>();
                        List<String> locationNames = new List<String>();
                        List<String> monsterNames  = new List<String>();

                        if (br.BaseStream.Length > 0x200000)
                        {
                            fileToEditIsAvailable = true;
                            speechTxt = loadSpeech(br);
                            itemNames = appendToExportList(br, tblManager.TBL_Reader2bpp, 0x111380, 256 /* nRegisters */, 9 /* registersSize */);
                            spellNames = appendToExportList(br, tblManager.TBL_Reader2bpp, 0x111C80, 87 /* nRegisters */, 6 /* registersSize */);
                            locationNames = appendToExportListSU(br, tblManager.TBL_Reader1bpp, 0x107000, 0x270000, 164);
                            monsterNames = appendToExportList(br, tblManager.TBL_Reader2bpp, 0x200050, 384 /* nRegisters */, 10 /* registersSize */);
                            fileToEditIsAvailable = false;

                            mapManager = new MAP_Manager(br, headerOffset, speechTxt, itemNames, spellNames, locationNames, monsterNames);
                            fileUnderEdition = openFileDialog.FileName;
                            fileUnderEditionS = openFileDialog.SafeFileName;
                            fileToEditIsAvailable = true;

                            currentMap = -1;
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("Error loading the file: " + error.ToString(), "Error");
                    }

                    br.Close();
                }
            }
            openFileDialog.Dispose();
            openFileDialog = null;

            updateMap();

            if (fileToEditIsAvailable)
            {
                if (mapManager.tilemap00.Count > 0)
                {
                    int chosenTileX, chosenTileY;
                    tilesetForm.getClipboardInformation(out chosenTileX, out chosenTileY);
                    numericUpDownSelectedTileBg00.Value = mapManager.tilemap00[chosenTileX + chosenTileY * 64];
                }
                updateTileset();
                this.BringToFront();
            }
        }



        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }



        #endregion loadingFunctions

        
        
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String outputMessage = "";

            outputMessage += "Developed by Noisecross:";
            outputMessage += "\r\n";
            outputMessage += version;
            outputMessage += "\r\n";
            outputMessage += "\r\n";
            outputMessage += "This tool is not under any kind of support, but for any questions please read the readme.docx file or contact the developer by email (dalastnecromancer@gmail.com)";

            MessageBox.Show(outputMessage, "About");
        }



        private void updateMixedDisplay(){

            if (!mapIsDrawable)
                return;

            mapMixedDisplay = new Bitmap(1024, 1024);
            int mapHeight = 1024;
            int mapWidth = 1024;

            using (Graphics g = Graphics.FromImage(mapMixedDisplay))
            {

                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                // Graphics: SNES Mode 1
                // The modes are selected by bits 0-2 of register $2105.
                // The variation of Mode 1 is selected by bit 3 of $2105.
                // The variation of Mode 7 is selected by bit 6 of $2133.
                if (checkBoxBg02.Checked) g.DrawImage(mapBg02U, 0, 0, mapHeight, mapWidth);
                if (checkBoxBg01.Checked) g.DrawImage(mapBg01U, 0, 0, mapHeight, mapWidth);
                if (checkBoxBg02.Checked)
                    if ((mapManager.currentTransparency & 0x03) >= 2)
                    {
                        drawTransparent(mapBg02U, mapMixedDisplay);
                        drawTransparent(mapBg02D, mapMixedDisplay);
                    }
                if (checkBoxBg00.Checked) g.DrawImage(mapBg00U, 0, 0, mapHeight, mapWidth);
                if (checkBoxBg01.Checked) g.DrawImage(mapBg01D, 0, 0, mapHeight, mapWidth);
                if (checkBoxBg00.Checked) g.DrawImage(mapBg00D, 0, 0, mapHeight, mapWidth);
                if (checkBoxBg02.Checked)
                    if ((mapManager.currentTransparency & 0x03) == 1)
                    {
                        drawTransparent(mapBg02U, mapMixedDisplay);
                        drawTransparent(mapBg02D, mapMixedDisplay);
                    }
                if (checkBoxBg02.Checked) { if ((mapManager.currentTransparency & 0x03) == 00) g.DrawImage(mapBg02D, 0, 0, mapHeight, mapWidth); }

                if (checkBoxBgNPCs.Checked) g.DrawImage(mapNPCs, 0, 0, mapHeight, mapWidth);
                if (checkBoxBgMiscs.Checked) drawTransparent(mapMiscs, mapMixedDisplay);
                if (checkBoxBgWalls.Checked) drawTransparent(mapBgWalls, mapMixedDisplay);
            }
        }



        private void updateMap()
        {
            if (!fileToEditIsAvailable)
                return;

            if (currentMap == (int)numericUpDownMap.Value)
                return;

            Cursor.Current = Cursors.WaitCursor;

            mapIsDrawable = false;
            currentMap = (int)numericUpDownMap.Value;

            System.IO.FileStream fs = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open);
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs, new UnicodeEncoding());

            bool output = mapManager.mapDecypher(br, headerOffset, (int)numericUpDownMap.Value, (int)numericUpDownQuadrant.Value, out mapBg00U, out mapBg00D, out mapBg01U, out mapBg01D, out mapBg02U, out mapBg02D, out mapBgWalls);

            // HACKME
            mapNPCs  = new Bitmap(64 * 8 * 2, 64 * 8 * 2);
            mapMiscs = new Bitmap(64 * 8 * 2, 64 * 8 * 2);
            mapManager.mapGetNPCs(br, headerOffset, ((int)numericUpDownMap.Value), mapNPCs);
            mapManager.mapGetExits(br, headerOffset, ((int)numericUpDownMap.Value), ((int)numericUpDownQuadrant.Value), mapMiscs);
            mapManager.mapGetChests(br, headerOffset, ((int)numericUpDownMap.Value), mapMiscs);
            mapManager.mapGetEvents(br, headerOffset, ((int)numericUpDownMap.Value), ((int)numericUpDownQuadrant.Value), mapMiscs);
            //String everyChestInfo = mapManager.getEveryChestInfo(br, headerOffset, itemNames, spellNames);
            //MessageBox.Show(everyChestInfo);

            br.Close();
            fs.Close();


            mapBg00D.MakeTransparent(Color.Black);
            mapBg00U.MakeTransparent(Color.Black);
            mapBg01D.MakeTransparent(Color.Black);
            mapBg01U.MakeTransparent(Color.Black);
            mapBg02D.MakeTransparent(Color.Black);
            mapBg02U.MakeTransparent(Color.Black);
            //mapBgWalls.MakeTransparent(Color.Black);
            //mapNPCs.MakeTransparent(Color.Black);

            updateTileset();

            tilesetVRAM = mapManager.getBgTileset();
            bgPalette = mapManager.getCurrentPalette((int)numericUpDownMap.Value);

            mapIsDrawable = output;

            textBoxMapProperties.Text = mapManager.getMapProperties((int)numericUpDownMap.Value);

            updateMixedDisplay();
            panelCurrenTile.Refresh();
            panelBoxMap.Refresh();
            bufferPanelVRAM.Refresh();
            panelCurrentPalette.Refresh();

            labelLocationName.Text = mapManager.getLocationName(currentMap);

            if(currentMap > 4){
                buttonSaveBg00.Enabled = true;
                buttonSaveBg01.Enabled = true;
                numericUpDownQuadrant.Enabled = false;
            }else{
                buttonSaveBg00.Enabled = true;
                buttonSaveBg01.Enabled = false;
                numericUpDownQuadrant.Enabled = true;
            }

            updatePropertiesComboBoxes();

            textBoxMapEncounters.Text = mapManager.getEncounters(
                Convert.ToInt16(numericUpDownMap.Value),
                Convert.ToInt16(numericUpDownQuadrant.Value)
                );

            labelEnemyFormation.Text = mapManager.encounters[Convert.ToInt16(numericUpDownEnemyFormations.Value)].Replace(", ", "\r\n");
            labelEnemyGroups.Text = mapManager.monsterGroups[Convert.ToInt16(numericUpDownEnemyGroups.Value)];

            // Display Tileset Form
            tilesetForm.updateTileset(mapManager.tiles16x16, mapManager.tileProperties, numericUpDownMap.Value < 5);
            tilesetForm.refreshChosenTilesDisplay(checkBoxBg00.Checked, checkBoxBg01.Checked);
            tilesetForm.Show();

            Cursor.Current = Cursors.Default;
        }



        private void updatePropertiesComboBoxes()
        {
            comboBoxEvents.Items.Clear();
            comboBoxNPCs.Items.Clear();
            comboBoxExits.Items.Clear();
            comboBoxTreasures.Items.Clear();

            foreach (Event item in mapManager.events)
            {
                comboBoxEvents.Items.Add(item.address.ToString("X6"));
            }

            foreach (NPC item in mapManager.npcs)
            {
                comboBoxNPCs.Items.Add(item.address.ToString("X6"));
            }

            foreach (MapExit item in mapManager.exits)
            {
                comboBoxExits.Items.Add(item.address.ToString("X6"));
            }

            foreach (Treasure item in mapManager.treasures)
            {
                comboBoxTreasures.Items.Add(item.address.ToString("X6"));
            }



            if (comboBoxEvents.Items.Count > 0)
            {
                comboBoxEvents.SelectedIndex = 0;
                numericUpDownEventX.Enabled = true;
                numericUpDownEventY.Enabled = true;
                numericUpDownEventID.Enabled = true;
            }
            else
            {
                numericUpDownEventX.Enabled = false;
                numericUpDownEventY.Enabled = false;
                numericUpDownEventID.Enabled = false;
            }


            if (comboBoxNPCs.Items.Count > 0)
            {
                comboBoxNPCs.SelectedIndex = 0;
                numericUpDownNPCsActionID.Enabled = true;
                numericUpDownNPCsGraphicId.Enabled = true;
                numericUpDownNPCsX.Enabled = true;
                numericUpDownNPCsY.Enabled = true;
                numericUpDownNPCsProperties.Enabled = true;
                numericUpDownNPCsWP.Enabled = true;
            }
            else
            {
                numericUpDownNPCsActionID.Enabled = false;
                numericUpDownNPCsGraphicId.Enabled = false;
                numericUpDownNPCsX.Enabled = false;
                numericUpDownNPCsY.Enabled = false;
                numericUpDownNPCsProperties.Enabled = false;
                numericUpDownNPCsWP.Enabled = false;

                npc = new Bitmap(1, 1);
                panelNPCSprite.Refresh();
            }


            if (comboBoxExits.Items.Count > 0)
            {
                comboBoxExits.SelectedIndex = 0;
                numericUpDownExitOriginX.Enabled = true;
                numericUpDownExitOriginY.Enabled = true;
                numericUpDownExitMapId.Enabled = true;
                numericUpDownExitProperties.Enabled = true;
                numericUpDownExitDestinationX.Enabled = true;
                numericUpDownExitDestinationY.Enabled = true;
            }
            else
            {
                numericUpDownExitOriginX.Enabled = false;
                numericUpDownExitOriginY.Enabled = false;
                numericUpDownExitMapId.Enabled = false;
                numericUpDownExitProperties.Enabled = false;
                numericUpDownExitDestinationX.Enabled = false;
                numericUpDownExitDestinationY.Enabled = false;
            }


            if (comboBoxTreasures.Items.Count > 0)
            {
                comboBoxTreasures.SelectedIndex = 0;

                numericUpDownTreasureX.Enabled = true;
                numericUpDownTreasureX.Enabled = true;
                numericUpDownTreasureContentId.Enabled = true;
                comboBoxTreasureBehavior.Enabled = true;
                numericUpDownTreasureContentId.Enabled = true;
            }
            else
            {
                numericUpDownTreasureX.Enabled = false;
                numericUpDownTreasureX.Enabled = false;
                numericUpDownTreasureContentId.Enabled = false;
                comboBoxTreasureBehavior.Enabled = false;
                numericUpDownTreasureContentId.Enabled = false;

                labelTreasureDisplay.Text = "";
            }

            List<Byte> mapDescriptors = mapManager.getMapDescriptors(Convert.ToInt32(numericUpDownMap.Value));

            numericUpDownDescriptor00.Value = mapDescriptors[0x00];
            numericUpDownDescriptor01.Value = mapDescriptors[0x01];
            numericUpDownDescriptor02.Value = mapDescriptors[0x02];
            numericUpDownDescriptor03.Value = mapDescriptors[0x03];
            numericUpDownDescriptor04.Value = mapDescriptors[0x04];
            numericUpDownDescriptor05.Value = mapDescriptors[0x05];
            numericUpDownDescriptor06.Value = mapDescriptors[0x06];
            numericUpDownDescriptor07.Value = mapDescriptors[0x07];
            numericUpDownDescriptor08.Value = mapDescriptors[0x08];
            numericUpDownDescriptor09.Value = mapDescriptors[0x09];
            numericUpDownDescriptor0A.Value = mapDescriptors[0x0A];
            numericUpDownDescriptor0B.Value = mapDescriptors[0x0B];
            numericUpDownDescriptor0C.Value = mapDescriptors[0x0C];
            numericUpDownDescriptor0D.Value = mapDescriptors[0x0D];
            numericUpDownDescriptor0E.Value = mapDescriptors[0x0E];
            numericUpDownDescriptor0F.Value = mapDescriptors[0x0F];
            numericUpDownDescriptor10.Value = mapDescriptors[0x10];
            numericUpDownDescriptor11.Value = mapDescriptors[0x11];
            numericUpDownDescriptor12.Value = mapDescriptors[0x12];
            numericUpDownDescriptor13.Value = mapDescriptors[0x13];
            numericUpDownDescriptor14.Value = mapDescriptors[0x14];
            numericUpDownDescriptor15.Value = mapDescriptors[0x15];
            numericUpDownDescriptor16.Value = mapDescriptors[0x16];
            numericUpDownDescriptor17.Value = mapDescriptors[0x17];
            numericUpDownDescriptor18.Value = mapDescriptors[0x18];
            numericUpDownDescriptor19.Value = mapDescriptors[0x19];
        }



        private void panelBoxMap_Paint(object sender, PaintEventArgs e)
        {
            if (!mapIsDrawable)
                return;
            
            int mapHeight = Convert.ToInt32(mapBg00U.Height * mapZoom);
            int mapWidth = Convert.ToInt32(mapBg00U.Width * mapZoom);
            int maxSize = Convert.ToInt32(1024 * mapZoom);

            //panelMap.MaximumSize = new Size(maxSize, maxSize);

            //if ((panelBoxMap.Height != mapHeight && panelBoxMap.Height != maxSize) || (panelBoxMap.Width != mapWidth && panelBoxMap.Width != maxSize))
            // {
            //    panelBoxMap.Height = mapHeight;
            //    panelBoxMap.Width = mapWidth;
            //    panelMap.MaximumSize = new Size(maxSize, maxSize);
            //}


            e.Graphics.Clear(Color.Black);
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            
            e.Graphics.DrawImage(mapMixedDisplay, 0, 0, mapHeight, mapWidth);

            Pen whitePen = new Pen(Color.White, 1);
            e.Graphics.DrawRectangle(whitePen, tilesetForm.getClipboardRectangle(Convert.ToInt32(mapZoom)));
            whitePen.Dispose();

            panelMap.AutoScroll = true;
            panelMap.Scale(new SizeF(1, 1));
            panelMap.AutoScrollMinSize = new Size(mapWidth - 1, mapHeight - 1);
        }



        private void drawTransparent(Bitmap bmp, Bitmap destination, bool adictive=true)
        {
            int bytesToExport = bmp.Height * bmp.Width * 3;
            byte[] byteArraybmpA = new byte[bytesToExport];
            byte[] byteArraybmpB = new byte[bytesToExport];
            byte[] byteArraybmpC = new byte[bytesToExport];

            Bitmap bmpA = bmp;
            Bitmap bmpB = destination;
            Bitmap bmpC = destination;

            System.Drawing.Imaging.BitmapData dataA = bmpA.LockBits(new Rectangle(0, 0, bmpA.Width, bmpA.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            System.Runtime.InteropServices.Marshal.Copy(dataA.Scan0, byteArraybmpA, 0, bytesToExport);

            System.Drawing.Imaging.BitmapData dataB = bmpB.LockBits(new Rectangle(0, 0, bmpB.Width, bmpB.Height), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            System.Runtime.InteropServices.Marshal.Copy(dataB.Scan0, byteArraybmpB, 0, bytesToExport);

            if(adictive)
                byteArraybmpC = byteArraybmpA.Zip(byteArraybmpB, (x, y) => (Byte)Math.Min(x + y, 0xFF)).ToArray();
            else
                byteArraybmpC = byteArraybmpA.Zip(byteArraybmpB, (x, y) => (Byte)Math.Max(y - x, 0x00)).ToArray();
            bmpA.UnlockBits(dataA);
            bmpB.UnlockBits(dataB);

            System.Drawing.Imaging.BitmapData dataC = bmpC.LockBits(new Rectangle(0, 0, bmpC.Width, bmpC.Height), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            System.Runtime.InteropServices.Marshal.Copy(byteArraybmpC, 0, dataC.Scan0, bytesToExport);
            bmpC.UnlockBits(dataC);
        }



        private void checkBoxBg_CheckedChanged(object sender, EventArgs e)
        {
            updateMixedDisplay();
            panelBoxMap.Refresh();
        }



        private void numericUpDownMap_ValueChanged(object sender, EventArgs e)
        {
            updateMap();
        }



        private void numericUpDownQuadrant_ValueChanged(object sender, EventArgs e)
        {
            int aux = currentMap;
            currentMap = -1;

            updateMap();

            currentMap = aux;
        }



        private void panelBoxMap_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mapIsDrawable) return;

            //if (movingPanelScroll)
            //{
            //    int newVSValue = panelMap.VerticalScroll.Value + (e.Y - panelBoxMapBeginScrolly);
            //    int newHSValue = panelMap.HorizontalScroll.Value + (e.X - panelBoxMapBeginScrollx);
            //
            //    if (newVSValue > panelMap.VerticalScroll.Minimum && newVSValue < panelMap.VerticalScroll.Maximum) panelMap.VerticalScroll.Value = newVSValue;
            //    if (newHSValue > panelMap.HorizontalScroll.Minimum && newHSValue < panelMap.HorizontalScroll.Maximum) panelMap.HorizontalScroll.Value = newHSValue;
            //
            //    panelBoxMapBeginScrollx = e.X;
            //    panelBoxMapBeginScrolly = e.Y;
            //
            //    return;
            //}

            int x = Convert.ToInt32(Math.Truncate((e.X - 1) / (8 * mapZoom)));
            int y = Convert.ToInt32(Math.Truncate((e.Y - 1) / (8 * mapZoom)));

            if (x > 127 || y > 127)
                return;

            labelPointedTile.Text  = "Tile " + x.ToString("X2") + ", " + y.ToString("X2") + 
                                     " (" + (x/2).ToString("X2") + ", " + (y/2).ToString("X2") + ")";

            if (mapManager == null || mapManager.tilesBg0.Count == 0)
                return;

            String text;
            int tileId00 = 0;

            text = "\r\nTile id = ";
            if (mapManager.tilemap00.Count >= 1024)
            {
                tileId00 = mapManager.tilemap00[(x / 2) + ((y / 2) * 0x40)];
                text += tileId00.ToString("X2") + "\r\n";
            }
            else
                text += "00\r\n";

            if (currentMap > 4)
            {
                text += mapManager.tilesBg0[x][y].toString() + "\r\n\r\n";

                text += "Bg02\r\nTile id = ";
                if (mapManager.tilemap02.Count >= 1024)
                    text += mapManager.tilemap02[(x / 2) + ((y / 2) * 0x40)].ToString("X2") + "\r\n";
                else
                    text += "00\r\n";
                text += mapManager.tilesBg2[x][y].toString();
            }
            else
            {
                text += "\r\nProperties\r\n";
                text += mapManager.displayWorlMapTileProperty(tileId00);
            }
            labelPointedTileBg0.Text = text;


            text  = "\r\nTile id = ";
            if (mapManager.tilemap01.Count >= 1024)
                text += mapManager.tilemap01[(x/2) + ((y/2) * 0x40)].ToString("X2") + "\r\n";
            else
                text += "00\r\n";
            text += mapManager.tilesBg1[x][y].toString() + "\r\n\r\n";
            text += "Properties\r\n";

            Byte propByte0 = mapManager.tilePropertiesL[x + (y * 0x80)];
            Byte propByte1 = mapManager.tilePropertiesH[x + (y * 0x80)];

            text += propByte0.ToString("X2") + " (" + Convert.ToString(propByte0, 2).PadLeft(8, '0') + ")\r\n";
            text += propByte1.ToString("X2") + " (" + Convert.ToString(propByte1, 2).PadLeft(8, '0') + ")\r\n";

            if (currentMap > 4)
                labelPointedTileBg1.Text = text;
            else
                labelPointedTileBg1.Text = "";
        }



        private void panelBoxMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (mapManager == null || mapManager.tilesBg0.Count == 0)
                return;

            //Right button
            if (e.Button == MouseButtons.Right) return;


            int chosenTileXEnd = Convert.ToInt32(Math.Truncate((e.X - 1) / (16 * mapZoom)));
            int chosenTileYEnd = Convert.ToInt32(Math.Truncate((e.Y - 1) / (16 * mapZoom)));
            int index = chosenTileXEnd + chosenTileYEnd * 64;
            bool isWorldMap = numericUpDownMap.Value < 5;

            //Equivalent to MouseUp
            tilesetForm.updateChosenTileArea_endArea(chosenTileXEnd, chosenTileYEnd);

            nUNDUpdatable = false;
            if (mapManager.tilemap00.Count > index)
                numericUpDownSelectedTileBg00.Value = mapManager.tilemap00[index];
            if (mapManager.tilemap01.Count > index)
                numericUpDownSelectedTileBg01.Value = mapManager.tilemap01[index];
            nUNDUpdatable = true;


            //Left button
            if (e.Button == MouseButtons.Left)
            {
                updateChoosenTiles();
                panelCurrenTile.Refresh();
            }

            panelBoxMap.Refresh();

            if (checkBoxBgNPCs.Checked)
                displayNPCInfo(isWorldMap);
        }



        private void panelBoxMap_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tilesetForm.updateChosenTileArea_beginArea(
                    Convert.ToInt32(Math.Truncate((e.X - 1) / (16 * mapZoom))),
                    Convert.ToInt32(Math.Truncate((e.Y - 1) / (16 * mapZoom)))
                    );
            }

            if (e.Button == MouseButtons.Right)
            {
                int x = Convert.ToInt32(Math.Truncate((e.X - 1) / (16 * mapZoom)));
                int y = Convert.ToInt32(Math.Truncate((e.Y - 1) / (16 * mapZoom)));

                pasteChoosenTiles(x, y);
            }
        }



        private void updateChoosenTiles()
        {
            tilesetForm.updateChosenTiles(
                mapManager.tilemap00,
                mapManager.tilemap01,
                checkBoxBg00.Checked,
                checkBoxBg01.Checked);
        }
       


        private void pasteChoosenTiles(int x, int y)
        {
            if (mapManager == null || !nUNDUpdatable)
                return;

            Cursor.Current = Cursors.WaitCursor;

            int chosenTileX, chosenTileY, chosenTileXEnd, chosenTileYEnd;
            List<List<Byte>> chosenTileId00;
            List<List<Byte>> chosenTileId01;

            tilesetForm.getClipboardInformation(
                out chosenTileX,
                out chosenTileY,
                out chosenTileXEnd,
                out chosenTileYEnd,
                out chosenTileId00,
                out chosenTileId01);

            List<List<Byte>> bg00TopasteIn = (checkBoxBg00.Checked) ?
                new List<List<Byte>>(chosenTileId00) :
                new List<List<Byte>>();
            List<List<Byte>> bg01TopasteIn = (checkBoxBg01.Checked) ?
                new List<List<Byte>>(chosenTileId01) :
                new List<List<Byte>>();



            mapManager.modifyBg0xTiles(
                x,
                y,
                Math.Min(x + (chosenTileXEnd - chosenTileX), 0x3F) + 1,
                Math.Min(y + (chosenTileYEnd - chosenTileY), 0x3F) + 1,
                bg00TopasteIn,
                bg01TopasteIn,
                mapBg00D, mapBg00U, mapBg01D, mapBg01U, mapBgWalls,
                numericUpDownMap.Value < 5);

            updateMixedDisplay();
            panelBoxMap.Refresh();

            Cursor.Current = Cursors.Default;
        }



        private void numericUpDownSelectedTile_ValueChanged(object sender, EventArgs e)
        {
            if (mapManager == null || !nUNDUpdatable || mapManager.tilesBg0.Count == 0)
                return;

            if (tilesetForm.moreThanOneTileSelected())
                return;

            int chosenTileX, chosenTileY;
            tilesetForm.getClipboardInformation(out chosenTileX, out chosenTileY);

            if (numericUpDownSelectedTileBg00.Value != mapManager.tilemap00[chosenTileX + chosenTileY * 64])
            {
                mapManager.modifyBg00Tile(chosenTileX, chosenTileY, (Byte)numericUpDownSelectedTileBg00.Value,
                    mapBg00D, mapBg00U, mapBgWalls, numericUpDownMap.Value < 5);
            }

            updateMixedDisplay();
            panelBoxMap.Refresh();

            bufferPanelVRAM.Refresh();
            panelCurrentPalette.Refresh();
        }



        private void numericUpDownSelectedTileBg01_ValueChanged(object sender, EventArgs e)
        {
            if (mapManager == null || !nUNDUpdatable || mapManager.tilesBg1.Count == 0 || mapManager.tilemap01.Count == 0)
                return;

            if (tilesetForm.moreThanOneTileSelected())
                return;

            int chosenTileX, chosenTileY;
            tilesetForm.getClipboardInformation(out chosenTileX, out chosenTileY);

            if (numericUpDownSelectedTileBg01.Value != mapManager.tilemap01[chosenTileX + chosenTileY * 64])
            {
                mapManager.modifyBg01Tile(chosenTileX, chosenTileY, (Byte)numericUpDownSelectedTileBg01.Value,
                    mapBg01D, mapBg01U, mapBgWalls);
            }

            updateMixedDisplay();
            panelBoxMap.Refresh();
        }



        private void displayNPCInfo(bool isWorldMap)
        {
            int quadrant = Convert.ToInt16(numericUpDownQuadrant.Value);
            int x, y;
            tilesetForm.getClipboardInformation(out x, out y);

            if (isWorldMap)
            {
                x += ((quadrant & 0x03) >> 0) * 0x40;
                y += ((quadrant & 0x0C) >> 2) * 0x40;
            }

            List<String> npcProperties = mapManager.getNPCProperties(x, y);
            if (npcProperties.Count > 0) foreach (String item in npcProperties) MessageBox.Show(item, "NPC");

            String exitProperties = "";
            exitProperties += mapManager.getMapExitProperties(x, y, isWorldMap);
            if (exitProperties != "") MessageBox.Show(exitProperties, "Exit");

            String chestProperties = mapManager.getChestsProperties(x, y);
            if (chestProperties != "") MessageBox.Show(chestProperties, "Chest");

            Event eventProperties = mapManager.getEventsProperties(x, y);
            if (eventProperties != null)
            {
                DisplayEvent newForm = new DisplayEvent(eventProperties);
                newForm.ShowDialog();
                newForm.Dispose();
            }
        }



        private void buttonSaveBg00_Click(object sender, EventArgs e)
        {
            if (!fileToEditIsAvailable)
            {
                openSMCToolStripMenuItem_Click(null, null);
                if (!fileToEditIsAvailable)
                    return;
            }

            System.IO.FileStream fsInput = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
            System.IO.FileStream fsOutput = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);
            
            if (numericUpDownMap.Value < 5){
                System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fsOutput, new UnicodeEncoding());
                mapManager.saveBgWorldMap00(bw, headerOffset, Convert.ToInt32(numericUpDownMap.Value), Convert.ToInt32(numericUpDownQuadrant.Value));
                bw.Close();
            }
            else
                mapManager.saveBg(fsInput, fsOutput, headerOffset, currentMap, 0x00);

            fsOutput.Close();
            fsInput.Close();
        }



        private void buttonSaveBg01_Click(object sender, EventArgs e)
        {
            if (!fileToEditIsAvailable)
            {
                openSMCToolStripMenuItem_Click(null, null);
                if (!fileToEditIsAvailable)
                    return;
            }

            if (numericUpDownMap.Value < 5) return;

            System.IO.FileStream fsInput = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
            System.IO.FileStream fsOutput = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open, System.IO.FileAccess.Write, System.IO.FileShare.ReadWrite);

            mapManager.saveBg(fsInput, fsOutput, headerOffset, currentMap, 0x01);

            fsOutput.Close();
            fsInput.Close();
        }



        private void buttonZoom_Click(object sender, EventArgs e)
        {
            if (!mapIsDrawable)
                return;

            ManageBMP.exportBPM(fileUnderEditionS, mapMixedDisplay);

            /*
            PictureBox pictureBox = new PictureBox();

            pictureBox.SizeMode   = PictureBoxSizeMode.CenterImage;
            pictureBox.ClientSize = new Size(1024, 1024);
            pictureBox.Image      = zoomBitmap;
            pictureBox.Dock       = DockStyle.Fill;

            using (Form form = new Form())
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Size = new Size(1070, 1090);
                form.Icon = this.Icon;

                form.Controls.Add(pictureBox);
                form.ShowDialog();
            }
            */
        }



        private void bufferPanelVRAM_Paint(object sender, PaintEventArgs e)
        {
            if (!mapIsDrawable)
                return;

            bufferPanelVRAM.Height = 1024;
            bufferPanelVRAM.Width = 256;

            panelBoxVRAM.AutoScroll = true;
            panelMap.Scale(new SizeF(1, 1));
            panelBoxVRAM.AutoScrollMinSize = new Size(256, 1024);

            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(tilesetVRAM, new Rectangle(1, 0, 257, 1024));
        }



        private void panelCurrentPalette_Paint(object sender, PaintEventArgs e)
        {
            if (!mapIsDrawable)
                return;

            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(bgPalette, new Rectangle(1, 1, 257, 129));
        }


        
        private void numericUpDownZoom_ValueChanged(object sender, EventArgs e)
        {
            mapZoom = Convert.ToDouble(numericUpDownZoom.Value);
            //updateMixedDisplay();
            panelBoxMap.Refresh();
        }

        

        #region Tileset_Tab
        


        private void updateTileset()
        {
            List<tile16x16> tiles16x16 = mapManager.tiles16x16;
            List<Byte> tileProperties = mapManager.tileProperties;
            bool isWorldMap = numericUpDownMap.Value < 5;

            tileSetBitmap = new Bitmap(0x0100, 0x0100);

            tileSetMap.Clear();
            tileSetMap.AddRange(tiles16x16);

            int x = 0, y = 0;
            foreach (tile16x16 item in tileSetMap)
            {
                item.draw(x, y, tileSetBitmap, true, false);
                item.draw(x, y, tileSetBitmap, false, false);

                x += 0x10;
                if (x == 0x0100)
                {
                    x = 0x00;
                    y += 0x10;
                }
            }

            panelTilesetDisplay.Refresh();
        }
        
        
        
        private void panelTilemapDisplay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(tileSetBitmap, 1, 1, 512, 512);
        }



        private void panelTilemapDisplay_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (mapManager == null || mapManager.tiles16x16 == null) return;

            List<tile16x16> tiles16x16 = mapManager.tiles16x16;
            List<Byte> tileProperties = mapManager.tileProperties;
            bool isWorldMap = numericUpDownMap.Value < 5;

            int x = ((e.X - 1) / 32);
            int y = ((e.Y - 1) / 32);
            int tileId = (x + (y << 4));

            String text = "Tile\r\n";

            if (isWorldMap)
            {
                text += x.ToString("X2") + ", " + y.ToString("X2") + " (" + tileId.ToString("X2") + ")\r\n";
                text += "\r\n";

                if (tileId < 0xC0)
                {
                    Byte propByte0 = tileProperties[0 + tileId * 3];
                    Byte propByte1 = tileProperties[1 + tileId * 3];
                    Byte propByte2 = tileProperties[2 + tileId * 3];

                    text += propByte0.ToString("X2") + " (" + Convert.ToString(propByte0, 2).PadLeft(8, '0') + ")\r\n";
                    text += propByte1.ToString("X2") + " (" + Convert.ToString(propByte1, 2).PadLeft(8, '0') + ")\r\n";
                    text += propByte2.ToString("X2") + " (" + Convert.ToString(propByte2, 2).PadLeft(8, '0') + ")\r\n\r\n";

                    text += mapManager.displayWorlMapTileProperty(tileId);

                }
            }
            else
            {
                Byte propByte0 = tileProperties[tileId * 2];
                Byte propByte1 = tileProperties[1 + tileId * 2];

                text += x.ToString("X2") + ", " + y.ToString("X2") + " (" + tileId.ToString("X2") + ")\r\n";
                text += "\r\n";
                text += propByte0.ToString("X2") + " (" + Convert.ToString(propByte0, 2).PadLeft(8, '0') + ")\r\n";
                text += propByte1.ToString("X2") + " (" + Convert.ToString(propByte1, 2).PadLeft(8, '0') + ")\r\n";
            }
            labelTileMouse.Text = text;
        }



        #endregion



        #region Properties_Tab



        private void numericUpDownNPCsProperty_ValueChanged(object sender, EventArgs e)
        {
            int graphicId = Convert.ToInt32(numericUpDownNPCsGraphicId.Value);
            int properties = Convert.ToInt32(numericUpDownNPCsProperties.Value);

            npc = mapManager.getNPCSprite(graphicId, properties);

            panelNPCSprite.Refresh();
        }



        private void panelNPCSprite_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(npc, 0, 0, 65, 65);
        }



        private void buttonEventDisplay_Click(object sender, EventArgs e)
        {
            if (comboBoxEvents.Items.Count <= 0)
                return;

            if (!fileToEditIsAvailable)
            {
                openSMCToolStripMenuItem_Click(null, null);
                if (!fileToEditIsAvailable)
                    return;
            }

            System.IO.FileStream fs = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open);
            System.IO.BinaryReader br = new System.IO.BinaryReader(fs, new UnicodeEncoding());

            int eventId = Convert.ToInt32(numericUpDownEventID.Value);
            Byte[] data = {
                              Decimal.ToByte(numericUpDownEventX.Value),
                              Decimal.ToByte(numericUpDownEventY.Value),
                              Convert.ToByte((eventId & 0x00FF) >> 0),
                              Convert.ToByte((eventId & 0xFF00) >> 8)
                          };

            Event eventPreview = new Event(
                long.Parse(comboBoxEvents.Text, System.Globalization.NumberStyles.HexNumber),
                data, br, headerOffset);

            DisplayEvent newForm = new DisplayEvent(eventPreview);
            newForm.ShowDialog();
            newForm.Dispose();

            br.Close();
            fs.Close();
        }



        private void comboBoxTreasureProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTreasures.Items.Count <= 0 || comboBoxTreasureBehavior.SelectedIndex < 0)
                return;

            Byte itemId = Convert.ToByte(numericUpDownTreasureContentId.Value);
            Byte properties = Convert.ToByte((comboBoxTreasureBehavior.SelectedIndex << 5) + numericUpDownTreasureModifier.Value);
            Byte[] data = { 0, 0, properties, itemId };

            Treasure treasure = new Treasure(0, data);
            
            labelTreasureDisplay.Text = treasure.getPrice(mapManager.itemNames, mapManager.spellNames);
        }
        

        
        private void comboBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxEvents.Items.Count > 0)
            {
                numericUpDownEventX.Value = mapManager.events[comboBoxEvents.SelectedIndex].x;
                numericUpDownEventY.Value = mapManager.events[comboBoxEvents.SelectedIndex].y;
                numericUpDownEventID.Value = mapManager.events[comboBoxEvents.SelectedIndex].actionId;
            }
            else
            {
                numericUpDownEventX.Value = 0;
                numericUpDownEventY.Value = 0;
                numericUpDownEventID.Value = 0;
            }
        }



        private void buttonInjectEvent_Click(object sender, EventArgs e)
        {
            if (comboBoxEvents.Items.Count <= 0)
                return;

            if (!fileToEditIsAvailable)
            {
                openSMCToolStripMenuItem_Click(null, null);
                if (!fileToEditIsAvailable)
                    return;
            }

            System.IO.FileStream fs = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open);
            System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs, new UnicodeEncoding());

            Event.injectEvent(bw, headerOffset,
                long.Parse(comboBoxEvents.Text, System.Globalization.NumberStyles.HexNumber),
                Decimal.ToByte(numericUpDownEventX.Value),
                Decimal.ToByte(numericUpDownEventY.Value),
                Decimal.ToInt32(numericUpDownEventID.Value));

            bw.Close();
            fs.Close();

            currentMap = -1;
            updateMap();
        }



        private void comboBoxExits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxExits.Items.Count > 0)
            {
                numericUpDownExitOriginX.Value = mapManager.exits[comboBoxExits.SelectedIndex].originX;
                numericUpDownExitOriginY.Value = mapManager.exits[comboBoxExits.SelectedIndex].originY;
                numericUpDownExitMapId.Value = mapManager.exits[comboBoxExits.SelectedIndex].mapId & 0x01FF;
                numericUpDownExitProperties.Value = (mapManager.exits[comboBoxExits.SelectedIndex].mapId & 0xFE00) >> 9;
                numericUpDownExitDestinationX.Value = mapManager.exits[comboBoxExits.SelectedIndex].destinationX;
                numericUpDownExitDestinationY.Value = mapManager.exits[comboBoxExits.SelectedIndex].destinationY;
            }
            else
            {
                numericUpDownExitOriginX.Value = 0;
                numericUpDownExitOriginY.Value = 0;
                numericUpDownExitMapId.Value = 0;
                numericUpDownExitProperties.Value = 0;
                numericUpDownExitDestinationX.Value = 0;
                numericUpDownExitDestinationY.Value = 0;
            }
        }



        private void buttonInjectExit_Click(object sender, EventArgs e)
        {
            if (comboBoxExits.Items.Count <= 0)
                return;

            if (!fileToEditIsAvailable)
            {
                openSMCToolStripMenuItem_Click(null, null);
                if (!fileToEditIsAvailable)
                    return;
            }

            System.IO.FileStream fs = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open);
            System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs, new UnicodeEncoding());

            MapExit.injectExit(bw, headerOffset,
                long.Parse(comboBoxExits.Text, System.Globalization.NumberStyles.HexNumber),
                Decimal.ToByte(numericUpDownExitOriginX.Value),
                Decimal.ToByte(numericUpDownExitOriginY.Value),
                Decimal.ToInt32(numericUpDownExitMapId.Value) + (Decimal.ToInt32(numericUpDownExitProperties.Value) << 9),
                Decimal.ToByte(numericUpDownExitDestinationX.Value),
                Decimal.ToByte(numericUpDownExitDestinationY.Value));

            bw.Close();
            fs.Close();

            currentMap = -1;
            updateMap();
        }



        private void comboBoxNPCs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNPCs.Items.Count > 0)
            {
                numericUpDownNPCsActionID.Value = mapManager.npcs[comboBoxNPCs.SelectedIndex].actionId;
                numericUpDownNPCsGraphicId.Value = mapManager.npcs[comboBoxNPCs.SelectedIndex].graphicId;
                numericUpDownNPCsX.Value = mapManager.npcs[comboBoxNPCs.SelectedIndex].x;
                numericUpDownNPCsY.Value = mapManager.npcs[comboBoxNPCs.SelectedIndex].y;
                numericUpDownNPCsWP.Value = mapManager.npcs[comboBoxNPCs.SelectedIndex].walkingParam;

                int palette = mapManager.npcs[comboBoxNPCs.SelectedIndex].palette;
                int direction = mapManager.npcs[comboBoxNPCs.SelectedIndex].direction;
                int unknown = mapManager.npcs[comboBoxNPCs.SelectedIndex].unknown;
                int properties = (palette) + (unknown << 0x03) + (direction << 0x05);

                numericUpDownNPCsProperties.Value = properties;
            }
            else
            {
                numericUpDownNPCsActionID.Value = 0;
                numericUpDownNPCsGraphicId.Value = 0;
                numericUpDownNPCsX.Value = 0;
                numericUpDownNPCsY.Value = 0;
                numericUpDownNPCsWP.Value = 0;
                numericUpDownNPCsProperties.Value = 0;

                npc = new Bitmap(1, 1);
            }
        }



        private void buttonInjectNPC_Click(object sender, EventArgs e)
        {
            if (comboBoxNPCs.Items.Count <= 0)
                return;

            if (!fileToEditIsAvailable)
            {
                openSMCToolStripMenuItem_Click(null, null);
                if (!fileToEditIsAvailable)
                    return;
            }

            System.IO.FileStream fs = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open);
            System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs, new UnicodeEncoding());

            //comboBoxNPCs
            NPC.injectNPC(bw, headerOffset,
                long.Parse(comboBoxNPCs.Text, System.Globalization.NumberStyles.HexNumber),
                Decimal.ToInt32(numericUpDownNPCsActionID.Value), 
                Decimal.ToByte(numericUpDownNPCsGraphicId.Value),
                Decimal.ToByte(numericUpDownNPCsX.Value),                
                Decimal.ToByte(numericUpDownNPCsY.Value),
                Decimal.ToByte(numericUpDownNPCsWP.Value),
                Decimal.ToByte(numericUpDownNPCsProperties.Value));

            bw.Close();
            fs.Close();

            currentMap = -1;
            updateMap();
        }



        private void comboBoxTreasures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTreasures.Items.Count > 0)
            {
                numericUpDownTreasureX.Value = mapManager.treasures[comboBoxTreasures.SelectedIndex].locationX;
                numericUpDownTreasureY.Value = mapManager.treasures[comboBoxTreasures.SelectedIndex].locationY;
                numericUpDownTreasureContentId.Value = mapManager.treasures[comboBoxTreasures.SelectedIndex].itemId;

                Byte properties = mapManager.treasures[comboBoxTreasures.SelectedIndex].properties;
                comboBoxTreasureBehavior.SelectedIndex = (properties & 0xE0) >> 5;
                numericUpDownTreasureModifier.Value = properties & 0x1F;
            }
            else
            {
                numericUpDownTreasureX.Value = 0;
                numericUpDownTreasureY.Value = 0;
                numericUpDownTreasureContentId.Value = 0;
                comboBoxTreasureBehavior.SelectedIndex = 0;
                numericUpDownTreasureModifier.Value = 0;
            }
        }



        private void buttonInjectTreasure_Click(object sender, EventArgs e)
        {
            if (comboBoxTreasures.Items.Count <= 0 || comboBoxTreasureBehavior.SelectedIndex < 0)
                return;

            if (!fileToEditIsAvailable)
            {
                openSMCToolStripMenuItem_Click(null, null);
                if (!fileToEditIsAvailable)
                    return;
            }

            System.IO.FileStream fs = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open);
            System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs, new UnicodeEncoding());

            //comboBoxTreasures
            long address = long.Parse(comboBoxTreasures.Text, System.Globalization.NumberStyles.HexNumber);
            Byte x = Convert.ToByte(numericUpDownTreasureX.Value);
            Byte y = Convert.ToByte(numericUpDownTreasureY.Value);
            Byte itemId = Convert.ToByte(numericUpDownTreasureContentId.Value);
            Byte properties = Convert.ToByte((comboBoxTreasureBehavior.SelectedIndex << 5) + numericUpDownTreasureModifier.Value);

            Treasure.injectTreasure(bw, headerOffset, address, x, y, properties, itemId);

            bw.Close();
            fs.Close();

            currentMap = -1;
            updateMap();
        }



        private void buttonInjectDescriptors_Click(object sender, EventArgs e)
        {
            if (!fileToEditIsAvailable)
            {
                openSMCToolStripMenuItem_Click(null, null);
                if (!fileToEditIsAvailable)
                    return;
            }

            List<Byte> newDescriptors = new List<Byte>();

            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor00.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor01.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor02.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor03.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor04.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor05.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor06.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor07.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor08.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor09.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor0A.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor0B.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor0C.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor0D.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor0E.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor0F.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor10.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor11.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor12.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor13.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor14.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor15.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor16.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor17.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor18.Value));
            newDescriptors.Add(Convert.ToByte(numericUpDownDescriptor19.Value));

            
            System.IO.FileStream fs = new System.IO.FileStream(fileUnderEdition, System.IO.FileMode.Open);
            System.IO.BinaryWriter bw = new System.IO.BinaryWriter(fs, new UnicodeEncoding());

            mapManager.modifyMapDescriptor(bw, headerOffset, newDescriptors);

            bw.Close();
            fs.Close();

            currentMap = -1;
            updateMap();
        }



        #endregion



        #region Encounters_Tab



        private void numericUpDownEnemyFormations_ValueChanged(object sender, EventArgs e)
        {
            if (!fileToEditIsAvailable) return;

            labelEnemyFormation.Text = mapManager.encounters[Convert.ToInt16(numericUpDownEnemyFormations.Value)].Replace(", ", "\r\n");
        }



        private void numericUpDownEnemyGroups_ValueChanged(object sender, EventArgs e)
        {
            if (!fileToEditIsAvailable) return;

            labelEnemyGroups.Text = mapManager.monsterGroups[Convert.ToInt16(numericUpDownEnemyGroups.Value)];
        }
        


        #endregion
    }
}
