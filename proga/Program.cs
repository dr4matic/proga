using System;

namespace JABKA
{

    class Program
    {
        static void Main(string[] args)
        {


            Person tom = new Person();  


            string personName = tom.name;
            int personAge = tom.age;
            Console.WriteLine($"Имя: {personName}  Возраст {personAge}");


            tom.name = Console.ReadLine();
            tom.age = ThingAboutThis("Print: ");
            tom.Print();


        }

        static int ThingAboutThis(string message)
        {
            int znach;
            while (true)
            {
                Console.Write(message);
                var chislo = Console.ReadLine();
                bool result = int.TryParse(chislo, out znach);
                if (result)
                {
                    break;
                }
                Console.WriteLine("Exception");
            }
              return znach;
        }
    }
}
