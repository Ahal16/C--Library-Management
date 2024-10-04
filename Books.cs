using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MachineTest
{
    /*internal class Books
    {
    }*/
    public class Books : IBooks
    {
        private Dictionary<int, Book> library = new Dictionary<int, Book>();

        public void AddBooks()
        {
            try
            {
                Console.WriteLine("Enter Book ID:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Book Name:");
                string name = Console.ReadLine();

                if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                {
                    Console.WriteLine("Invalid Book Name");
                    return;
                }

                Console.WriteLine("Enter Book Category:");
                string category = Console.ReadLine();

                if (!Regex.IsMatch(category, @"^[a-zA-Z\s]+$"))
                {
                    Console.WriteLine("Invalid Book category");
                    return;
                }

                Book newBook = new Book(id, name, category);
                library.Add(id, newBook);

                Console.WriteLine("Book added successfully!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format...Please enter a valid number for ID.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("A book with the same ID already exists.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred {ex.Message}");
            }
        }

        public void GetDetails()
        {
            try
            {
                Console.WriteLine("Enter Book ID to retrieve details:");
                int id = Convert.ToInt32(Console.ReadLine());

                if (library.ContainsKey(id))
                {
                    Book book = library[id];
                    Console.WriteLine($"Book ID: {book.BookID}, Name: {book.BookName}, Category: {book.BookCategory}");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format...Please enter a valid number for ID.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
        public void ViewLibrary()
        {
            if (library.Count > 0)
            {
                Console.WriteLine("Library list:");
                foreach (var book in library.Values)
                {
                    Console.WriteLine($"Book ID: {book.BookID}, Name: {book.BookName}, Category: {book.BookCategory}");
                }
            }
            else
            {
                Console.WriteLine("The library is empty.");
            }
        }
        public void DeleteBook()
        {
            try
            {
                Console.WriteLine("Enter Book ID to delete:");
                int id = Convert.ToInt32(Console.ReadLine());

                if (library.ContainsKey(id))
                {
                    library.Remove(id);
                    Console.WriteLine("Book deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input format...Please enter a valid number for ID.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
