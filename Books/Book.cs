using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_07_06_operators_overloading
{
    internal class Book
    {
        private string _name;
        private string _author;
        private string _releaseDate;

        public string Name { get { return _name; } set { _name = value; } }
        public string Author { get { return _author; } set { _author = value; } }
        public string Date { get { return _releaseDate; } set { _releaseDate = value; } }

        public Book(string name, string author, string releaseDate)
        {
            _name = name;
            _author = author;
            _releaseDate = releaseDate;
        }

        public override string ToString()
        {
            return $"Name: {_name}, Author: {_author}, release date: {_releaseDate}";
        }
    }

    internal class BookList
    {
        private List<Book> _books;

        public BookList()
        {
            _books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            _books.Remove(book);
        }

        public void Clear()
        {
            _books.Clear();
        }

        public bool Contains(Book book)
        {
            return _books.Contains(book);
        }

        public static BookList operator +(BookList obj, Book book)
        {
            obj.AddBook(book);
            return obj;
        }

        public static BookList operator -(BookList obj, Book book)
        {
            obj.RemoveBook(book);
            return obj;
        }

        public static bool operator ==(BookList obj, Book book)
        {
            return obj._books.Contains(book);
        }

        public static bool operator !=(BookList obj, Book book)
        {
            return obj._books.Contains(book);
        }

        public override string ToString()
        {
            string result = "Book List:\n";
            foreach (Book el in _books)
            {
                result += el.ToString() + "\n";
            }
            return result;
        }

        public Book this[int index]
        {
            get
            {
                if(index>=0 && index< _books.Count)
                {
                    return _books[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if(index >= 0 && index < _books.Count)
                {
                    _books[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

    }
}

