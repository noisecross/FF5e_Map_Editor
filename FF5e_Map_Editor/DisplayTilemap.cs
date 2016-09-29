/**
* |------------------------------------------|
* | FF5e_Map_editor                          |
* | File: DisplayTilmap.cs                   |
* | v1.3, September 2016                     |
* | Author: noisecross                       |
* |------------------------------------------|
* 
* @author noisecross
* @version 1.3
* 
*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FF5e_Text_Editor;

namespace FF5e_Map_Editor
{
    /*
     * This form manages the Display Tilemap window
     */
    public partial class DisplayTileset : Form
    {
        List<tile16x16> tileSetMap = new List<tile16x16>();
        Bitmap tileSetBitmap = new Bitmap(0x0100, 0x0100);
        bool isWorldMap = true;

        List<Byte> tileProperties = new List<Byte>();

        // Clipboard variables
        int              chosenTileX    = 0;
        int              chosenTileY    = 0;
        int              chosenTileXEnd = 0;
        int              chosenTileYEnd = 0;
        List<List<Byte>> chosenTileId00 = new List<List<Byte>>();
        List<List<Byte>> chosenTileId01 = new List<List<Byte>>();
        Bitmap clipboardPicture00 = new Bitmap(1, 1);
        Bitmap clipboardPicture01 = new Bitmap(1, 1);





        public DisplayTileset()
        {
            InitializeComponent();
            this.ControlBox = false;
        }



        /**
        * updateTileset
        * 
        * Update the information about the current tileset to display.
        *
        * @param tiles16x16: List with the tiles16x16 objects to draw the tileset.
        * @param tileProperties: A list which contains the properties of the 256 possible tiles.
        * @param isWorldMap: Bool to inform the current tileset is from a world map.
        */
        public void updateTileset(List<tile16x16> tiles16x16, List<Byte> tileProperties, bool isWorldMap)
        {
            this.tileProperties.Clear();
            
            this.isWorldMap = isWorldMap;
            this.tileProperties.AddRange(tileProperties);

            tileSetBitmap = new Bitmap(0x0100, 0x0100);
            tileSetMap = new List<tile16x16>(tiles16x16);

            int x = 0, y = 0;
            foreach (tile16x16 item in tileSetMap)
            {
                item.draw(x, y, tileSetBitmap, true, false);
                item.draw(x, y, tileSetBitmap, false, false);

                x += 0x10;
                if (x == 0x0100)
                {
                    x =  0x00;
                    y += 0x10;
                }
            }

            panelTilesetDisplay.Refresh();
        }




        #region clipboard



        /**
        * updateChosenTiles
        * 
        * Store a new clipboard.
        *
        * @param tilemap00: The tilemap (layer 00) of the current map under edition.
        * @param tilemap01: The tilemap (layer 01) of the current map under edition.
        * @param bg00Active: Say if the layer 00 is enabled or not to copy from it.
        * @param bg01Active: Say if the layer 00 is enabled or not to copy from it.
        */
        public void updateChosenTiles(List<Byte> tilemap00, List<Byte> tilemap01, bool bg00Active, bool bg01Active)
        {
            chosenTileId00.Clear();
            chosenTileId01.Clear();

            for (int j = chosenTileY; j <= chosenTileYEnd; j++)
            {
                List<Byte> subListBg00 = new List<Byte>();
                List<Byte> subListBg01 = new List<Byte>();

                for (int i = chosenTileX; i <= chosenTileXEnd; i++)
                {
                    if (tilemap00.Count > 0) subListBg00.Add(tilemap00[i + j * 64]);
                    if (tilemap01.Count > 0) subListBg01.Add(tilemap01[i + j * 64]);
                }

                if (tilemap00.Count > 0) chosenTileId00.Add(subListBg00);
                if (tilemap01.Count > 0) chosenTileId01.Add(subListBg01);
            }

            refreshChosenTilesDisplay(bg00Active, bg01Active);
        }



        /**
        * refreshChosenTilesDisplay
        * 
        * Refresh the status of the checkboxes and redraw the clipboard.
        *
        * @param bg00: Say if the layer 00 is enabled or not to display it.
        * @param bg01: Say if the layer 01 is enabled or not to display it.
        */
        public void refreshChosenTilesDisplay(bool bg00, bool bg01)
        {
            checkBoxBg00.Checked = bg00;
            checkBoxBg01.Checked = bg01;

            updateClipboardPicture((chosenTileXEnd - chosenTileX) + 1, (chosenTileYEnd - chosenTileY) + 1, bg00, bg01);
        }



        /**
        * updateChosenTileArea_beginArea
        * 
        * Update the values of which represents the begining of a multitile selection.
        *
        * @param newChosenTileX: X coordinate where the selection begins.
        * @param newChosenTileY: Y coordinate where the selection begins.
        */
        public void updateChosenTileArea_beginArea(int newChosenTileX, int newChosenTileY)
        {
                chosenTileX = newChosenTileX;
                chosenTileY = newChosenTileY;
                if (chosenTileX > 0x3F) chosenTileX = 0x3F;
                if (chosenTileY > 0x3F) chosenTileY = 0x3F;

        }



        /**
        * updateChosenTileArea_endArea
        * 
        * Update the values of which represents the end of a multitile selection.
        * Perform operetions to ensure the begining coordinates are lesser than the ending ones.
        *
        * @param newChosenTileXEnd: X coordinate where the selection ends.
        * @param newChosenTileYEnd: Y coordinate where the selection ends.
        */
        public void updateChosenTileArea_endArea(int newChosenTileXEnd, int newChosenTileYEnd)
        {
            chosenTileXEnd = newChosenTileXEnd;
            chosenTileYEnd = newChosenTileYEnd;
            if (chosenTileXEnd > 0x3F) chosenTileXEnd = 0x3F;
            if (chosenTileYEnd > 0x3F) chosenTileYEnd = 0x3F;

            int tempVar;
            if (chosenTileXEnd < chosenTileX)
            {
                tempVar = chosenTileX;
                chosenTileX = chosenTileXEnd;
                chosenTileXEnd = tempVar;
            }
            if (chosenTileYEnd < chosenTileY)
            {
                tempVar = chosenTileY;
                chosenTileY = chosenTileYEnd;
                chosenTileYEnd = tempVar;
            }
        }



        /**
        * panelTilesetDisplay_MouseClick
        * 
        * Overwrite the clipboard with a single tile from the displayed tileset chosen by a mouse click
        * in the panelTilesetDisplay.
        */
        private void panelTilesetDisplay_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            int       x = ((e.X - 1) / 32);
            int       y = ((e.Y - 1) / 32);
            Byte tileId = Convert.ToByte(x + (y << 4));

            chosenTileX = 0;
            chosenTileY = 0;
            chosenTileXEnd = 0;
            chosenTileYEnd = 0;

            chosenTileId00.Clear();
            chosenTileId01.Clear();

            if (checkBoxBg00.Checked) chosenTileId00.Add(new List<Byte> { tileId });
            if (checkBoxBg01.Checked) chosenTileId01.Add(new List<Byte> { tileId });

            updateClipboardPicture(1, 1, checkBoxBg00.Checked, checkBoxBg01.Checked);
        }



        /**
        * resetClipboard
        * 
        * Clear all values of the clipboard.
        */
        public void resetClipboard()
        {
            chosenTileX = 0;
            chosenTileY = 0;
            chosenTileXEnd = 0;
            chosenTileYEnd = 0;

            chosenTileId00.Clear();
            chosenTileId01.Clear();
            chosenTileId00.Add(new List<Byte> { 0x00 });
            chosenTileId01.Add(new List<Byte> { 0x00 });
        }



        /**
        * getClipboardInformation
        * 
        * Return all the information stored in the clipboard.
        * The chosen tiles are filtered by the layer checboxes.
        * 
        * @param out chosenTileX: X coordinate where the selection begins.
        * @param out chosenTileY: Y coordinate where the selection begins.
        * @param out chosenTileXEnd: X coordinate where the selection ends.
        * @param out chosenTileYEnd: Y coordinate where the selection ends.
        * @param out chosenTileId00: The actual tiles stored in the clipboard (layer 00 filtered).
        * @param out chosenTileId01: The actual tiles stored in the clipboard (layer 01 filtered).
        */
        public void getClipboardInformation(out int chosenTileX, out int chosenTileY, out int chosenTileXEnd, out int chosenTileYEnd, out List<List<Byte>> chosenTileId00, out List<List<Byte>> chosenTileId01)
        {
            chosenTileX    = this.chosenTileX;
            chosenTileY    = this.chosenTileY;
            chosenTileXEnd = this.chosenTileXEnd;
            chosenTileYEnd = this.chosenTileYEnd;
            chosenTileId00 = (checkBoxBg00.Checked) ? this.chosenTileId00 : new List<List<Byte>>();
            chosenTileId01 = (checkBoxBg01.Checked) ? this.chosenTileId01 : new List<List<Byte>>();
        }



        /**
        * getClipboardInformation
        * 
        * Return the position of the initial tile stored in the clipboard.
        * 
        * @param out chosenTileX: X coordinate where the selection begins.
        * @param out chosenTileY: Y coordinate where the selection begins.
        */
        public void getClipboardInformation(out int chosenTileX, out int chosenTileY)
        {
            chosenTileX = this.chosenTileX;
            chosenTileY = this.chosenTileY;
        }



        /**
        * moreThanOneTileSelected
        * 
        * @return: True if the clipboard contains more than one tile.
        */
        public bool moreThanOneTileSelected()
        {
            return (chosenTileX != chosenTileXEnd || chosenTileY != chosenTileYEnd);
        }



        /**
        * updateClipboardPicture
        * 
        * Update the pictures which represent the current clipboard selection.
        * 
        * @param width: Width of the clipboard measured in number of tiles.
        * @param height: Height of the clipboard measured in number of tiles.
        * @param bg00: Say if the layer 00 is enabled or not to display it.
        * @param bg01: Say if the layer 01 is enabled or not to display it.
        */
        private void updateClipboardPicture(int width, int height, bool bg00, bool bg01)
        {
            if (width == 0 || height == 0) return;

            int side = Math.Max(width * 16, height * 16);
            int offX = (side - width  * 16) / 2;
            int offY = (side - height * 16) / 2;

            clipboardPicture00 = new Bitmap(side, side);
            clipboardPicture01 = new Bitmap(side, side);

            for (int j = 0; j < height; j++)
            {
                for (int i = 0; i < width; i++)
                {
                    using (Graphics g = Graphics.FromImage(clipboardPicture00))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                        if (chosenTileId00.Count > 0 && bg00)
                        {
                            int x = (chosenTileId00[j][i] & 0x0F) * 16;
                            int y = (chosenTileId00[j][i] & 0xF0);
                            g.DrawImage(tileSetBitmap, new Rectangle(offX + i * 16, offY + j * 16, 16, 16), new Rectangle(x, y, 16, 16), GraphicsUnit.Pixel);
                        }
                    }

                    using (Graphics g = Graphics.FromImage(clipboardPicture01))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                        if (chosenTileId01.Count > 0 && bg01)
                        {
                            int x = (chosenTileId01[j][i] & 0x0F) * 16;
                            int y = (chosenTileId01[j][i] & 0xF0);
                            g.DrawImage(tileSetBitmap, new Rectangle(offX + i * 16, offY + j * 16, 16, 16), new Rectangle(x, y, 16, 16), GraphicsUnit.Pixel);
                        }
                    }
                }
            }

            panelClipboard.Refresh();
        }



        /**
        * getClipboardRectangle
        * 
        * Return a rectangle which represents the positions of the stored tiles of the
        * clipboard zoomed by a factor.
        * 
        * @param mapZoom: The factor to zoom the Rectangle.
        * 
        * @return: The Rectangle object.
        */
        public Rectangle getClipboardRectangle(int mapZoom)
        {
            return new Rectangle(Convert.ToInt32(chosenTileX * 16 * mapZoom) - 1,
                Convert.ToInt32(chosenTileY * 16 * mapZoom) - 1,
                Convert.ToInt32(((chosenTileXEnd - chosenTileX) + 1) * 16 * mapZoom),
                Convert.ToInt32(((chosenTileYEnd - chosenTileY) + 1) * 16 * mapZoom));
        }



        /**
        * checkBoxBg0x_CheckedChanged
        * 
        * Redraw the clipboard if a checkbox is changed.
        */
        private void checkBoxBg0x_CheckedChanged(object sender, EventArgs e)
        {
            panelClipboard.Refresh();
        }



        /**
        * panelClipboard_Paint
        * 
        * Draw the current clipboard.
        */
        private void panelClipboard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            if (checkBoxBg01.Checked) e.Graphics.DrawImage(clipboardPicture01, 1, 1, 96, 96); 
            if (checkBoxBg00.Checked) e.Graphics.DrawImage(clipboardPicture00, 1, 1, 96, 96);
        }



        #endregion



        /**
        * panelTilemapDisplay_Paint
        * 
        * Draw the current tileset.
        */
        private void panelTilemapDisplay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(tileSetBitmap, 1, 1, 512, 512);
        }



        /**
        * panelTilemapDisplay_MouseMove
        * 
        * Display the properties of a given tile.
        */
        private void panelTilemapDisplay_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
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

                    text += displayWorlMapTileProperty(tileId);
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


        
        /**
        * displayWorlMapTileProperty
        * 
        * Check a World Map tile to get its properties.
        *
        * @param id: The id of the current World Map.
        *
        * @return: The World Map 16x16 tile properties or a blank String.
        */
        private String displayWorlMapTileProperty(int tileId)
        {
            String output = "";
            if (tileId >= 0xC0) return output;

            Byte byte00 = tileProperties[tileId * 3 + 0];
            Byte byte01 = tileProperties[tileId * 3 + 1];
            Byte byte02 = tileProperties[tileId * 3 + 2];

            String[] enemyFormation = { "00: Grass", "01: Forest", "02: Desert/Swamp", "03: Sea" };

            output += tileId.ToString("X2") + " (";
            output += byte00.ToString("X2") + " ";
            output += byte01.ToString("X2") + " ";
            output += byte02.ToString("X2") + ")\r\n";

            output += "\r\nSubmarine can emerge? " +       (((byte00 & 0x80) != 0x00) ? "Yes" : "No");
            output += "\r\nAirship can fly over? " +       (((byte00 & 0x40) != 0x00) ? "Yes" : "No");
            output += "\r\nBoat can navigate? " +          (((byte00 & 0x20) != 0x00) ? "Yes" : "No");
            output += "\r\nSubmarine can navigate? " +     (((byte00 & 0x10) != 0x00) ? "Yes" : "No");
            output += "\r\nHiryuu can fly over? " +        (((byte00 & 0x08) != 0x00) ? "Yes" : "No");
            output += "\r\nBlack chocobo can fly over? " + (((byte00 & 0x04) != 0x00) ? "Yes" : "No");
            output += "\r\nYellow chocobo can walk? " +    (((byte00 & 0x02) != 0x00) ? "Yes" : "No");
            output += "\r\nMain character can walk? " +    (((byte00 & 0x01) != 0x00) ? "Yes" : "No");

            output += "\r\nAirship can land? " +           (((byte01 & 0x80) == 0x00) ? "Yes" : "No");
            output += "\r\nHiryuu can land? " +            (((byte01 & 0x40) == 0x00) ? "Yes" : "No");
            output += "\r\nBlack chocobo can land? " +     (((byte01 & 0x20) == 0x00) ? "Yes" : "No");

            output += "\r\n\r\nEnemy formation: " + enemyFormation[(byte02 & 0x03)];

            // | Forest    C.Green   Green     L.Mnt     H.mnt     Waterfal  River     Desert    Void      Sea      | Floor UW |
            // | 4F CF A1  4F 2F 80  4F 2F 80  44 EF 10  40 EF 10  45 EF 20  4E FF 40  4F EF 82  40 F0 83  7C 70 83 | 91 60 00 |
            // | ---------------------------------------------------------------------------------------------------|----------|
            // | 0         0         0         0         0         0         0         0         0         0        | 1        | Submarine can emerge
            // | 1         1         1         1         1         1         1         1         1         1        | 0        | Airship can fly over
            // | 0         0         0         0         0         0         0         0         0         1        | 0        | Boat can navigate
            // | 0         0         0         0         0         0         0         0         0         1        | 1        | Submarine can navigate
            // | 1         1         1         0         0         0         1         1         0         1        | 0        | Hiryuu can fly over
            // | 1         1         1         1         0         1         1         1         0         1        | 0        | Black chocobo can fly over
            // | 1         1         1         0         0         0         1         1         0         0        | 0        | Yellow chocobo can walk
            // | 1         1         1         0         0         1         0         1         0         0        | 1        | Main character can walk
            // |                                                                                                    |          |
            // | 1         0         0         1         1         1         1         1         1         0        | 0        | Airship cannot land
            // | 1         0         0         1         1         1         1         1         1         1        | 1        | Hiryuu cannot land
            // | 0         1         1         1         1         1         1         1         1         1        | 1        | Black chocobo cannot land
            // | 0         0         0         0         0         0         1         0         1         1        | 0        | ????
            // | 1111      1111      1111      1111      1111      1111      1111      1111      0000      0000     | 0000     | ????
            // |                                                                                                    |          |
            // | 1         1         1         0         0         0         0         1         1         1        | 0        | ????
            // | 0         0         0         0         0         0         1         0         0         0        | 0        | ????
            // | 1         0         0         0         0         1         0         0         0         0        | 0        | ????
            // | 0         0         0         1         1         0         0         0         0         0        | 0        | ????
            // |                                                                                                    |          |
            // | 0001      0000      0000      0000      0000      0000      0000      0010      0011      0011     | 0000     | Enemy encounter
            // | ---------------------------------------------------------------------------------------------------|----------|

            return output;
        }

        

    }
}
