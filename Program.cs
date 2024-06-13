namespace hw_07_06_operators_overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Завдання 1
            //В одному з попередніх практичних завдань ви створювали клас «Журнал». Додайте до вже створеного класу
            //інформацію про кількість працівників.Виконайте навантаження +(для збільшення кількості працівників на вказану кількість), — (для зменшення кількості працівників
            //на вказану кількість), == (перевірка на рівність кількості
            //працівників), < і > (перевірка на меншу чи більшу кількість працівників), != і Equals.Використовуйте механізм
            //властивостей полів класу.

            Journal journ1 = new Journal("name1","desc1",20);
            Journal journ2 = new Journal("name2","desc2",24);
            Console.WriteLine(journ1);
            journ1 -= 1;
            journ1 += 5;
            Console.WriteLine(journ1);
            Console.WriteLine(journ1 == journ2);
            Console.WriteLine(journ1 < journ2);
            Console.WriteLine(journ1 > journ2);
            Console.WriteLine(journ1.Equals(journ2));

            //            Завдання 2
            //В одному з попередніх практичних завдань ви створювали клас «Магазин». Додайте до вже створеного класу
            //інформацію про площу магазину.Виконайте навантаження +(для збільшення площі магазину на вказаний
            //розмір), — (для зменшення площі магазину на вказаний
            //розмір), == (перевірка на рівність площ магазинів), < і >
            //(перевірка магазинів менших або більших за площею),
            //!= і Equals.Використовуйте механізм властивостей
            //полів класу.

            Store st1 = new Store("myStore", 55.5);
            Store st2 = new Store("NewStore", 45.5);
            Store st3 = new Store("Store3", 55.5);
            Console.WriteLine(st1);
            st1 += 5.5;
            st1 -= 5.5;

            Console.WriteLine(st1>st2);
            Console.WriteLine(st1<st2);
            Console.WriteLine(st1==st3);
            Console.WriteLine(st1.Equals(st3));

            //            Завдання 3
            //Створіть додаток «Список книг до прочитання». Додаток
            //має дозволяти додавати книги до списку, видаляти книги
            //зі списку, перевіряти чи є книга у списку, і т.д.Використовуйте механізм властивостей, навантаження операторів,
            //індексаторів. 

            Book book1 = new Book("FirstBook", "FirstAuthor", "1,1,1111");
            Book book2 = new Book("SecondBook", "SecondAuthor", "2,2,2222");
            Book book3 = new Book("ThirdBook", "ThirdAuthor", "1,1,1111");
            BookList bookList = new BookList();
            bookList.AddBook(book1);
            bookList+=(book2);
            bookList.AddBook(book3);
            Console.WriteLine(bookList);
            Console.WriteLine(bookList.Contains(book1));

            Console.WriteLine(bookList[2]);

            //Console.WriteLine(bookList);
        }
    }
}
