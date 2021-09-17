using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaastat;
            //programm kuvab sünniaastat konsoolis
            //"Oled sündidnud aastal {yearOfBirth}"

            Console.WriteLine("Palun, sisesta oma vanus:");
            int yearOfBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2021 - yearOfBirth;

            Console.WriteLine($"Oled sündinud aastal {userAge}.");

        }
    }
}
