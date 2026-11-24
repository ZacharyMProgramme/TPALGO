using System.Reflection.Metadata;

namespace RPG
{
    internal class Program
    {
        public static int[,] grille2D = new int[10, 10];
        public static int strength = 5;
        public static int speed = 5;
        public static int pv = 100;
        public static int defense = 5;
        public static int accuracy = 5;
        public static string username = "";
        public static void DemandeUsername()
        {
            Console.WriteLine("Veuillez saisir votre username : ");
            username = Console.ReadLine();
        }
        

        public static void AfficherStats()
        {
            Console.WriteLine(username);
            Console.WriteLine("================");
            Console.WriteLine($"Strength stats : {strength}");
            Console.WriteLine($"Speed stats : {speed}");
            Console.WriteLine($"PV stats : {pv}");
            Console.WriteLine($"Defense stats : {defense}");
            Console.WriteLine($"Accuracy stats : {accuracy}");
        }

        
        public static void AfficherJeu(int[,] grille, int posX, int posY, int posCléX, int posCléY)
        {
            Random random = new Random();
            const int ValeurMin = 0;
            const int ValeurMax = 10;
            int valeurAleatoire = random.Next(ValeurMin, ValeurMax);
            int posElfX = valeurAleatoire;
            int posElfY = valeurAleatoire;
            int ligne = grille.GetLength(0);
            int colonne = grille.GetLength(1);
            string borderX = " " + new string('_', colonne * 3);
            Console.WriteLine(borderX);
            Console.Clear();
            for (int i = 0; i < ligne; i++)
            {
                Console.Write("|");
                for (int j = 0; j < colonne; j++)
                {

                    if (posX == j && posY == i)
                    {
                        Console.Write(" X ");//Personnage
                    }
                    else if (posCléX == j && posCléY == i)
                    {
                        Console.Write(" O ");//Clé
                    }
                    else if (posX == j && posY == i && posCléX == j && posCléY == i)
                    {
                        Console.Write(" X ");//If clé

                    }
                    else
                    {
                        Console.Write("   ");
                    }


                }
                Console.WriteLine("|");
            }
            Console.WriteLine(borderX);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
