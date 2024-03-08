using Hotel;
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Resenva[] vect = new Resenva[10];

            Console.Write("How many rooms will be rented? ");
            int rented = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 1; i < rented + 1; i++)
            {
                Console.WriteLine("Rent #" + i + ":");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Resenva(name, email, room);
                Console.WriteLine();
            }

            Console.WriteLine("Busy rooms: ");
            

            for (int i = 0; i < vect.Length; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(vect[i].Room + ": " + vect[i].Name + ", " + vect[i].Email);
                }
            }
        }
    }
}