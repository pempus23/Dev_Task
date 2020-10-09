using Dev_Task.Models;
using System.Collections.Generic;

namespace Dev_Task.DAL
{
    internal class MyDataInitializer
    {
        static public List<Book> books = new List<Book>
        {
           new Book {
               Id = 1,
               Name = "The Great Gatsby",
               ReaderType = Type.Adults,
               Author = "F. Scott Fitzgerald",
               Genre = "The novel",
               NumberOfPages = 235,
               Description = "Following the shock and chaos of World War I, American society enjoyed unprecedented levels of prosperity during the 'roaring' 1920s as the economy soared. "
           },
           new Book {
               Id = 2,
               Name = "The Odyssey",
               ReaderType = Type.Children,
               Author = "Homer",
               Genre = "Epic poems",
               NumberOfPages = 80,
               Description = " It is, in part, a sequel to the Iliad, the other work traditionally ascribed to Homer."
           },
        };
    }
}
