using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linckedlist_and_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();//create a new linkedlist of type int
            while(true)//infinite loop for repeated user input 
            {
                //disply option to the user
                Console.WriteLine("\nChoose an opreation:");
                Console.WriteLine("1.Add element at the beginning");
                Console.WriteLine( "2.Add element at the end ");
                Console.WriteLine("3.Add element at a specific position");
                Console.WriteLine("4.Remove the first element ");
                Console.WriteLine("5.Remove the last element");
                Console.WriteLine("6.Prent the list");
                Console.WriteLine("7.Exit the program");
                Console.Write("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());
            }
        }
    }
}
