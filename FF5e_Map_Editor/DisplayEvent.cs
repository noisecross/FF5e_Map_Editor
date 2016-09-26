/**
* |------------------------------------------|
* | FF5e_Map_editor                          |
* | File: DisplayEvents.cs                   |
* | v0.80, September 2016                    |
* | Author: noisecross                       |
* |------------------------------------------|
* 
* @author noisecross
* @version 0.80
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
    public partial class DisplayEvent : Form
    {
        private int id = 0;
        private int x  = 0;
        private int y  = 0;

        List<long> addresses = new List<long>();
        List<List<Byte>> bytes = new List<List<Byte>>();

        public DisplayEvent(Event eventToDisplay){
            InitializeComponent();

            id = eventToDisplay.actionId;
            x = eventToDisplay.x;
            y = eventToDisplay.y;

            labelEventID.Text = id.ToString("X4");
            labelCoordinates.Text = x.ToString("X2") + ", " + y.ToString("X2");

            for (int i = 0; i < eventToDisplay.addresses.Count; i ++)
            {
                listViewPreviews.Items.Add(eventToDisplay.addresses[i].ToString("X6"));

                String bytes = "";
                foreach (Byte item in eventToDisplay.bytes[i]) { bytes += item.ToString("X2") + " "; }
                listViewPreviews.Items[i].SubItems.Add(bytes);
                listViewPreviews.Items[i].SubItems.Add(getDescription(eventToDisplay.addresses[i], eventToDisplay.bytes[i]));
            }
        }



        private String getDescription(long address, List<Byte> bytes)
        {
            if (address > 0xD80000)
            {
                return getSimpleEventDescription(address, bytes);
            }
            else
            {
                return "    " + getExtendedEventDescription(address, bytes);
            }
        }



        private String getSimpleEventDescription(long address, List<Byte> bytes)
        {
            String output = "";

            //Manage simple events
            switch (bytes[0])
            {
                case 0xF6:
                    output = "????";
                    break;
                case 0xF7:
                    output = "????";
                    break;
                case 0xF8:
                    output = "????";
                    break;
                case 0xF9:
                    output = "????";
                    break;
                case 0xFA:
                    output = "????";
                    break;
                case 0xFB:
                    output = "If Event Flag 1" + bytes[1].ToString("X2") + " is set, ignore next Extended Event";
                    break;
                case 0xFC:
                    output = "If Event Flag 1" + bytes[1].ToString("X2") + " is clear, ignore next Extended Event";
                    break;
                case 0xFD:
                    output = "If Event Flag 0" + bytes[1].ToString("X2") + " is set, ignore next Extended Event";
                    break;
                case 0xFE:
                    output = "If Event Flag 0" + bytes[1].ToString("X2") + " is clear, ignore next Extended Event";
                    break;
                case 0xFF:
                    output = "[CALL EXTENDED EVENT " + (bytes[1] + bytes[2] * 0x0100).ToString("X4") + "]";
                    break;
                default:
                    output = "????";
                    break;
            }

            return output;
        }



        private String getExtendedEventDescription(long address, List<Byte> bytes)
        {
            String output = "";

            // Manage extended events
            if (bytes[0] >= 0x10 && bytes[0] <= 0x6F) { return "Player pose " + (bytes[0] - 0x10).ToString("X2"); }

            if (bytes[0] >= 0x70 && bytes[0] <= 0x7F) { return "Timing? " + (bytes[0] - 0x70).ToString("X2"); }

            if (bytes[0] >= 0x80 && bytes[0] <= 0x9F)
            {
                return "Sprite " + (bytes[0] - 0x80).ToString("X2") + " do Event " + bytes[1].ToString("X2");
            }

            // HACKME, there are a lot of unknown Event functions...
            switch (bytes[0])
            {
                case 0x00:
                    output = "Player Hold";
                    break;
                case 0x01:
                    output = "Player Move Up";
                    break;
                case 0x02:
                    output = "Player Move Right";
                    break;
                case 0x03:
                    output = "Player Move Down";
                    break;
                case 0x04:
                    output = "Player Move Left";
                    break;
                case 0x05:
                    output = "(Player Bounce)";
                    break;
                case 0x06:
                    output = "????";
                    break;
                case 0x07:
                    output = "????";
                    break;
                case 0x08:
                    output = "????";
                    break;
                case 0x09:
                    output = "Player Show";
                    break;
                case 0x0A:
                    output = "Player Hide";
                    break;
                case 0x0B:
                    output = "????";
                    break;
                case 0x0C:
                    output = "????";
                    break;
                case 0x0D:
                    output = "????";
                    break;
                case 0x0E:
                    output = "????";
                    break;
                case 0x0F:
                    output = "????";
                    break;
                case 0xA0:
                    output = "Message " + bytes[1].ToString("X2");
                    break;
                case 0xA1:
                    output = "Run Shop " + bytes[1].ToString("X2");
                    break;
                case 0xA2:
                    output = "Set Event Flag 0" + bytes[1].ToString("X2");
                    break;
                case 0xA3:
                    output = "Clear Event Flag 0" + bytes[1].ToString("X2");
                    break;
                case 0xA4:
                    output = "Set Event Flag 1" + bytes[1].ToString("X2");
                    break;
                case 0xA5:
                    output = "Clear Event Flag 1" + bytes[1].ToString("X2");
                    break;
                case 0xA6:
                    output = "Set Flag " + bytes[1].ToString("X2");
                    break;
                case 0xA7:
                    output = "Clear Flag " + bytes[1].ToString("X2");
                    break;
                case 0xA8:
                    output = "Adjust Character HP " + bytes[1].ToString("X2");
                    break;
                case 0xA9:
                    output = "Adjust Character MP " + bytes[1].ToString("X2");
                    break;
                case 0xAA:
                    output = "Add Item " + bytes[1].ToString("X2");
                    break;
                case 0xAB:
                    output = "Remove Item " + bytes[1].ToString("X2");
                    break;
                case 0xAC:
                    output = "Add Magic " + bytes[1].ToString("X2");
                    break;
                case 0xAD:
                    output = "Run Inn " + bytes[1].ToString("X2");
                    break;
                case 0xAE:
                    output = "Blur Screen " + bytes[1].ToString("X2");
                    break;
                case 0xAF:
                    output = "Add GP " + bytes[1].ToString("X2");
                    break;
                case 0xB0:
                    output = "Subtract GP " + bytes[1].ToString("X2");
                    break;
                case 0xB1:
                    output = "Set Player Sprite " + bytes[1].ToString("X2");
                    break;
                case 0xB2:
                    output = "Pause " + bytes[1].ToString("X2") + " cycles";
                    break;
                case 0xB3:
                    output = "Pause  " + bytes[1].ToString("X2") + "0 Cycles";
                    break;
                case 0xB4:
                    output = "Play Background Music " + bytes[1].ToString("X2");
                    break;
                case 0xB5:
                    output = "Play Sound Effect " + bytes[1].ToString("X2");
                    break;
                case 0xB6:
                    output = "Play Movie " + bytes[1].ToString("X2");
                    break;
                case 0xB7:
                    output = "Add/Remove Character (";
                    output += (((bytes[1] & 0xF0) >> 4) == 0) ? "Add " : "Remove ";
                    output += ((bytes[1] & 0x0F) >> 0).ToString("X1") + ")";
                    break;
                case 0xB8:
                    output = "Toggle Additive Tint " + bytes[1].ToString("X2");
                    break;
                case 0xB9:
                    output = "Toggle Subtractive Tint " + bytes[1].ToString("X2");
                    break;
                case 0xBA:
                    output = "Clear Character " + bytes[1].ToString("X2") + " Status 0 " + bytes[2].ToString("X2");
                    break;
                case 0xBB:
                    output = "Set Character " + bytes[1].ToString("X2") + " Status 0 " + bytes[2].ToString("X2");
                    break;
                case 0xBC:
                    output = "Toggle Character " + bytes[1].ToString("X2") + " Status 0 " + bytes[2].ToString("X2");
                    break;
                case 0xBD:
                    output = "Event Battle " + bytes[1].ToString("X2");
                    break;
                case 0xBE:
                    output = "Rumble Effect (";
                    output += ((bytes[1] & 0xF0) >> 4).ToString("X1") + ", ";
                    output += ((bytes[1] & 0x0F) >> 0).ToString("X1") + ")";
                    break;
                case 0xBF:
                    output = "Sprite Effect " + bytes[1].ToString("X2");
                    break;
                case 0xC0:
                    output = "Circle Mask " + bytes[1].ToString("X2");
                    break;
                case 0xC1:
                    output = "???? " + bytes[1].ToString("X2");
                    break;
                case 0xC2:
                    output = "Map " + bytes[1].ToString("X2");
                    break;
                case 0xC3:
                    output = "Fade In Speed " + bytes[1].ToString("X2");
                    break;
                case 0xC4:
                    output = "Fade Out Speed " + bytes[1].ToString("X2");
                    break;
                case 0xC5:
                    output = "????";
                    break;
                case 0xC6:
                    output = "Job " + bytes[1].ToString("X2");
                    break;
                case 0xC7:
                    output = "Next " + bytes[1].ToString("X2") + " bytes simultaneously";
                    break;
                case 0xC8:
                    output = "Display Message " + (bytes[1] + bytes[2] * 0x0100).ToString("X4");
                    break;
                case 0xC9:
                    output = "???? (" + bytes[1].ToString("X2") + " " + bytes[2].ToString("X2") + ")";
                    break;
                case 0xCA:
                    output = "(Set Flag 2/3/4/5xx) (" + bytes[1].ToString("X2") + " " + bytes[2].ToString("X2") + ")";
                    break;
                case 0xCB:
                    output = "(Clear Flag 2/3/4/5xx) (" + bytes[1].ToString("X2") + " " + bytes[2].ToString("X2") + ")";
                    break;
                case 0xCC:
                    output = "(No Function)";
                    break;
                case 0xCD:
                    output = "Run Event Index " + (bytes[1] + bytes[2] * 0x0100).ToString("X4");
                    break;
                case 0xCE:
                    output = "Play Next " + bytes[2].ToString("X2") + " Bytes " + bytes[1].ToString("X2") + " Times";
                    break;
                case 0xCF:
                    output = "Play Next " + bytes[2].ToString("X2") + " Bytes Simultaneously " + bytes[1].ToString("X2") + " Times";
                    break;
                case 0xD0:
                    output = "Music " + (bytes[1] + bytes[2] * 0x0100).ToString("X4");
                    break;
                case 0xD1:
                    output = "Timer? (" + bytes[1].ToString("X2") + " " + bytes[2].ToString("X2") + " " + bytes[3].ToString("X2") + ")";
                    break;
                case 0xD2:
                    output = "Map (" + bytes[1].ToString("X2") + " " + bytes[2].ToString("X2") + " " + bytes[3].ToString("X2") + " " + bytes[4].ToString("X2") + ")";
                    break;
                case 0xD3:
                    output = "Sprite " + bytes[1].ToString("X1") + " Set Map Position " + bytes[2].ToString("X2") + "," + bytes[3].ToString("X2");
                    break;
                case 0xD4:
                    output = "Music (" + bytes[1].ToString("X2") + " " + bytes[2].ToString("X2") + " " + bytes[3].ToString("X2") + ")";
                    break;
                case 0xD5:
                    output = "Sound (" + bytes[1].ToString("X2") + " " + bytes[2].ToString("X2") + " " + bytes[3].ToString("X2") + ")";
                    break;
                case 0xD6:
                    output = "Map (" + bytes[1].ToString("X2") + " " + bytes[2].ToString("X2") + " " + bytes[3].ToString("X2") + ")";
                    break;
                case 0xD7:
                    output = "Timer? (" + bytes[1].ToString("X2") + " " + bytes[2].ToString("X2") + " " + bytes[3].ToString("X2") + ")";
                    break;
                case 0xD8:
                    output = "????";
                    break;
                case 0xD9:
                    output = "????";
                    break;
                case 0xDA:
                    output = "????";
                    break;
                case 0xDB:
                    output = "Restore player status";
                    break;
                case 0xDC:
                    output = "????";
                    break;
                case 0xDD:
                    output = "????";
                    break;
                case 0xDE:
                    output = "(No Function)";
                    break;
                case 0xDF:
                    output = "(No Function)";
                    break;
                case 0xE0:
                    output = "????";
                    break;
                case 0xE1:
                    output = "(Return From Cutscene?)";
                    break;
                case 0xE2:
                    output = "????";
                    break;
                case 0xE3:
                    output = "(Inter-Map Cutscene?)";
                    break;
                case 0xE4:
                    output = "????";
                    break;
                case 0xE5:
                    output = "????";
                    break;
                case 0xE6:
                    output = "????";
                    break;
                case 0xE7:
                    output = "????";
                    break;
                case 0xE8:
                    output = "????";
                    break;
                case 0xE9:
                    output = "????";
                    break;
                case 0xEA:
                    output = "????";
                    break;
                case 0xEB:
                    output = "????";
                    break;
                case 0xEC:
                    output = "(No Function)";
                    break;
                case 0xED:
                    output = "(No Function)";
                    break;
                case 0xEE:
                    output = "(No Function)";
                    break;
                case 0xEF:
                    output = "(No Function)";
                    break;
                case 0xF0:
                    output = "????";
                    break;
                case 0xF1:
                    output = "????";
                    break;
                case 0xF2:
                    output = "(No Function)";
                    break;
                case 0xF3:
                    output = "Set map tiles (";
                    output += bytes[1].ToString("X2") + ", " + bytes[2].ToString("X2") + ") ";
                    output += (((bytes[3] & 0xF0) >> 4) + 1).ToString("X1") + " rows, ";
                    output += (((bytes[3] & 0x0F) >> 0) + 1).ToString("X1") + " columns";
                    break;
                case 0xF4:
                    output = "????";
                    break;
                case 0xF5:
                    output = "(No Function)";
                    break;
                case 0xF6:
                    output = "(No Function)";
                    break;
                case 0xF7:
                    output = "(No Function)";
                    break;
                case 0xF8:
                    output = "(No Function)";
                    break;
                case 0xF9:
                    output = "(No Function)";
                    break;
                case 0xFA:
                    output = "(No Function)";
                    break;
                case 0xFB:
                    output = "(No Function)";
                    break;
                case 0xFC:
                    output = "(No Function)";
                    break;
                case 0xFD:
                    output = "(No Function)";
                    break;
                case 0xFE:
                    output = "(No Function)";
                    break;
                case 0xFF:
                    output = "[END EXTENDED EVENT]";
                    break;
                default:
                    break;
            }

            return output;
        }



        private void buttonCopy_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = listViewPreviews.SelectedItems;

            if (selectedItems.Count == 0)
            {
                foreach (ListViewItem item in listViewPreviews.Items)
                    item.Selected = true;
                selectedItems = listViewPreviews.SelectedItems;
            }

            
            String text = "";
            foreach (ListViewItem item in selectedItems)
            {
                text += item.SubItems[0].Text + "\t";
                text += item.SubItems[1].Text + "\t";
                text += item.SubItems[2].Text;
                text += "\r\n";
            }
            if (text == "") text = "<Empty>";

            Clipboard.SetText(text);
        }



    }
}
