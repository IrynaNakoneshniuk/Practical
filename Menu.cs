using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace H_W._21._07._22
{
    internal class Menu
    {
        private ListOfBook? _listOfBook;
        public Menu() { 
            this._listOfBook = new ListOfBook();
        }
        public void MenuItem1()
        {
            Book book = new Book();
            book = book.CreateBook();
            _listOfBook += book;
        }
        public void MenuItem2(){
            Book book = new Book();
            Write("Input number of book for remuving: ");
            int number = Convert.ToInt32(ReadLine());
            if (number > 0 && number <= _listOfBook.Length())
            {
                book = _listOfBook[number - 1];
                _listOfBook = _listOfBook - book;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        public void MenuItem3()
        {
            string? Title = null;
            Write("Input title of book for searching: ");
            Title = ReadLine();
            if (_listOfBook.IsExist(Title))
            {
                Write("Book is existing");
                Thread.Sleep(1000);
            }
            else
            {
                Write("Book is not found");
                Thread.Sleep(1000);
            }
        }
        public void PrintMenu()
        {
            WriteLine("\t\t\tMenu");
            WriteLine("\t\t\t1-Add book");
            WriteLine("\t\t\t2-Remove book");
            WriteLine("\t\t\t3-Сheck if the book exists");
            WriteLine("\t\t\t4-Exit");
        }
        public void  PrintList()
        {
            _listOfBook.PrintList();
        }
    }
}
