using Delegate_Predicate.Models;

namespace Delegate_Predicate
{
    internal class BookDelegate
    {
        public delegate bool CheckAuthor(List<Book> books);

        public void CountOfBooks(List<Book> books, Predicate<Book> predicate)
        {
            int count = 0;
            foreach (Book book in books)
            {
                if (predicate(book))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }

        public void Result()
        {
            List<Book> books = new List<Book>()
            {
              new Book() {Author = "Mark Twain", Name = "Martin Iden"},
              new Book() {Author = "Lev Tolstoy", Name = "War and Peace"},
              new Book() {Author = "Orhan Pamuk", Name = "Kar Taneleri"},
              new Book() {Author = "Erich Remark", Name = "3 friends"},
              new Book() {Author = "Mark Twain", Name = "Iron Fist"}
            };
            CountOfBooks(books, books => books.Author == "Mark Twain");
        }
    }
}
