
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
namespace firstStep
{
    internal class Program
    {
        static void Main(string[] Arguments)

        {

            #region Question 1
            //Book book = new Book();
            //Console.WriteLine(book.password);

            //What happens: Compilation Error.
            // Why "password" is a private field in the Book class so it cannot be accessed out side 

            #endregion

            #region Question 2

            //Book book = new Book();

            //Console.WriteLine(book.copiesInStock);

            // why => because varible copiesInStock work with internal and the means of attaining that


            #endregion

            #region Question 3
            //Book book = new Book();

            //Console.WriteLine(book.title);



            #endregion

            #region Question 4


            //Book book = new Book();


            //book.BookGenre = Genre.Science;
            //Console.WriteLine(book.BookGenre);



            #endregion

            #region Question 5 


            //Book book = new Book();


            //book.BookGenre = Genre.Science;
            //book.BookGenre = Genre.fiction;
            //book.BookGenre = Genre.NonFiction;
            //int x = (int)Genre.Science;
            //int y = (int)Genre.NonFiction;
            //int z = (int)Genre.fiction;
            //Console.WriteLine(x + y + z);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);


            #endregion

            #region Question 6

            //Book book = new Book();

            //int genreNumber = 1;
            //Genre myGenre = (Genre)genreNumber;
            //Console.WriteLine(myGenre);

            #endregion

            #region Question 7

            //Genre genre = Genre.Fiction;

            //Console.WriteLine(Convert.ToString(genre));

            //Console.WriteLine("toString => " + genre);

            #endregion

            #region Question 8 

            //string genreText = "Science";

            //Genre parasedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(genreText);

            #endregion

            #region Question 9

            //string generalText = "MyStery";

            //bool isSuccess = Enum.TryParse<Genre>(generalText, out Genre result);

            //if (isSuccess)
            //{
            //    Console.WriteLine("Success" + result);
            //}
            //else
            //{
            //    Console.WriteLine("invalid");
            //}


            #endregion

        }


    }

    internal enum Genre
    {

        Fiction, NonFiction, Science
    }
    internal class Book
    {
        public string title = "test";
        public Genre BookGenre;
    }
}


