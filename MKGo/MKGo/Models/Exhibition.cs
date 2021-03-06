﻿using SQLite;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKGo
{
    public class Exhibition
    {
        public Exhibition() { }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [OneToMany]
        public List<Room> Rooms { get; set; }
    }
}
