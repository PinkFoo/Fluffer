using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace Fluffer.Models
{
    public class Animal
    {
        [PrimaryKey]
        public int AnimalId { get; set; }

        [MaxLength(50), NotNull]
        public string Name { get; set; }

        [ NotNull]
       public DateTime BirthDate { get; set; }
        public string Age { get; set; }

        [MaxLength(420), NotNull]
        public string Description { get; set; }

        public string FirstPhoto { get; set; }

        [ManyToMany(typeof(UserAnimal))]
        public List<User> Users { get; set; }

        [OneToMany]
        public List<Photo> Photos { get; set; }


    }
}
