using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Fluffer.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int UserId { get; set; }

        [MaxLength(50), NotNull, Unique]
        public string Login { get; set; }
        
        [MaxLength(100), NotNull]
        public string Password { get; set; }
      
//public Stream PhotoStr { get; set; }
          public string PhotoStr { get; set; }

        [ManyToMany(typeof(UserAnimal))]
        public List<Animal> Animals { get; set; }

    }
}
