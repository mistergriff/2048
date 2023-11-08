using System;

namespace _2048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int row = 4;
            const int col = 4;
            int score = 0;
            int add = 0;
            int[,] grid = new int[row, col];
            //int[,] moveGrid = grid;


            addNumber();
            addNumber();
            ShowScreen();

            while (isFailed() == false) 
            { 

            }


            Console.ReadKey();



            //Fonction d'affichage de la grille
            void ShowScreen()
            {
                Console.Clear();
                //Afficher le score
                Console.WriteLine("Score :  {0}\n", AddScore(add));

                // Afficher la grille
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(grid[i, j] + "\t");
                    }
                    Console.WriteLine("\n"); // Passer à la ligne pour la prochaine rangée
                }
            }


            //Fonction de génération des chiffres
            void addNumber()
            {
                Random rnd = new Random();
                Random rndrow = new Random();
                Random rndcol = new Random();
                int nbrow = rndrow.Next(0, 4);
                int nbcol = rndcol.Next(0, 4);

                int pourcent = rnd.Next(100);

                while (grid[nbrow, nbcol] != 0)
                {
                    nbrow = rndrow.Next(0, 4);
                    nbcol = rndcol.Next(0, 4);
                }

                while (grid[nbrow, nbcol] == 0)
                { 
                    if (pourcent >= 90)
                    {
                        grid[nbrow, nbcol] = 4;
                    }
                    else
                    {
                        grid[nbrow, nbcol] = 2;
                    }
                }
            }


            //Fonction de calcul du score
            int AddScore(int addScore)
            {
                score += addScore;
                return score;
            }


            //Fonction de fail
            bool isFailed()
            {


                return false;
            }


        }
    }
}
