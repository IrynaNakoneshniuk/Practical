using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace H_W._21._07._22
{
    internal class ListOfBook
    {
        private  List<Book> ListBook;
        public ListOfBook()
        {
            ListBook = new List<Book>();
        }
        public Book this[int index]
        {
            get
            {
                if(index > 0 || index <= ListBook.Count)
                {
                    return ListBook[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                ListBook[index] = value;

            }
        }
        public static ListOfBook operator +(ListOfBook list, Book book)
        {
            list.ListBook.Add(book);
            return list;
        }
        public static ListOfBook operator -(ListOfBook list, Book book)
        {
            list.ListBook.Remove(book);
            return list;
        }
        public bool IsExist(string ?NameOfBook )
        {
            Book book = new Book();

            if (book == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                foreach (Book b in ListBook)
                {
                    if (b.Title == NameOfBook)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void PrintList()
        {
            int count = 1;
            if (this.ListBook.Count == 0)
            {

                Console.WriteLine("\t\t\tList is empty!");
            }
            else
            {
                foreach (Book book in this.ListBook)
                {
                    Console.Write(count);
                    Console.WriteLine(book.ToString());
                    count++;
                }
            }
        }
        public int Length()
        {
            return this.ListBook.Count;
        }
    }
    internal class Book
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string ? Author { get; set; }
        public int ? Id { get; set; }
        public Book(string? title, string? description, string? author, int? id)
        {
            Title = title;
            Description = description;
            Author = author;
            Id = id;
        }
        public Book()
        {
            Title = null;
            Description = null;
            Author = null;
            Id = null;
        }
        public override string ToString()
        {
            return $"Title : {this.Title}, Author: {this.Author}, Description: {this.Description}, Id: {this.Id}";
        }
        public Book CreateBook()
        {
            string? Title = null;
            string ? Description = null;
            string ? Author = null;
            int ? Id = null;
            WriteLine("Enter discription of book: ") ;
            Description=ReadLine();
            WriteLine("Enter author of book: ");
            Author =ReadLine();
            WriteLine("Enter title of book: ");
            Title =ReadLine();
            WriteLine("Enter id of book: ");
            Id =Convert.ToInt32(ReadLine()); 
            return new Book(Title, Description, Author, Id);    
        }
    }
}
