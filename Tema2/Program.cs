using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2
{
    public enum Gen
    {   Null,
        Male,
        Female
    }
    class Program
    {
        private const int RetAgeM = 65;
        private const int RetAgeF = 63;

    }
    private static int CalcAge(DateTime birthDate)
    {
        return (int)((DateTime.Now - birthDate).TotalDays / 365.25);
    }

      private static Gen()
    {
        Console.Write("Introduceti genul (M/F): ");
        char genAsChar = Convert.ToChar(Console.ReadLine());

        Gen? gen = null;
        switch (genAsChar)
        {
            case 'm':
            case 'M':
                gen = Gen.Male;
                break;
            case 'f':
            case 'F':
                gen = Gen.Female;
                break;
        }

        return gen;
    }

    private static string GetMessage(DateTime birthDate, int minAgeForRet)
    {
        int age = CalcAge(birthDate);
        if (age > minAgeForRetirement)
        {
            return "Deja te-ai pensionat!";
        }
        else
        {
            return $"Te vei pensiona la {minAgeForRet} de ani";
        }
    }

    private static void DisplayMessage(Gender? gender, DateTime birthDate)
    {
        if (gender.HasValue)
        {
            switch (gender.Value)
            {
                case Gender.Male:
                    Console.WriteLine(GetRetirementMessage(birthDate, RetM));
                    break;
                case Gender.Female:
                    Console.WriteLine(GetMessage(birthDate, RetAgeF));
                    break;
            }
        }
        else
        {
            Console.WriteLine("Nu ati introdus genul corect!");
        }
    }

    static void Main(string[] args)
    {
        DateTime birthDate = ReadBirthDate();
        Gen? gender = ReadGen();
        DisplayMessage(gender, birthDate);
    }
}
}
}
