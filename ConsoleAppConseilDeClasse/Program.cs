namespace ConsoleAppConseilDeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("saisir le niveau : ");
            int niveau = int.Parse(Console.ReadLine());
            Console.WriteLine("saisir la classe principale : G,M, ou R");
            string classePrincipale = Console.ReadLine();
            Console.WriteLine("Nombres de quêtes Héroique accomplies : ");
            int nbQuetesHeroiques = int.Parse(Console.ReadLine());

            string titre="";
            //"novice, intermédiaire, adepte, expert, maître de guilde, Statut Intermédaire/Hors-la-loi";

           

            if (niveau < 10)
            {
                titre = "novice";
            }
            else if ((niveau >= 10 && niveau <= 20) && (nbQuetesHeroiques < 5))
            {
                titre = "adepte";
            }

            else if (niveau > 10 && niveau <= 20 && nbQuetesHeroiques >= 5)
            {
                titre = "apprenti assermenté";
            }
            
            else if ((niveau > 20 && niveau < 30) || (classePrincipale == "M" && niveau >= 25))
            {
                titre = "vétéran";
            }
            else if (niveau >= 30 && nbQuetesHeroiques >= 20 && (classePrincipale == "M" && classePrincipale == "G"))
            {
                titre = "maître de guilde";
            }
            else titre = "Statut Indéterminé / Hors-la-loi";

            Console.WriteLine($"Votre titre : {titre}");
        }
    }
}

        
    