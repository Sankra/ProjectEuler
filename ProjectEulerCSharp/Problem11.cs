using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectEulerCSharp
{
    /// <summary>
    /// What is the greatest product of four adjacent numbers 
    /// in any direction (up, down, left, right, or diagonally) 
    /// in the 20x20 grid?
    /// </summary>
    public class Problem11
    {
        private int[][] grid;

        public int FindGreatestProductOfFourAdjacentNumbers()
        {
            ParseGrid();
            var products = new[]
                           {
                               Task<int>.Factory.StartNew(FindGreatestHorizontalProduct),
                               Task<int>.Factory.StartNew(FindGreatestVerticalProduct),
                               Task<int>.Factory.StartNew(FindGreatestDiagonalProductRight),
                               Task<int>.Factory.StartNew(FindGreatestDiagonalProductLeft)
                           };

            return products.Max(task => task.Result);
        }

        private int FindGreatestHorizontalProduct()
        {
            int greatestProduct = -1;
            foreach (int[] t in grid)
            {
                for (int j = 0; j < t.Length - 4; ++j)
                {
                    int product = 1;
                    for (int k = 0; k < 4; ++k)
                    {
                        product = product * t[j + k];
                    }

                    if (product > greatestProduct)
                    {
                        greatestProduct = product;
                    }
                }
            }

            return greatestProduct;
        }

        private int FindGreatestVerticalProduct()
        {
            int greatestProduct = -1;
            for (int i = 0; i < grid.Length - 4; ++i)
            {
                for (int j = 0; j < grid[i].Length - 4; ++j)
                {
                    int product = 1;
                    for (int k = 0; k < 4; ++k)
                    {
                        product = product * grid[j + k][i];
                    }

                    if (product > greatestProduct)
                    {
                        greatestProduct = product;
                    }
                }
            }

            return greatestProduct;
        }

        private int FindGreatestDiagonalProductRight()
        {
            int greatestProduct = -1;
            for (int i = 0; i < grid.Length - 4; ++i)
            {
                for (int j = 0; j < grid[i].Length - 4; ++j)
                {
                    int product = 1;
                    for (int k = 0; k < 4; ++k)
                    {
                        product = product * grid[i + k][j + k];
                    }

                    if (product > greatestProduct)
                    {
                        greatestProduct = product;
                    }
                }
            }

            return greatestProduct;
        }

        private int FindGreatestDiagonalProductLeft()
        {
            int greatestProduct = -1;
            for (int i = 3; i < grid.Length; ++i)
            {
                for (int j = 0; j < grid[i].Length - 4; ++j)
                {
                    int product = 1;
                    for (int k = 0; k < 4; ++k)
                    {
                        product = product * grid[i - k][j + k];
                    }

                    if (product > greatestProduct)
                    {
                        greatestProduct = product;
                    }
                }
            }

            return greatestProduct;
        }

        private void ParseGrid()
        {
            string[] content = File.ReadLines("20x20Grid.txt").ToArray();
            grid = new int[20][];
            Parallel.For(0, content.Length, i =>
            {
                    string[] line = content[i].Split(' ');
                    grid[i] = new int[20];
                    for (int j = 0; j < line.Length; ++j)
                    {
                        grid[i][j] = int.Parse(line[j]);
                    }
            });
        }
    }
}