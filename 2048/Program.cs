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
            int[,] grille = new int[row, col];
            
            FillGrid();
            ShowScreen();

            Console.ReadKey();

          

            //Fonction de remplissage de la grille
            void FillGrid()
            {
                // Remplir la grille avec des valeurs
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        grille[i, j] = 0;
                    }
                }
            }


            //Fonction d'affichage de la grille
            void ShowScreen()
            {
                //Afficher le score
                Console.WriteLine("Score :  {0}\n", AddScore(add));

                // Afficher la grille
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        Console.Write(grille[i, j] + "\t");
                    }
                    Console.WriteLine(); // Passer à la ligne pour la prochaine rangée
                }
            }


            //Fonction de calcul du score
            int AddScore(int addScore)
            {
                score += addScore;
                return score;
            }


        }
    }
}
