namespace Identify_Path_With_Smallest_Sum
{
    public class Program
    {
        private static int[,]? inputArray;
        private static int[][]? pathArray = new int[3][];

        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter single numbers with single space between:");
            //string? inputs = Console.ReadLine();

            //if (string.IsNullOrEmpty(inputs))
            //{
            //    Console.WriteLine("No input provided.");
            //    return;
            //}

            //string[] inputArray = inputs.Split(' ');

            int[,] inputArray = new int[3, 3]
            {
                {1, 3, 9},
                {2, 5, 5},
                {7, 4, 1}
            };

            int row = 3, col = 3;
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine(inputArray[i, 0]);

                for (int j = 1; j <= col; j++)
                {
                    TraversePath(i, j);
                    //Console.WriteLine(inputArray[i, i]);
                }
            }

            Console.Read();
        }

        private static void TraversePath(int row, int col)
        {
            pathArray[pathArray.Length] = new int[3];
            pathArray[pathArray.Length][0] = 1;
            pathArray[pathArray.Length][1] = 2;
            pathArray[pathArray.Length][2] = 4;
            Console.WriteLine(pathArray[pathArray.Length][0] + pathArray[pathArray.Length][1] + pathArray[pathArray.Length][2]);
        }
    }
}
