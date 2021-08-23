using System;

namespace Lesson8_19_08_2021
{
    class Program
    {
        class Rectangle
        {
            double side1, side2;
            public Rectangle(double side1, double side2)
            {
                this.side1 = side1;
                this.side2 = side2;
            }
            public double AreaCalculator()
            {
                return side1 * side2;
            }
            public double PerimeterCalculator()
            {
                return 2 * (side1 + side2);
            }
            double Area { get; }
            double Perimeter { get; }
        }
        class Title
        {
            string title;
            public Title(string title) => this.title = title;
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write($"Названия книга: {title}");
                Console.WriteLine();
            }
        }
        class Author
        {
            string author;
            public Author(string author) => this.author = author;
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Имени автора: {author}");

            }
        }
        class Content
        {
            string content;
            public Content(string content) => this.content = content;
            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Содержания: {content}");
                Console.ResetColor();
            }
        }
        class Book
        {

            public Title title { get; }
            public Author author { get; }
            public Content content { get; }
            public Book(string title, string authot, string content)
            {
                this.title = new Title(title);
                this.author = new Author(authot);
                this.content = new Content(content);
            }
            public void Show()
            {
                title.Show();
                author.Show();
                content.Show();
            }
        }


        static void Main(string[] args)
        {
            {
                //Дз2
                Rectangle rt = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                Console.WriteLine($"Плошадь прямоугольника: {rt.AreaCalculator()}");
                Console.WriteLine($"Периметр прямоугольника : {rt.PerimeterCalculator()}");
            }
            {
                // Дз3
                Book b = new Book(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                b.Show();


            }
        }
    }
}
