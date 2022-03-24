using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SomerenModel;
using SomerenLogic;

namespace SomerenUI
{
    public partial class RoomsForm : Form
    {
        public RoomsForm()
        {
            InitializeComponent();
            DisplayRooms();
        }

        private void DisplayRooms()
        {
            // show rooms
            pnlRooms.Dock = DockStyle.Fill;
            pnlRooms.Show();

            // fill the rooms listview within the students panel with a list of rooms
            RoomService roomService = new RoomService();
            List<Room> roomList = roomService.GetRooms(); ;

            // clear the listview before filling it again
            listViewRooms.Items.Clear();

            foreach (Room r in roomList)
            {
                string[] items = { r.Number.ToString(), r.Capacity.ToString(), (r.Type) ? "Teacher" : "Student" };
                ListViewItem li = new ListViewItem(items);
                listViewRooms.Items.Add(li);
            }
        }
    }
}
