using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ways to Declare Arrays";


            // In this example we create an Array with 10 spots in it to be filled at a later time
            // The Array called newArray can no longer switch sizes, it is set statically at 10 spaces. 
            // If we want to change the sizes we can create a new Array. 
            int[] newArray = new int[10];



            // The array below is missing the new and int keywords because int was declared earlier and the complier is able to 
            // inference what the type of data in the array is due to them all being the same size. 
            int[] newArray2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            //Indexing Arrays is accomplished by referencing the index number of the element we are trying to call
            string[] myPlaylist = {"Carried Away - Goosetaf", "Jacaranda - LoFi Coffee", "3rd Times the Charm - Soho", "Waterfalls - Molly McPhaul", "Singapore - Danny Lover",
            "Paul Scholes - Black Josh","Joanna - Floeme", "Wartemarke - Flatpocket", "Hikari - Nujabes", "Drawn - Ramsey", "Yanima - El Buho", "Alice - The Cancel"};



            /// <summary>
            /// A code to Shuffle music in an array called myPlaylist
            /// </summary>
            Random random = new Random();
            foreach (string song in myPlaylist)
            {
                int shuffle = random.Next(0, myPlaylist.Length);
                Console.WriteLine(myPlaylist[shuffle]);
            }


            Console.WriteLine();
            Console.WriteLine();

            // The Arrays that we have been using so far have been Single Dimension Arrays. If we want to store data in a tabular for we will need to use
            // Multi-Dimensional Arrays. 

            // Creating a MultiDimensional Array

            // A single Comma in the square brackets symbolyzes that it is a 2D array. A 3D array would have [,,]           
            int[,] numbers = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);          // Prints all the numbers in a straight line not a table. 
                                                    // This method is for looping through a 1D array.

            }

            // To loop through a multi-dimensional array we need a for loop for each one of the array's dimensions. Nested? 


           // Console.WriteLine();

            int[,] newNumbers = { { 1, 3, 5, 7 }, { 2, 4, 6, 8 } };
            for (int i = 0; i < newNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < newNumbers.GetLength(1); j++)
                {

                   Console.WriteLine(newNumbers[i, j]);

                }

            }


            Console.WriteLine();
            Console.WriteLine();


            int[] arrayNumbers = { 2, 5, 7 };

            int[] reversedArray = arrayNumbers; 

            Array.Reverse(reversedArray);
            for (int i = 0; i < reversedArray.GetLength(0); i++)
                Console.WriteLine(reversedArray[i]);

            Console.ReadKey();
        }
    }
}