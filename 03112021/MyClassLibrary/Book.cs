using System;
using System.Collections.Generic;
using System.Text;

namespace MyClassLibrary
{
    public class Book
    {
        protected internal int No;
        public string Name;
        private protected double Price;
    }

    public class ProgrammingBook : Book
    {
        public bool HasCd;

        public ProgrammingBook(int no)
        {
            this.No = no;
        }
    }

    public class Store
    {
        public Book[] Books;
        public Store()
        {
            Book book1 = new Book();
            book1.No = 2;
            Books = new Book[]
            {
                new Book
                {
                    Name = "test1",
                    No = 1,
                },
                book1
            };
        }
    }
}
