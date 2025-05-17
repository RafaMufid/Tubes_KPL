// See https://aka.ms/new-console-template for more information

using Tubes_KPL_Program.Battle;
using Tubes_KPL_Program.Menu;

class Program
{
    static async Task Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Feature Test Console App ===");
            Console.WriteLine("1. Compendium");
            Console.WriteLine("2. battle test");
            Console.WriteLine("0. Exit");
            Console.WriteLine("================================");
            Console.Write(">> Choose an option: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    await Compendium.Run();
                    break;

                case "2":
                    await Battle.Start();
                    break;

                case "0":
                    Console.WriteLine("See you later!");
                    exit = true;
                    break;

                default:
                    Console.WriteLine(">!!!> Invalid option. Try again.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
