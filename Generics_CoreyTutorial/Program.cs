namespace Generics_CoreyTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> ages = new List<int>();

            //ages.Add(21);

            Console.WriteLine();
            Console.Write("Press enter to shut down . . . ");
            Console.ReadLine();
        }


        private static void DemonstrateTextFileStorage()
        {
            List<Person> people = new List<Person>();
            List<LogEntry> logs = new List<LogEntry>();

            string peopleFile = @"C:\Users\4400113921\Documents\Persistence\peopleFile.csv";
            string logFile = @"C:\Users\4400113921\Documents\Persistence\logs.csv";

            PopulateLists(people, logs);

            OriginalTextFileProcessor.SavePeople(people, peopleFile);

            var newPeople = OriginalTextFileProcessor.LoadPeople(peopleFile);

            foreach (var p in newPeople)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName} (IsAlive = {p.IsAlive})");
            }
        }

        private static void PopulateLists(List<Person> people, List<LogEntry> logs)
        {
            people.Add(new Person { FirstName = "Chapel", LastName = "Nurse" });
            people.Add(new Person { FirstName = "Seven", LastName = "of Nine", IsAlive = false });
            people.Add(new Person { FirstName = "T'Pol", LastName = "Vulcanness" });

            logs.Add(new LogEntry { Message = "Oh!  Hello there!", ErrorCode = 69 });
            logs.Add(new LogEntry { Message = "You will be assimilated.", ErrorCode = 7 });
            logs.Add(new LogEntry { Message = "That is not  . . . logical . . . but perhaps, very nice.", ErrorCode = 69 });
        }
    }
}