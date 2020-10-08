using Dev_Task.Models;
using System.Collections.Generic;

namespace Dev_Task.DAL
{
    public interface IRepo<T>
    {
        void Add(T item);
        void Delete(int id);
        List<Book> GetAll();
    }
}
