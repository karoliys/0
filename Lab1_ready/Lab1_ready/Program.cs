using System;

namespace Lab1_ready
{
    class Players
    {
        private static int[][] polegame = new int[3][];
        private static int hod = 1;
        public static void checkGame() {
            int endGame = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (polegame[i][k] == 0)
                    {
                        endGame++;
                    }
                    
                }
            }
            if (endGame == 0)
            {
                StartResetGame();
            }
            for (int i = 0; i < 3; i++)
            {
                if (polegame[i][0] != 0 && polegame[i][0] == polegame[i][1] && polegame[i][1] == polegame[i][2])
                {
                    Console.Clear();
                    Console.WriteLine("Player " + polegame[i][1] + " Win!");
                    Console.ReadKey();
                    StartResetGame();
                }
                else if (polegame[0][i] != 0 && polegame[0][i] == polegame[1][i] && polegame[1][i] == polegame[2][i])
                {
                    Console.Clear();
                    Console.WriteLine("Player " + polegame[0][i] + " Win!");
                    Console.ReadKey();
                    StartResetGame();
                }
                else if (polegame[0][0] != 0 && polegame[0][0] == polegame[1][1] && polegame[1][1] == polegame[2][2])
                {
                    Console.Clear();
                    Console.WriteLine("Player " + polegame[0][0] + " Win!");
                    Console.ReadKey();
                    StartResetGame();
                }
                else if (polegame[0][2] != 0 && polegame[0][2] == polegame[1][1] && polegame[1][1] == polegame[2][0])
                {
                    Console.Clear();
                    Console.WriteLine("Player " + polegame[0][2] + " Win!");
                    Console.ReadKey();
                    StartResetGame();
                }
            }
            
        }
        private static void setType(int stb, int str)
        {
            if (polegame[stb][str] == 0)
            {
                polegame[stb][str] = hod;
                switch (hod)
                {
                    case 1: hod = 2; break;

                    default:
                        hod = 1;
                        break;
                }
            }

        }
        private static void checkMove(ref int skip) {
            for (int k = 0; k < 3; k++) 
            {
                if (polegame[k][0] == 2 && polegame[k][1] == 2 && polegame[k][2] == 0)// Поиск победы по горизонтали
                {
                    setType(k, 2);
                    skip = 1;
                    break;
                }
                else if (polegame[k][0] == 2 && polegame[k][2] == 2 && polegame[k][1] == 0)
                {
                    setType(k, 1);
                    skip = 1;
                    break;
                }
                else if (polegame[k][1] == 2 && polegame[k][2] == 2 && polegame[k][0] == 0)
                {
                    setType(k, 0);
                    skip = 1;
                    break;
                }
                if (polegame[0][k] == 2 && polegame[1][k] == 2 && polegame[2][k] == 0) // Поиск победы по Вертикали
                {
                    setType(2, k);
                    skip = 1;
                    break;
                }
                else if (polegame[0][k] == 2 && polegame[2][k] == 2 && polegame[1][k] == 0)
                {
                    setType(1, k);
                    skip = 1;
                    break;
                }
                else if (polegame[1][k] == 2 && polegame[2][k] == 2 && polegame[0][k] == 0)
                {
                    setType(0, k);
                    skip = 1;
                    break;
                }
                if (polegame[0+k][0] == 2 && polegame[1][1] == 2 && polegame[2-k][2] == 0) // Поиск победы по Диагонали
                {
                    setType(2-k, 2);
                    skip = 1;
                    break;
                }
                else if (polegame[0 + k][0] == 0 && polegame[1][1] == 2 && polegame[2 - k][2] == 2)
                {
                    setType(0+k, 0);
                    skip = 1;
                    break;
                }
            }
            
           
        }
        private static void checkEnemyMove(ref int skip)
        {
            for (int k = 0; k < 3; k++) 
            {
                if (polegame[k][0] == 1 && polegame[k][1] == 1 && polegame[k][2] == 0)// Поиск Защиты по горизонтали
                {
                    setType(k, 2);
                    skip = 1;
                    break;
                }
                else if (polegame[k][0] == 1 && polegame[k][2] == 1 && polegame[k][1] == 0)
                {
                    setType(k, 1);
                    skip = 1;
                    break;
                }
                else if (polegame[k][1] == 1 && polegame[k][2] == 1 && polegame[k][0] == 0)
                {
                    setType(k, 0);
                    skip = 1;
                    break;
                }
                if (polegame[0][k] == 1 && polegame[1][k] == 1 && polegame[2][k] == 0)// Поиск защиты по Вертикали
                {
                    setType(2, k);
                    skip = 1;
                    break;
                }
                else if (polegame[0][k] == 1 && polegame[2][k] == 1 && polegame[1][k] == 0)
                {
                    setType(1, k);
                    skip = 1;
                    break;
                }
                else if (polegame[1][k] == 1 && polegame[2][k] == 1 && polegame[0][k] == 0)
                {
                    setType(0, k);
                    skip = 1;
                    break;
                }
                if (polegame[0 + k][0] == 1 && polegame[1][1] == 1 && polegame[2 - k][2] == 0) // Поиск защиты по Диагонали
                {
                    setType(2 - k, 2);
                    skip = 1;
                    break;
                }
                else if (polegame[0 + k][0] == 0 && polegame[1][1] == 1 && polegame[2 - k][2] == 1)
                {
                    setType(0 + k, 0);
                    skip = 1;
                    break;
                }
            }
           


        }
        private static void gameBot() {
            int skip = 0;
            checkMove(ref skip);
            
            if (skip == 1)
            {
                skip = 0;
                return;
            }
            checkEnemyMove(ref skip);
            
            if (skip == 1)
            {
                skip = 0;
                return;
                
            }
            
            if (polegame[1][1] == 0)
            {
                setType(1, 1);
                return;
            }
            else if (polegame[1][1] == 1)
            {
                if (polegame[0][2] == 0)
                {
                    setType(0, 2);
                    return;
                }
                else if (polegame[0][0] == 0)
                {
                    setType(0, 0);
                    return;
                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (polegame[i][k] == 0)
                            {
                                setType(i, k);
                                return;
                            }
                        }
                    }
                }

            }
            else
            {
                if ((polegame[0][0] == 1 || polegame[0][2] == 1 || polegame[2][0] == 1 || polegame[2][2] == 1) && polegame[0][1] == 0)
                {
                    setType(0,1);
                    return;
                }
                for (int i = 0; i < 3; i++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (polegame[i][k] == 0)
                        {
                            setType(i,k);
                            return;
                        }
                    }
                }

            }
        }
        public static void StartResetGame()
        {
            hod = 1;
            for (int i = 0; i < 3; i++)
            {
                polegame[i] = new int[3] { 0, 0, 0 };
            }
        }
        public static void move()
        {
            if (hod == 1)
            {


                int endMove = 0;
                do
                {
                    string cellPlayer = Console.ReadLine();
                    if (cellPlayer.Length == 3)
                    {

                        string[] cellPlayer_arr = cellPlayer.Split();
                        int stb = int.Parse(cellPlayer_arr[0]);
                        int str = int.Parse(cellPlayer_arr[1]);
                        setType(stb, str);
                        endMove = 1;


                    }
                    else
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                while (endMove == 0);
            }
            else gameBot();
        }
        public static char playerType(int str, int stb)
        {
            switch (polegame[stb][str])
            {
                case 1: return 'X';
                case 2: return 'O';
                default: return ' ';

            }

        }
        
    }
    class Program
    {
        static void menu() {

            Console.WriteLine("tic tac toe");
            Console.WriteLine("1-Game\n2-Rules");

            string answer = "0";
            answer = Console.ReadLine();
            switch (answer)
            {
                case "2": Console.Clear(); Console.WriteLine("Krestiki Noliti s nepobedimim botom\n Dlya hoda napisat' 2 chisla cherez probel\n Stroky potom Stolbec"); Console.ReadKey(); break;
                default: break;  
            }
        }
        static void pole()
        {
            // Pole
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("     0   1   2");


            for (int Stb = 0; Stb < 3; Stb++)
            {

                Console.Write(Stb + "| |");


                for (int line = 0; line < 3; line++)
                {

                    Console.Write(" " + Players.playerType(line, Stb) + " ");
                    Console.Write("|");

                }

                Console.WriteLine();
            }

        }





        static void Main()
        {
           

            menu();
            Players.StartResetGame();

            while (true)
            {
                pole();
                Players.move();
                Players.checkGame();

            }
            


        }
        
    }
    
}
