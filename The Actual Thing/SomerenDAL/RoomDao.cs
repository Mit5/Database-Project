﻿using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class RoomDao : BaseDao
    {
        public List<Room> GetAllRooms()
        {
            string query = "SELECT room_number, capacity, room_type FROM Rooms";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Room> ReadTables(DataTable dataTable)
        {
            List<Room> rooms = new List<Room>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Room room = new Room()
                {
                    Number = (int)dr["room_number"],
                    Capacity = (int)dr["capacity"],
                    Type = ((int)dr["room_type"] == 0) ? false : true
                };
                rooms.Add(room);
            }
            return rooms;
        }
    }
}
