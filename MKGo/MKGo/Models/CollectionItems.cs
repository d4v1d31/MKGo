﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKGo
{
    public class CollectionItems
    {
        private SQLiteConnection database;
        public CollectionItems(Database db)
        {
            database = db.GetConnection();
        }
    }
}
