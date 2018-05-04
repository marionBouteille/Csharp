using System;

namespace Isen.Cs.Library.Lessons
{
    public class B_Enumerations
    {
        public void RunEnumerations()
        {
            //Affichage du label de l'énum
            Console.WriteLine($"JoursSemaine.Lundi = {JourSemaine.Lundi}");
            //Affichage de l'entier de l'énum
            Console.WriteLine($"JoursSemaine.Lundi = {(int)JourSemaine.Lundi}");
            //int >vers valeur d'enum
            int day4 = 4;
            JourSemaine whoIsDay4 = (JourSemaine) day4;
            Console.WriteLine($"day4 = {whoIsDay4}");
            //String > valeur d'enum
            string mardi = "Mardi";
            // .Net / C# <= 4
            JourSemaine parsed = (JourSemaine)Enum.Parse(typeof(JourSemaine), mardi);
            Console.WriteLine($"parsed = {parsed}");
            
            // .Net Coez / .Net > 4

            JourSemaine parsed2;
            //out permet de passer par "adresse" et non pas valeur
            bool didItWork = Enum.TryParse("Mercredi", out parsed2);
           Console.WriteLine($"parsed2 = {parsed2} / worked ? {didItWork}");
            
            //GetNames renvoie un tableau de String
            var enumNames = Enum.GetNames(typeof(JourSemaine));
            foreach (var enumName in enumNames)
            {
                Console.WriteLine(enumName);
            }
            
            //GetValues renvoie un tableau d'objet (ici des JourSemaine) que l'on cast en entier)
            var enumValues = Enum.GetValues(typeof(JourSemaine));
            foreach (JourSemaine enumValue in enumValues)
            {
                Console.WriteLine((int)enumValue);
            }

            var jour =(JourSemaine) (new Random().Next(0, 7));
            DayOfWeek foundDayOfWeek;
            switch (jour)
            {
                case JourSemaine.Lundi:
                    foundDayOfWeek = DayOfWeek.Monday;
                    break;
                case JourSemaine.Mardi:
                    foundDayOfWeek = DayOfWeek.Tuesday;
                    break;
                case JourSemaine.Mercredi:
                    foundDayOfWeek = DayOfWeek.Wednesday;
                    break;
                case JourSemaine.Jeudi:
                    foundDayOfWeek = DayOfWeek.Thursday;
                    break;
                case JourSemaine.Vendredi:
                    foundDayOfWeek = DayOfWeek.Friday;
                    break;
                case JourSemaine.Samedi:
                    foundDayOfWeek = DayOfWeek.Saturday;
                    break;
                case JourSemaine.Dimanche:
                    foundDayOfWeek = DayOfWeek.Sunday;
                    break;
                
                default:
                    foundDayOfWeek = DayOfWeek.Sunday;
                    break;
            }
            
            //C#7 : nameof() => nom de la variable, en string
            Console.WriteLine($"{nameof(foundDayOfWeek)} = {foundDayOfWeek}");
            Console.WriteLine($"Random day was {foundDayOfWeek}");
        }

        public enum JourSemaine
        {
            Lundi = 1,
            Mardi = 2,
            Mercredi = 3,
            Jeudi = 4,
            Vendredi = 5,
            Samedi = 6,
            Dimanche = 7
        }

        public enum Result
        {
            Success, Fail
        }
    }
}