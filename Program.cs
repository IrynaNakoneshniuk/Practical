namespace H_W._28._07
{
    internal class Program
    {
        static void Task1()
        {
            IOceanDwellers[] oceanDwellers = { new Dolphin("Dolphin"), new Shark("Shark"), new Turtle("Turtle")};
            foreach(IOceanDwellers oceanDweller in oceanDwellers)
            {
                oceanDweller.InfoOceanDwellers();
            }
        }
        static void Task2()
        {
            IPlayer[] players = {new Goalkeeper("Volodymyr",25,10,2, " Goalkeeper"), new CenterForward("Oleg", 25, 10, 2, "Center Forward"),
            new Attacker("Volodymyr",25,10,2, "Attacker")};
            foreach(IPlayer player in players)
            {
                player.ShowPlayerInfo();
            }
        }
        static void Task3()
        {
            IEmployee[] employees = { new Manager("Volodymyr", 25, 10, 2, " Manager"),new Cashier("Oleg", 25, 10, 2, "Cashier"),
            new Waiter("Mykola",25,10,2, "Waiter")};
            foreach(IEmployee employee in employees)
            {
                employee.ShowEmployeeInfo();
            }
        }
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            Task3();

        }
    }
}