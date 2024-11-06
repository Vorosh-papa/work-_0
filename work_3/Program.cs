using System.Xml.Linq;

namespace Work_3
{
    class Book
    {
        private string _title;
        private string _author;
        private int _pages;

        public string Title
        {
            get { return _title; }
        }

        public Book(string Title, string Auther, int Pages)
        {
            _title = Title;
            _author = Auther;
            _pages = Pages;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Название - {_title}, Автор - {_author}, Количесвово страниц - {_pages}");
        }
    }
    class Library
    {
        List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void ShowBooks()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.Write($"{i + 1}. ");
                books[i].GetInfo();
            }
        }

        public void FindBook(string title)
        {
            bool found = true;

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    books[i].GetInfo();
                    found = false;
                }
            }
            if (found)
            {
                Console.WriteLine("Книги с данным названием не найдено");
            }

        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Мост в Терабитию", "Патерсон Кэтрин", 160);
            Book book2 = new Book("Таинственный сад", "Бернетт Фрэнсис", 256);
            Book book3 = new Book("Океан вне закона", "Иэн Урбина", 776);

            Library library = new Library();

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.ShowBooks();

            library.FindBook(Console.ReadLine());
        }
    }

}