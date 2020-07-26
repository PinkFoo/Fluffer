using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace Fluffer.Models
{
    public class UserAnimal
    {
        [ForeignKey(typeof(Animal))]
        public int AnimalId { get; set; }


        [ForeignKey(typeof(User))]
        public int UserId { get; set; }

    }
}
