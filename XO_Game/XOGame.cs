using System;
using System.Collections.Generic;
using System.Text;

namespace XO_Game
{
    class XOGame
    {
        public static int n = 3;
        private int countX;
        private int countO;
        public char[,] Table = new char[n, n];

        // adding X in Table
        public void addX(int i,int j) {
            Table[i,j] = 'x';
        }
        // adding O in Table
        public void addO(int i,int j) {
            Table[i, j] = 'o';
        }


        public string CheckTable() {
            //horizontal check
            { 
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // x check
                    if (Table[i,j] == 'x') {
                        countX++;
                        if (countX == 3) {
                            return "Win X";
                        }
                    }

                    // o check
                    if (Table[i,j] == 'o') {
                        countO++;
                        if (countO == 3) {
                            return "Win O";
                        }
                    }
                }
                
                countX = 0;
                countO = 0;
            }
            }
            //vertical check
            { 
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    // x check
                    if (Table[i,j] == 'x') {
                        countX++;
                        if (countX == 3) {
                            return "Win X";
                        }
                    }
                    // o check
                    if (Table[i, j] == 'o')
                    {
                        countO++;
                        if (countO == 3)
                        {
                            return "Win O";
                        }
                    }
                }

                countX = 0;
                countO = 0;
            }
            }
            //diagonal check (\)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        // (\) diagonal
                        if (i == j)
                        {
                            // x check
                            if (Table[i, j] == 'x')
                            {
                                countX++;
                                if (countX == 3)
                                {
                                    return "Win X";
                                }
                            }

                            // o check
                            if (Table[i, j] == 'o')
                            {
                                countO++;
                                if (countO == 3)
                                {
                                    return "Win O";
                                }
                            }
                        }
                    }
                }
                countX = 0;
                countO = 0;
            }

            //diagonal check (/)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        // (/) diagonal
                        if ((i + j) == n - 1)
                        {
                            // x check
                            if (Table[i, j] == 'x')
                            {
                                countX++;
                                if (countX == 3)
                                {
                                    return "Win X";
                                }
                            }

                            // o check
                            if (Table[i, j] == 'o')
                            {
                                countO++;
                                if (countO == 3)
                                {
                                    return "Win O";
                                }
                            }
                        }
                    }
                }
                countX = 0;
                countO = 0;

            }

            return null;
        }

        public void PrintDesign() {
            Console.WriteLine($"  1 2 3 ");
            Console.WriteLine($"1|{Table[0, 0]}|{Table[0, 1]}|{Table[0, 2]}|");
            Console.WriteLine($" |-----|");
            Console.WriteLine($"2|{Table[1, 0]}|{Table[1, 1]}|{Table[1, 2]}|");
            Console.WriteLine($" |-----|");
            Console.WriteLine($"3|{Table[2, 0]}|{Table[2, 1]}|{Table[2, 2]}|");
        }

    }
}
