using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IBooks library = new Books();
            bool running = true;

            while(running)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Get Book Details");
                Console.WriteLine("3. View Library List");
                Console.WriteLine("4. Delete Book");
                Console.WriteLine("5. Exit");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            library.AddBooks();
                            break;
                        case 2:
                            library.GetDetails();
                            break;
                        case 3:
                            library.ViewLibrary();
                            break;
                        case 4:
                            library.DeleteBook();
                            break;
                        case 5:
                            running = false;
                            Console.WriteLine("Exiting the program");
                            break;
                        default:
                            Console.WriteLine("Invalid choice...Please enter 1, 2, 3, 4 or 5.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format...Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}

