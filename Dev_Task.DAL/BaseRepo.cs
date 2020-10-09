using Dev_Task.Models;
using System;
using System.Collections.Generic;

namespace Dev_Task.DAL
{
    public class BaseRepo<T> : IRepo<T> where T : Book
    {
        public void Add(T item)
        {
            MyDataInitializer.books.Add(item);
        }

        public void Delete(int id)
        {
            Book rem = MyDataInitializer.books.Find(x => x.Id == id);
            MyDataInitializer.books.Remove(rem);
        }

        public virtual List<Book> GetAll() => MyDataInitializer.books;

    }
}
