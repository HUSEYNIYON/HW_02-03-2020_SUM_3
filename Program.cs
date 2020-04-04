using System;

namespace ConsoleApplication
{
    class Book
    {
        //exrcise 3
        public Book(string t,string a, string c)
        {
            title=new Title(t);
            author=new Author(a);
            content=new Content(c);
        }
        Title title;
        Author author;
        Content content;
        public void Show()
        {
            Console.ForegroundColor=ConsoleColor.Red;
            title.Show();
            Console.ForegroundColor=ConsoleColor.Green;
            author.Show();
            Console.ForegroundColor=ConsoleColor.Blue;
            content.Show();
        }
    }
        class Title
        {
            string title;
            public Title(string t)
            {
                title=t;
            }
            public void Show()
            {
                System.Console.WriteLine(title);
            }
        }
        class Author
        {
            string author;
            public Author(string a)
            {
                author=a;
            }
            public void Show()
            {
                System.Console.WriteLine(author);
            }
        }
        class Content
        {
            string content;
            public Content(string c)
            {
                content=c;
            }
            public void Show()
            {
                System.Console.WriteLine(content);
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Book book=new Book("Vizhual C# 2012","Ziborov","Programming");
            Book book1=new Book("C# Note for Professionals","Gryn Holkins","Programming");
            Book book2=new Book("Visual Studio CookBook 2013","Jeff Martin","Programming");
            book.Show();
            book1.Show();
            book2.Show();
            Console.ReadLine();
        }
    }
}