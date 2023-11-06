using System;

namespace _2048
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int row = 4;
            const int col = 4;

            int[,] grille = new int[row, col];

            // Remplir la grille avec des valeurs (pour l'exemple, des nombres aléatoires)
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    grille[i, j] = 0; // Remplacez ceci par votre propre logique de remplissage
                }
            }

            // Afficher la grille
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(grille[i, j] + "\t");
                }
                Console.WriteLine(); // Passer à la ligne pour la prochaine rangée
            }

            Console.ReadKey();
        }

    }
}
