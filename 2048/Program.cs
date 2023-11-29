using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace _2048
{
    internal class Program
    {
        //Génération des variables
        static Random rndgrid = new Random();
        static Random rnd = new Random();
        const int size = 4;
        static bool move;  //Bool pour vérifier si le tableau a bougé

        //Fonction principale du 2048
        static void Main(string[] args)
        {
            
            int score = 0;
            int[,] grid = new int[size, size];

            //Initialisation du tableau de base
            for (int i = 0; i < 2; i++)
            {
                addNumber();
            }
            ShowScreen();
            Console.WriteLine("\nUtiliser les flèches directionelles pour bouger les nombres, [C] pour quiter");

            //Boucle du jeu à chaque touche pressée
            while (true) 
            {
                move = false;
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                ConsoleKey key = keyInfo.Key;
                moved(key);
                if (move) addNumber();
                ShowScreen();
            }


            Console.ReadLine();



            //----------------------------------------------------------------//
            //                     Fonctions pour le 2048                     //
            //----------------------------------------------------------------//



            //Fonction d'affichage de la grille
            void ShowScreen()
            {
                Console.Clear();
                //Afficher le score
                Console.WriteLine("Score :  {0}\n", score);

                // Afficher la grille
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Color(grid[i, j]);
                        Console.Write(grid[i, j] + "\t");
                        Console.ResetColor();
                    }
                    Console.WriteLine("\n"); // Passer à la ligne pour la prochaine rangée
                }
                
            }


            //Fonction de génération des chiffres
            void addNumber()
            {
                int nbrow = rndgrid.Next(0, 4);
                int nbcol = rndgrid.Next(0, 4);

                int pourcent = rnd.Next(0, 100);

                if (grid[nbrow, nbcol] == 0)
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
                else addNumber();
            }


            //Fonction de vérification de la touche enfoncée
            void moved(ConsoleKey key)
            {
                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        moveUp();
                        break;

                    case ConsoleKey.DownArrow:
                        moveDown();
                        break;

                    case ConsoleKey.LeftArrow:
                        moveLeft();
                        break;

                    case ConsoleKey.RightArrow:
                        moveRight();
                        break;

                    case ConsoleKey.C:
                        Environment.Exit(0);
                        break;

                    default:
                        break;

                }
            }

            //Déplacement lors de la touche UP
            void moveUp()
            {
                for (int j = 0; j < size; j++)
                {
                    for (int i = 1; i < size; i++)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            if (grid[k - 1, j] == 0)
                            {
                                grid[k - 1, j] = grid[k, j];
                                grid[k, j] = 0;
                                move = true;
                            }
                        }
                    }
                }
            }

            //Déplacement lors de la touche DOWN
            void moveDown()
            {
                for (int j = 0; j < size; j++)
                {
                    for (int i = size - 2; i >= 0; i--)
                    {
                        for (int k = i; k < size - 1; k++)
                        {
                            if (grid[k + 1, j] == 0)
                            {
                                grid[k + 1, j] = grid[k, j];
                                grid[k, j] = 0;
                                move = true;
                            }
                        }
                    }
                }
            }

            //Déplacement lors de la touche LEFT
            void moveLeft()
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 1; j < size; j++)
                    {
                        for (int k = j; k > 0; k--)
                        {
                            if (grid[i, k - 1] == 0)
                            {
                                grid[i, k - 1] = grid[i, k];
                                grid[i, k] = 0;
                                move = true;
                            }
                        }
                    }
                }
            }

            //Déplacement lors de la touche RIGHT
            void moveRight()
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = size - 2; j >= 0; j--)
                    {
                        for (int k = j; k < size - 1; k++)
                        {
                            if (grid[i, k + 1] == 0)
                            {
                                grid[i, k + 1] = grid[i, k];
                                grid[i, k] = 0;
                                move = true;
                            }
                        }
                    }
                }
            }

        }
    }
}
