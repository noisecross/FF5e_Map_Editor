/**
* |------------------------------------------|
* | FF5e_Map_editor                          |
* | File: DisplayTilmap.cs                   |
* | v1.2, July 2016                          |
* | Author: noisecross                       |
* |------------------------------------------|
* 
* @author noisecross
* @version 1.1
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

namespace FF5e_Map_Editor
{
    /*
     * This form manages the Display Tilemap window
     */
    public partial class DisplayTilemap : Form
    {


        List<tile16x16> tileSetMap = new List<tile16x16>();
        Bitmap tileSetBitmap = new Bitmap(0x0100, 0x0100);
        bool isWorldMap = true;

        List<Byte> tileProperties = new List<Byte>();



        public DisplayTilemap()
        {
            InitializeComponent();
        }



        public void updateTilemap(List<tile16x16> tiles16x16, List<Byte> tileProperties, bool isWorldMap)
        {
            this.tileProperties.Clear();
            
            this.isWorldMap = isWorldMap;
            this.tileProperties.AddRange(tileProperties);

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
                    x =  0x00;
                    y += 0x10;
                }
            }

            panelTilemapDisplay.Refresh();
        }



        private void panelTilemapDisplay_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            e.Graphics.DrawImage(tileSetBitmap, 1, 1, 512, 512);
        }



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
                    text += propByte2.ToString("X2") + " (" + Convert.ToString(propByte2, 2).PadLeft(8, '0') + ")\r\n";
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



    }
}
