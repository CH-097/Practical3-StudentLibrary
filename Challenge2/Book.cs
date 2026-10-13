using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Challenge2
{
    class Book
    {
        private string author;
        private string title;
        private string genre;
        private int isbn;
        private int year;
        private string publisher;

        // static, class variable belongs to class itself, not object
        private static int bookCount = 0;



        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public int ISBN
        {
            get { return isbn; }
            private set { isbn = value; }  // only class itself can set this, assigned only once for each book
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public static int BookCount
        {
            get { return bookCount; }
        }


        // default constructor, takes no parameters. Sets fields to following default values
        public Book()
        {
            isbn = ++bookCount;
            title = "Default Title";
            author = "Default Author";
            genre = "Default Genre";
            year = 2026;
            publisher = "Default Publisher";
        }


        // custom constructor (parameterised). Set the book’s ISBN with the class variable and increment the variable
        public Book(string title, string author, string genre, int year, string publisher)
        {
            this.isbn = ++bookCount;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.year = year;
            this.publisher = publisher;
        }




        // method to display book details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"Book ID: {ISBN}, Title: {Title}, Author: {Author}, Genre: {Genre}, Year: {Year}, Publisher: {Publisher}");
        }


    }
}

