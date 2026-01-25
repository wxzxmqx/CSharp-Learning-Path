namespace _04_Arrays {
    class Program
    {
        static void Main(string[] args)
        {
            // declare an array
            int[] values = new int[5]; // not mutable 

            // assign values to the array
            values[0] = 4;
            values[1] = 8;
            values[2] = 12;
            values[3] = 16;
            values[4] = 20;

            Console.WriteLine(values[0]); // 4

            // indexes [0][1][2] [3] [4]
            // content [4][8][12][16][20]
            
            // DECLARING AN ARRAY AND SETTING THE ARRAY ELEMENT VALUES  
            int[] studentMarks = [3, 6, 7, 2, 9, 4, 8, 10, 10, 11, 6, 8];
            Console.WriteLine(studentMarks.Length); // length = 12

            Console.WriteLine(studentMarks[3]); // 2
            Next();
            
            string[] weekdays = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };

            Console.WriteLine("Length: {0}", weekdays.Length);
            

            // foreach loop
            foreach(var weekday in weekdays)
            {
                Console.WriteLine(weekday);
            }

            Next();
            
            int[,] array2DDeclaration = new int[3, 3];
            // [0] [0] [0]
            // [0] [0] [0]
            // [0] [0] [0]

            int[,,] array3DDeclaration = new int[3, 3, 3];

            int[,] array2DInitialized = { 
                { 1,2 }, // row 0
                { 3,4 }, // row 1 
                { 5,6 } // row 2
            };

            Console.WriteLine(array2DInitialized[0,0]); // [0 row 0 column] = 1;
            Console.WriteLine(array2DInitialized[1,0]); // [1 row 0 column] = 3;
            Console.WriteLine(array2DInitialized[2,0]); // [2 row 0 column] = 5;

            string[,] ticTacToeField = new string[3, 3];
            string[] signs = { "x", "o" };
            Random gen = new Random();
            bool winnerFound = false;

            // generating the field with random "x" and "o"
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ticTacToeField[i, j] = signs[gen.Next(signs.Length)];
                }
            }
            
            // generating the field
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {ticTacToeField[i, j]} ");
                    if (j < 2) Console.Write("|");
                }
                Console.WriteLine();
                if (i < 2) Console.WriteLine("---+---+---");
            }
            
            // checking the winner
            for (int i = 0; i < 3; i++)
            {
                if ((ticTacToeField[i, 0] == signs[0] &&
                    ticTacToeField[i, 1] == signs[0] &&
                    ticTacToeField[i, 2] == signs[0]) 
                    || 
                    (ticTacToeField[0, i] == signs[0] &&
                     ticTacToeField[1, i] == signs[0] &&
                    ticTacToeField[2, i] == signs[0]))
                {
                    Console.WriteLine($"Player {signs[0]} wins on row/column {i+1}");
                    winnerFound = true;
                    break;
                } else if (ticTacToeField[i, 0] == signs[1] &&
                           ticTacToeField[i, 1] == signs[1] &&
                           ticTacToeField[i, 2] == signs[1]
                           || 
                           (ticTacToeField[0, i] == signs[1] &&
                            ticTacToeField[1, i] == signs[1] &&
                            ticTacToeField[2, i] == signs[1]))
                {
                    Console.WriteLine($"Player {signs[1]} wins on row/column {i+1}");
                    winnerFound = true;
                    break;
                } 
            }

            // checking the winner on main diagonal
            if (!winnerFound)
            {
                bool mainX = true;
                bool mainO = true;
            
                for (int k = 0; k < 3; k++)
                {
                    if (ticTacToeField[k, k] != signs[0]) mainX = false;
                    if (ticTacToeField[k, k] != signs[1]) mainO = false;
                }
            
                if (mainX) Console.WriteLine($"Player {signs[0]} wins on main diagonal");
                else if (mainO) Console.WriteLine($"Player {signs[1]} wins on main diagonal");
            }
            
            // checking the winner on secondary diagonal
            if (!winnerFound)
            {
                bool secX = true;
                bool secO = true;
                for (int q = 0; q < 3; q++)
                {
                    if (ticTacToeField[q, 2 - q] != signs[0]) secX = false;
                    if (ticTacToeField[q, 2 - q] != signs[1]) secO = false;
                }
            
                if (secX) Console.WriteLine($"Player {signs[0]} wins on secondary diagonal");
                else if (secO) Console.WriteLine($"Player {signs[1]} wins on secondary diagonal");   
            }

            Next();

            string[,,] world = new string[10, 10, 10];
            for (int x = 0; x < 10; x++)
            {
                for (int y = 0; y < 10; y++)
                {
                    for (int z = 0; z < 10; z++)
                    {
                        if (y == 0)
                        {
                            world[x, y, z] = "stone";
                        } else if (y == 1)
                        {
                            world[x, y, z] = "grass";
                        }
                        else
                        {
                            world[x, y, z] = "air";
                        }
                    }
                }
            }

            Next();
            int[,] arr =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += arr[i, j];
                }

                Console.WriteLine(sum);
            } 
        }

        static void Next()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}