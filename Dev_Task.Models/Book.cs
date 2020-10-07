using System;
using System.ComponentModel.DataAnnotations;

namespace Dev_Task.Models
{
    public class Book 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Type ReaderType { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int NumberOfPages { get; set; }
        public string Description { get; set; }
    }
    public enum Type
    {
        Children, Adults
    }
}
