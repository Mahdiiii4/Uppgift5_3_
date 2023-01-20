using System;
namespace Uppgift5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fråga = new string[4];
            string[] svar = new string[4];
            fråga[0] = "Vad är kungen för och efter namn?";
            svar[0] = "carl gustaf";
            fråga[1] = "Vem vann världscup?";
            svar[1] = "argentina";
            fråga[2] = "Vad heter vår galax?";
            svar[2] = "vintergatan";
            fråga[3] = "Vilken sida anväder vi för att ladda up vår källkod på?";
            svar[3] = "github";

            Console.WriteLine("Vilken fråga vill du ha? 1/4");
            int välja = int.Parse(Console.ReadLine());
            välja = välja - 1;
            switch(välja)
            {
                case 0:
                    {
                        Console.WriteLine(fråga[0]);
                        string anvädareSvar = Console.ReadLine();
                        anvädareSvar = anvädareSvar.ToLower();
                        if (anvädareSvar == svar[0])
                        {
                            Console.WriteLine("Du svarade rätt");
                        }
                        else
                        {
                            Console.WriteLine("Du svarade fel");
                        }
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine(fråga[1]);
                        string anvädareSvar = Console.ReadLine();
                        anvädareSvar = anvädareSvar.ToLower();
                        if (anvädareSvar == svar[1])
                        {
                            Console.WriteLine("Du svarade rätt");
                        }
                        else
                        {
                            Console.WriteLine("Du svarade fel");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(fråga[2]);
                        string anvädareSvar = Console.ReadLine();
                        anvädareSvar = anvädareSvar.ToLower();
                        if (anvädareSvar == svar[2])
                        {
                            Console.WriteLine("Du svarade rätt");
                        }
                        else
                        {
                            Console.WriteLine("Du svarade fel");
                        }
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(fråga[3]);
                        string anvädareSvar = Console.ReadLine();
                        anvädareSvar = anvädareSvar.ToLower();
                        if (anvädareSvar == svar[3])
                        {
                            Console.WriteLine("Du svarade rätt");
                        }
                        else
                        {
                            Console.WriteLine("Du svarade fel");
                        }
                        break;
                    }
            }
        }
    }
}