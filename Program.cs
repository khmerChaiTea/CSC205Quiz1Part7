using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC205Quiz1Part6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = 9; // Width of each tree (adjust as needed)
            int height = 5; // Height of each tree (adjust as needed)
            int numTrees = 3; // Number of trees to repeat

            // Loop for each tree
            for (int tree = 0; tree < numTrees; tree++)
            {
                // Loop for each row of the tree
                for (int i = height; i >= 1; i--)
                {
                    // Calculate the number of leading spaces to center the tree
                    int spacesBefore = (width - (2 * i - 1)) / 2;

                    // Print leading spaces
                    for (int j = 0; j < spacesBefore; j++)
                    {
                        Console.Write(" ");
                    }

                    // Print asterisks for the current row
                    for (int k = 0; k < 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }

                    // Move to the next line after each row
                    Console.WriteLine();
                }
            }
        }
    }
}
