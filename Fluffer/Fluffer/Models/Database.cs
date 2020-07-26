using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;

namespace Fluffer.Models
{
   public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Animal>().Wait();
            _database.CreateTableAsync<User>().Wait();
            _database.CreateTableAsync<UserAnimal>().Wait();
            _database.CreateTableAsync<Photo>().Wait();


            //koty
            #region 

            var animal1 = new Animal
            {
                Name = "Pepe",
                Age = "8",
                AnimalId = 1,
                FirstPhoto = "https://i.ibb.co/4sFNDL9/pepe3.jpg",
                Description = "Pepe lubi bardzo dużo jeść i żebrać."

            };
            var animal2 = new Animal
            {
                Name = "Mozart",
                Age = "8",
                AnimalId = 11,
                FirstPhoto = "https://i.ibb.co/ydFwkfP/mozart1.jpg",
                Description = "Mozart był błękitnym kociakiem."

            };
            var animal3 = new Animal
            {
                Name = "Lara",
                Age = "14",
                AnimalId =7,
                FirstPhoto = "https://i.ibb.co/Bn4T65k/lara3.jpg",
                Description = "Lara to czekoladowy labrador."

            };
            var animal4 = new Animal
            {
                Name = "Vivi i Lulu",
                Age = "3 i 5",
                AnimalId =14,
                FirstPhoto = "https://i.ibb.co/g9X5crT/lulu2.jpg",
                Description = "Vivi jest młodą świnką. Lulu został uratowany, jest starszy od Vivi."

            };
            var animal5 = new Animal
            {
                Name = "Ciciek",
                Age = "9",
                AnimalId =8,
                FirstPhoto = "https://i.ibb.co/Lk7P4xq/IMG-5983.jpg",
                Description = "Ciciek jest kotem rasy Cornish Rex."

            };
            var animal6 = new Animal
            {
                Name = "Misia",
                Age = "4",
                AnimalId =13,
                FirstPhoto = "https://i.ibb.co/MR6QX6P/misia2.jpg",
                Description = "Misia bywa nieobliczalna."

            };
            var animal7 = new Animal
            {
                Name = "Luiza",
                Age = "4",
                AnimalId =6,
                FirstPhoto = "https://i.ibb.co/VS5Dmyj/luiza1.jpg",
                Description = "Luiza lubi polować na przekąski."

            };
            var animal8 = new Animal
            {
                Name = "Roki",
                Age = "6",
                AnimalId =2,
                FirstPhoto = "https://i.ibb.co/71F4C5S/roki1.jpg",
                Description = "Roki to przepiękny psiak średniej wielkości. Spokojny i łagodny. W pierwszym kontakcie nieśmiały, ale stęskniony kontaktu z człowiekiem."

            };
            var animal9 = new Animal
            {
                Name = "Rudy",
                Age = "5",
                AnimalId =3,
                FirstPhoto = "https://i.ibb.co/XptBPmJ/rudy1.jpg",
                Description = "Rudy jest bardzo dużym śpiochem."

            };
            var animal10 = new Animal
            {
                Name = "Frodo",
                Age = "5",
                AnimalId = 4,
                FirstPhoto = "https://i.ibb.co/d485hMH/frodo1.jpg",
                Description = "Frodo jest grzecznym owczarkiem. Wymaga długich spacerów i miłości."

            };
            var animal11 = new Animal
            {
                Name = "Puszek",
                Age = "7",
                AnimalId = 5,
                FirstPhoto = "https://i.ibb.co/pPM1M2R/puszek.jpg",
                Description = "Puszek jest grubaskiem. Lubi jeść i psocić."

            };
            var animal12 = new Animal
            {
                Name = "Włóczykij",
                Age = "7",
                AnimalId = 17,
                FirstPhoto = "https://i.ibb.co/G5n0n7y/wloczykij1.jpg",
                Description = "Włóczykij jest drobnym kundelkiem. Lubi podróżować."

            };
            var animal13 = new Animal
            {
                Name = "Staś",
                Age = "8",
                AnimalId = 12,
                FirstPhoto = "https://i.ibb.co/q9xhGsW/stas.jpg",
                Description = "Staś z połamanymi nogami czeka na jeszcze jedną operację."

            };
            var animal14 = new Animal
            {
                Name = "Harry",
                Age = "10",
                AnimalId =16,
                FirstPhoto = "https://i.ibb.co/j8t42kR/harry.jpg",
                Description = "Harry jest pogodnym huskym. Ma różne kolory oczu, co nadaje mu wyjątkowości."

            };
            var animal15 = new Animal
            {
                Name = "Rysiek",
                Age = "5",
                AnimalId = 9,
                FirstPhoto = "https://i.ibb.co/3kDBxwz/rysiek1.jpg",
                Description = "Rysiek jest cudownym rudym kotem. Jego hobby to wygrzewanie się w słońcu."

            };
            var animal16 = new Animal
            {
                Name = "JoJo",
                Age = "1",
                AnimalId = 10,
                FirstPhoto = "https://i.ibb.co/hDKc98g/jojo1.jpg",
                Description = "JoJo jest szczeniaczkiem, który szuka przytulnego domu i miłości."

            };
            var animal17 = new Animal
            {
                Name = "Szlagier",
                Age = "1",
                AnimalId =15,
                FirstPhoto = "https://i.ibb.co/1Xd0dBY/szlagier.jpg",
                Description = "Szlagier ma dopiero 6 miesięcy i poszukuje domu z dużą iloscią marchewki."

            };


            #endregion // 

            //uzytkownicy
            #region
            var user1 = new User
            {
                Login = "MojaNazwa72",
                Password = "Haslo",
                PhotoStr = @"https://i.ibb.co/7KPDbXL/2.jpg"
            };
            var user2 = new User
            {
                Login = "Krzys27",
                Password = "olsah",
                PhotoStr = @"https://i.ibb.co/7KPDbXL/2.jpg"
            };
            #endregion

            //zdjecia
            #region
            var photo1 = new Photo
            {
                Url = @"https://i.ibb.co/j3NzGpH/pepe2.jpg",
                AnimalId = 1
            };
            var photo2 = new Photo
            {
                Url = @"https://i.ibb.co/Gk3L8v1/pepe1.jpg",
                AnimalId = 1
            };
            var photo3 = new Photo
            {
                Url = @"https://i.ibb.co/YyDwxmQ/pepe4.jpg",
                AnimalId = 1
            };
            var photo4 = new Photo
            {
                Url = @"https://i.ibb.co/8PspKNh/mozart.jpg",
                AnimalId = 11
            };
            var photo5 = new Photo
            {
                Url = @"https://i.ibb.co/LvSRKh1/lara1-1.jpg",
                AnimalId = 7
            };
            var photo6 = new Photo
            {
                Url = @"https://i.ibb.co/7KNFVWJ/lara2.jpg",
                AnimalId = 7
            };
            var photo7 = new Photo
            {
                Url = @"https://i.ibb.co/vwQYKH6/lulu1.jpg",
                AnimalId = 14
            };
            var photo8 = new Photo
            {
                Url = @"https://i.ibb.co/gF68zNv/lulu3.jpg",
                AnimalId = 14
            };
            var photo9 = new Photo
            {
                Url = @"https://i.ibb.co/g9cvjq2/misia1.jpg",
                AnimalId = 13
            };
            var photo10 = new Photo
            {
                Url = @"https://i.ibb.co/Q681XGF/luiza2.jpg",
                AnimalId = 6
            };
            var photo11 = new Photo
            {
                Url = @"https://i.ibb.co/PTFZpXP/luiza3.jpg",
                AnimalId = 6
            };
            var photo12 = new Photo
            {
                Url = @"https://i.ibb.co/z8Ktp8t/luiza4.jpg",
                AnimalId = 6
            };
            var photo13 = new Photo
            {
                Url = "https://i.ibb.co/GJZ4m7j/roki2.jpg",
                AnimalId = 2
            };
            var photo14 = new Photo
            {
                Url = "https://i.ibb.co/9Wzhy7B/roki3.jpg",
                AnimalId = 2
            };
            var photo15 = new Photo
            {
                Url = "https://i.ibb.co/0X9kGZw/rudy.jpg",
                AnimalId = 3
            };
            var photo16 = new Photo
            {
                Url = "https://i.ibb.co/kSKdJdf/frodo2.jpg",
                AnimalId = 4
            };
            var photo17 = new Photo
            {
                Url = "https://i.ibb.co/pPM1M2R/puszek.jpg",
                AnimalId = 5
            };
            var photo18 = new Photo
            {
                Url = "https://i.ibb.co/kSKdJdf/frodo2.jpg",
                AnimalId = 4
            };
            var photo19 = new Photo
            {
                Url = "https://i.ibb.co/G5n0n7y/wloczykij1.jpg",
                AnimalId = 17
            };
            var photo20 = new Photo
            {
                Url = "https://i.ibb.co/2c23PqJ/stas1.jpg",
                AnimalId = 12
            };
            var photo21 = new Photo
            {
                Url = "https://i.ibb.co/yfXV7nK/harry1.jpg",
                AnimalId = 16
            };
            var photo22 = new Photo
            {
                Url = "https://i.ibb.co/jGRgF5N/harry2.jpg",
                AnimalId = 16
            };
            var photo23 = new Photo
            {
                Url = "https://i.ibb.co/drRRbLM/rysiek2.jpg",
                AnimalId = 9
            };
            var photo24 = new Photo
            {
                Url = "https://i.ibb.co/47WqBSd/jojo.jpg",
                AnimalId = 10
            };
            var photo25 = new Photo
            {
                Url = "https://i.ibb.co/CVZStmv/jojo2.jpg",
                AnimalId = 10
            };

            #endregion

            //UserAnimal
            #region
            var useranimal1 = new UserAnimal
            {
                AnimalId = 5,
                UserId = 2
            };
            #endregion

            //inserty
            #region

            _database.InsertAsync(animal1);
            _database.InsertAsync(animal2);
            _database.InsertAsync(animal3);
            _database.InsertAsync(animal4);
            _database.InsertAsync(animal5);
            _database.InsertAsync(animal6);
            _database.InsertAsync(animal7);
            _database.InsertAsync(animal8);
            _database.InsertAsync(animal9);
            _database.InsertAsync(animal10);
            _database.InsertAsync(animal11);
            _database.InsertAsync(animal12);
            _database.InsertAsync(animal13);
            _database.InsertAsync(animal14);
            _database.InsertAsync(animal15);
            _database.InsertAsync(animal16);
            _database.InsertAsync(animal17);

            //==============================//
            _database.InsertAsync(user1);
            _database.InsertAsync(user2);
            //==============================//
            _database.InsertAsync(photo1);
            _database.InsertAsync(photo2);
            _database.InsertAsync(photo3);
            _database.InsertAsync(photo4);
            _database.InsertAsync(photo5);
            _database.InsertAsync(photo6);
            _database.InsertAsync(photo7);
            _database.InsertAsync(photo8);
            _database.InsertAsync(photo9);
            _database.InsertAsync(photo10);
            _database.InsertAsync(photo11);
            _database.InsertAsync(photo12);
            _database.InsertAsync(photo13);
            _database.InsertAsync(photo14);
            _database.InsertAsync(photo15);
            _database.InsertAsync(photo16);
            _database.InsertAsync(photo17);
            _database.InsertAsync(photo18);
            _database.InsertAsync(photo19);
            _database.InsertAsync(photo20);
            _database.InsertAsync(photo21);
            _database.InsertAsync(photo22);
            _database.InsertAsync(photo23);
            _database.InsertAsync(photo24);
            _database.InsertAsync(photo25);
            //=============================//
            _database.InsertAsync(useranimal1);


            #endregion

            //listy
            #region
            user1.Animals = new List<Animal> { animal1, animal10, animal11 };
            animal1.Photos = new List<Photo> { photo1 };
            animal2.Photos = new List<Photo> { photo2 };
            animal3.Photos = new List<Photo> { photo3 };
            animal4.Photos = new List<Photo> { photo4 };
            animal5.Photos = new List<Photo> { photo5 };
            animal6.Photos = new List<Photo> { photo6 };
            animal7.Photos = new List<Photo> { photo7 };
            animal8.Photos = new List<Photo> { photo8 };
            animal9.Photos = new List<Photo> { photo9 };
            animal10.Photos = new List<Photo> { photo10 };
            animal11.Photos = new List<Photo> { photo11, photo12, photo13, photo14 };
            animal12.Photos = new List<Photo> { photo15, photo16};
            #endregion

            //updaty

            #region
            _database.UpdateAsync(user1);
            _database.UpdateAsync(animal1);
            _database.UpdateAsync(animal2);
            _database.UpdateAsync(animal3);
            _database.UpdateAsync(animal4);
            _database.UpdateAsync(animal5);
            _database.UpdateAsync(animal6);
            _database.UpdateAsync(animal7);
            _database.UpdateAsync(animal8);
            _database.UpdateAsync(animal9);
            _database.UpdateAsync(animal10);
            _database.UpdateAsync(animal11);
            _database.UpdateAsync(animal12);
            #endregion

            var animalStored = _database.GetAsync<Animal>(animal11.AnimalId);



        }

        public static User LoggedUser;
        public static Image zdj;
        public static int obecneId;

        //__________________________________________________
        public Task<List<Animal>> GetAnimalAsync()
        {
            return _database.Table<Animal>().ToListAsync();
        }

        public Task<int> SaveAnimalAsync(Animal animal)
        {

            return _database.InsertAsync(animal);
        }
        public Task<int> DeleteAnimalAsync(Animal animal)
        {

            return _database.DeleteAsync(animal);
        }
        //____________________________________________________________
        public Task<List<User>> GetUserAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<int> UpdateUserAsync(User user)
        {
            return _database.UpdateAsync(user);
        }

        public Task<int> SaveUserAsync(User user)
        {

            return _database.InsertAsync(user);
        }
        public Task<int> DeleteUserAsync(User user)
        {

            return _database.DeleteAsync(user);
        }

        //___________________________________________________

        public Task<List<UserAnimal>> GetUserAnimalAsync()
        {
            return _database.Table<UserAnimal>().ToListAsync();
        }

        public Task<int> SaveUserAnimalAsync(UserAnimal userAnimal)
        {

            return _database.InsertAsync(userAnimal);
        }
        public Task<int> DeleteUserAnimalAsync(UserAnimal userAnimal)
        {

            return _database.DeleteAsync(userAnimal);
        }

        //_________________________________________________________

        public Task<List<Photo>> GetPhotoAsync()
        {
           
            return _database.Table<Photo>().ToListAsync();
        }

        public Task<int> SavePhotoAsync(Photo photo)
        {
            
            return _database.InsertAsync(photo);
        }
        public Task<int> DeletePhotoAsync(Photo photo)
        {

            return _database.DeleteAsync(photo);
        }

    }
}
