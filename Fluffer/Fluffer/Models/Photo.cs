using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Fluffer.Models
{
    public class Photo
    {
        [PrimaryKey, AutoIncrement]
        public int PhotolId { get; set; }

        [NotNull]
        public string Url { get; set; }

        [ForeignKey(typeof(Animal))]
        public int AnimalId { get; set; }
    }
}
