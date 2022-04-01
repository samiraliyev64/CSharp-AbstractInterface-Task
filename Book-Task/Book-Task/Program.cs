using Book_Task.Models;
using System;

namespace Book_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ededi daxil edin : ");
            int say = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Book[] book = new Book[say];
            
            for (int i = 0; i < book.Length; i++)
            {
                book[i] = new Book();
                Console.Write($"{i+1}.kitabin nomresi : ");
                book[i].No = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{i+1}.kitabin adi : ");
                book[i].Name = Console.ReadLine();
                Console.Write($"{i+1}.kitabin qiymeti : ");
                book[i].Price = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{i+1}.kitabin sayi : ");
                book[i].Count = Convert.ToInt32(Console.ReadLine());
                Console.Write($"{i+1}.kitabin janri : ");
                book[i].Genre = Console.ReadLine();
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n1. Kitablari qiymete gore filterle\n2. Butun kitablari goster\n0. Proqrami bagla\n");

            Console.Write("Muvafiq ededi daxil edin : ");
            int say1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            bool check = true;
            bool yoxlamaq = false;
            Book[] reserveBook = { };

            while (check)
            {
                int currentIndex = -1;
                Book[] newbook = new Book[book.Length+currentIndex];
                
                
                if (say1 == 1)
                {
                    Console.Write("Minimum Price : ");
                    int minPrice = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Maximum Price : ");
                    int maxPrice = Convert.ToInt32(Console.ReadLine());
 
                    for (int h = 0; h < book.Length; h++)
                    {
                        reserveBook = book;
                        if (book[h].Price >= minPrice && book[h].Price <= maxPrice)
                        {
                            currentIndex++;
                            newbook[currentIndex] = book[h];
                            yoxlamaq = true;
                        }
                        
                        else { continue; }
                    }

                    say1 = 33;
                    book = newbook;

                    Console.WriteLine("\nFilter olunmus kitablar : \n");
                    for (int i = 0; i < book.Length; i++)
                    {
                        
                        Console.WriteLine($"{i + 1}.kitabin nomresi : {book[i].No}");
                        Console.WriteLine($"{i + 1}.kitabin adi : {book[i].Name}");
                        Console.WriteLine($"{i + 1}.kitabin qiymeti : {book[i].Price}");
                        Console.WriteLine($"{i + 1}.kitabin sayi : {book[i].Count}");
                        Console.WriteLine($"{i + 1}.kitabin janri : {book[i].Genre}\n");
                    }
                }

                else if (say1 == 2)
                {
                   
                    for (int j = 0; j < book.Length; j++)
                    {
                        
                        Console.WriteLine($"{j+1}.kitabin nomresi : {book[j].No}");
                        Console.WriteLine($"{j+1}.kitabin adi : {book[j].Name}");
                        Console.WriteLine($"{j+1}.kitabin qiymeti : {book[j].Price}");
                        Console.WriteLine($"{j+1}.kitabin sayi : {book[j].Count}");
                        Console.WriteLine($"{j+1}.kitabin janri : {book[j].Genre}\n");
                        
                    }
                    say1 = 33; //Random bir edede beraber edirem ki, for loopuna tekrar tekrar girmesin.
                    Console.WriteLine("\n1. Kitablari qiymete gore filterle\n2. Butun kitablari goster\n0. Proqrami bagla\n");
                }

                else if (say1 == 0)
                {
                    Console.WriteLine("Program stopped");
                    break;
                }

                else
                {
                    
                    Console.Write("Muvafiq ededi daxil edin : ");
                    say1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
