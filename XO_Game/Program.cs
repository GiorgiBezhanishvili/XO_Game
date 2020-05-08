using System;

namespace XO_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAdd = 9;

            XOGame XO = new XOGame();

            bool nextTurn = true;

            do
            {

                XO.PrintDesign();

                if (XO.CheckTable() == null)
                {

                    if (nextTurn == true)
                    {

                    reInsertX:
                        Console.WriteLine("X turn : ");

                        int indexI = Convert.ToInt32(Console.ReadLine()) - 1;
                        int indexJ = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (XO.Table[indexI, indexJ] == 'x' || XO.Table[indexI, indexJ] == 'o')
                        {
                          
                            Console.WriteLine("Enter Valid Coordinates");
                            goto reInsertX;
                        }

                        XO.Table[indexI, indexJ] = 'x';
                        nextTurn = false;
                    }
                    else
                    {
                    reInsertO:
                        Console.WriteLine("O turn : ");

                        int indexI = Convert.ToInt32(Console.ReadLine()) - 1;
                        int indexJ = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (XO.Table[indexI, indexJ] == 'x' || XO.Table[indexI, indexJ] == 'o')
                        {
                      
                            Console.WriteLine("Enter Valid Coordinates");
                            goto reInsertO;
                        }

                        XO.Table[indexI, indexJ] = 'o';
                        nextTurn = true;
                    }
                }
                else
                {
                    if (XO.CheckTable() == "Win X")
                    {
                        Console.WriteLine("Win X");
                    }
                    else
                    {
                        Console.WriteLine(XO.CheckTable());
                    }
                    break;
                }

            } while (maxAdd-- > 0);

        }
    }
}
