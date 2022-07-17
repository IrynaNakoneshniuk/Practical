using static System.Console;
namespace ConsoleApp1
{
    internal class Program
    {
        static void  Task1()
        {
            try
            {
                Human[] humans = { new Builder(), new Pilot(), new Salior() };
                humans[0].InputInfo("Volodymyr", 30, "Bilder", "Antonov");
                humans[1].InputInfo("Oleg", 35, "Pilot", "Yefimenko");
                humans[2].InputInfo("Vasyl", 40, "Salior", "Rudyk");
                foreach (Human human in humans)
                {
                    WriteLine(human.ToString());
                    human.DiscriptionActivity();
                }
            }
            catch(IndexOutOfRangeException exIndex)
            {
                Console.WriteLine(exIndex.Message.ToString());
            }
            catch(OutOfMemoryException exMemory)
            {
                Console.WriteLine(exMemory.Message.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        static void Task2()
        {
            try
            {
                Visa visa = new Visa("France", "One month", "Turistic");
                Passport passport = new ForeignPassport(11111, "Vasyl", "Kyryliuk", "01.01.1990", "Ukraine, Vinnytsia, str Street,10");
                (passport as ForeignPassport).AddVisas(visa);
                passport.PersonalInfo();
                (passport as ForeignPassport).ShowVisas();
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Task3()
        {
            try
            {
                Animal[] animal = { new Tiger("Tiger", "Mammal"),
                new Crocodile("Crocodile", "Reptilian"), new Kangaroo("Kangaroo", "Mammal") };
                foreach (Animal anim in animal)
                {
                    anim.ShowInfo();
                    anim.AnimalDescription();
                }
            }
            catch(Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Task4()
        {
            try
            {
                Figure[] figures = { new Rectangl("Rectangl",4.5,5.5), new Circule("Circule",6),
                    new Rigth_Triangle("Rigth_Triangle",3.4,3.4), new Trapeze("Trapeze",7,8,4.5) };
                foreach(Figure f in figures)
                {
                    f.ShowInfo();
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message.ToString());
            }
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }
    }
}