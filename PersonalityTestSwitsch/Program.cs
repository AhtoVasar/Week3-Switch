using System;

namespace PersonalityTestSwitsch
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm küsib kasutajal sisestada tema lemmikvärv;
            //kui kasutaja sisestab "punane" konsool kuvab "oled romantiline";
            //kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
            //kui kasutaja sisestab "roheline", konsool kuvab "oled looduse sõber";
            //kui kasutaja sesestab midagi muud, konsool kuvab "oled {iserColor} üksarvik";

            Console.WriteLine("Sisesta oma lemmikvärv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled loodusesõber.");
                    break;
                default:
                    Console.WriteLine($"Oles {userColor} üksarvik");
                    break;
            }
            Console.WriteLine("Kena päeva");


        }
    }
}
