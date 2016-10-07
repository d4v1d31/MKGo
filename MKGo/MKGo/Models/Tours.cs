﻿using SQLite;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using SQLiteNetExtensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MKGo
{
    public class Tour : IModel
    {
        public Tour() { }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        [ForeignKey(typeof(Exhibition))]
        public int ExhibitionId { get; set; }

        [OneToOne]
        public Exhibition Exhibition { get; set; }

        [ManyToMany(typeof(TourItem))]
        public List<Item> Items { get; set; }

    }

    public class TourItem
    {
        [ForeignKey(typeof(Tour))]
        public int TourId { get; set; }

        [ForeignKey(typeof(Item))]
        public int ItemId { get; set; }
    }

    public class Tours : AbstractModel<Tour> {

        public Tour GetItemWithChildren(int itemId)
        {

            return database.GetWithChildren<Tour>(itemId);
        }
    }
}
