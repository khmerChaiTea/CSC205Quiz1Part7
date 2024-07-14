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
            int width = 5; // Width of each tree
            int height = 3; // Height of each tree
            int numTrees = 5; // Number of trees to repeat

            // Loop for each tree
            for (int tree = 0; tree < numTrees; tree++)
            {
                // Loop for each row of the tree
                for (int i = height; i >= 1; i--)
                {
                    // Print spaces before asterisks to center the tree
                    for (int j = 0; j < (width - (2 * i - 1)) / 2; j++)
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
