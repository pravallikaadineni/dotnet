﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep13library
{
    [Serializable]
    public class User
    {
        public int moviesBorrowed = 0;
        public enum UserLevel
        {
            Silver = 2,
            Gold = 3,
            Platinum = 5
        }
        public List<Movie> BorrowedMovies;
        public User()
        {
            //this.userLevel = (int)UserLevel.Silver;
            BorrowedMovies = new List<Movie>();

        }
          public User(string UserName, string Password, string UserLevel1)
        {
            if (UserLevel1 == "Silver")
            {
                this.userLevel = (int)UserLevel.Silver;
            }
            if (UserLevel1 == "Gold")
            {
                this.userLevel = (int)UserLevel.Gold;
            }
            if (UserLevel1 == "Platinum")
            {
                this.userLevel = (int)UserLevel.Platinum;
            }
            this.UserName = UserName;
            this.Password = Password;
        }
        private int _UserLevel;

        public int userLevel
        {
            get { return _UserLevel; }
            set { _UserLevel = value; }
        }
        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public void AddUser(string UserName, string Password, string UserLevel1)
        {
            if (UserLevel1 == "Silver")
            {
                this.userLevel = (int)UserLevel.Silver;
            }
            if (UserLevel1 == "Gold")
            {
                this.userLevel = (int)UserLevel.Gold;
            }
            if (UserLevel1 == "Platinum")
            {
                this.userLevel = (int)UserLevel.Platinum;
            }
            this.UserName = UserName;
            this.Password = Password;
        }
        public void BorrowMovie(Movie m)
        {
            if (m.Availability > 0)
            {
                if (this.moviesBorrowed <= this.userLevel)
                {
                    m.Availability--;
                    this.moviesBorrowed++;
                    BorrowedMovies.Add(m);
                }
                else
                {
                    Console.WriteLine("User Can't Borrow Anymore Movies");
                }
            }
            else
            {
                Console.WriteLine("This Movies isn't Availabale");
            }
        }
        public void RetrunMovie(Movie m, int days)
        {
            if (this.BorrowedMovies.Contains(m))
            {

                m.Availability++;
                this.moviesBorrowed--;
                BorrowedMovies.Remove(m);
                double totalCost = days * m.Cost;
                Console.WriteLine($"You Need to Pay {totalCost}");
            }
            else
            {
                Console.WriteLine($"You didn't Borrow {m.MovieName} movie..");
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }

        public void SearchByLanguage(string language)
        {
            foreach (var item in Movie.MoviesList)
            {
                if (item.Language == language)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
                }
            }
        }
        public void SearchByGenre(string genre)
        {
            foreach (var item in Movie.MoviesList)
            {
                if (item.genres == genre)
                {
                    Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
                }
            }
        }
        public void ShowMyList()
        {
            foreach (var item in this.BorrowedMovies)
            {
                Console.WriteLine($"Movie Name : {item.MovieName}  Language : {item.Language} Genere : {item.genres}");
            }
        }

    }
}
   

