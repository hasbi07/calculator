using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Title = "aplikasi kalkulator";
                Console.WriteLine("\npilih menu calculator");
                Console.Write("\n1.penambahan");
                Console.Write("\n2.pengurangan");
                Console.Write("\n3.perkalian");
                Console.Write("\n4.pembagian");
                Console.Write("\n\ninputkan nomer menu [1..4]: ");
                int pilihan = int.Parse(Console.In.ReadLine());

            if (pilihan > 4 || pilihan < 1)
            {
                Console.WriteLine("maaf, kode yang anda masukkan tidak tersedia");
            }
            else if (pilihan > 0 || pilihan < 5)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("inputkan nilai b = ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();


                   if (pilihan == 1)
                    {
                        Console.WriteLine("hasil penambahan {0} + {1} = {2}", a, b, Penambahan(a, b));
                        
                    }
                    else if (pilihan == 2)
                    { 
                        Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
                        
                    }
                    else if (pilihan == 3)
                    {
                        Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
                       
                    }
                    else if (pilihan == 4)
                    {
                        Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
                       
                    }
                }
                Console.WriteLine("\nTekan sembarang key untuk keluar");
                Console.ReadKey();
            }
            static int Penambahan(int a, int b)
            {
                return a + b;
            }
            static int Pengurangan(int a, int b)
            {
                return a - b;
            }
            static int Perkalian(int a, int b)
            {
                return a * b;
            }
            static int Pembagian(int a, int b)
            {
                return a / b;
            }
        }
    }