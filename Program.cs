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
            int height = 7;  // Height of each tree (adjust as needed)
            int numTrees = 3;  // Number of trees to repeat

            // Loop for each tree
            for (int tree = 0; tree < numTrees; tree++)
            {
                // Calculate the width based on the current height
                int width = 2 * height - 1;

                // Loop for each row of the tree
                for (int i = 0; i < height; i++)
                {
                    // Calculate the number of leading spaces to center the tree
                    int spacesBefore = height - i - 1;

                    // Print leading spaces
                    for (int j = 0; j < spacesBefore; j++)
                    {
                        Console.Write(" ");
                    }

                    // Print asterisks for the current row
                    for (int k = 0; k < 2 * i + 1; k++)
                    {
                        Console.Write("*");
                    }

                    // Move to the next line after each row
                    Console.WriteLine();
                }

                // Ensure separation between trees
                if (tree < numTrees - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
