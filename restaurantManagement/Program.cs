using System;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace restaurantManagement
{

    class Program
    {

        static void Main(string[] args)
        {

            phoneOperator phoneOperator = new phoneOperator("Charlie");
            dailyMenu dailyMenu = new dailyMenu(new string[] { "salad", "soup", "kebab", "langos", "chicken breast" });
            phoneOperator.dailyMenu = dailyMenu;
            Table table1 = new Table(1, 2, " - near window");
            Table table2 = new Table(2, 4, " - middle");
            Table table3 = new Table(3, 2, " - bar sitting");
            Table table4 = new Table(4, 2, " - left corner");
            Table table5 = new Table(5, 2, " - left corner");
            Table table6 = new Table(6, 2, " - left corner");
            phoneOperator.Tables.Add(table1);
            phoneOperator.Tables.Add(table2);
            phoneOperator.Tables.Add(table3);
            phoneOperator.Tables.Add(table4);
            phoneOperator.Tables.Add(table5);
            phoneOperator.Tables.Add(table6);
            phoneOperator.addReservation(4, "Someone", DateTime.Now.AddHours(-1), DateTime.Parse("2022-12-31 17:30:00"), 1);
            Console.WriteLine("Hello, For seeing all tables press Enter");
            Console.ReadLine();
            phoneOperator.Tables.ForEach(table => Console.WriteLine(table));

            Console.WriteLine("See available tables by pressing enter");
            Console.ReadLine();
            phoneOperator.GetAvailableTables(DateTime.Now).ForEach(table => Console.WriteLine(table));
            //while (true)
            //{
                try
                {
                    Console.WriteLine("For adding new reservation please specify information: Table number, Guest name, arrival time, departure time, number of guests");
                    var tableNumber = Console.ReadLine();
                    var guestName = Console.ReadLine();
                    var arrivalTime = Console.ReadLine();
                    var departureTime = Console.ReadLine();
                    var numberOfGuests = Console.ReadLine();
                    //Console.ReadLine();
                    phoneOperator.addReservation(int.Parse(tableNumber), guestName, DateTime.Parse(arrivalTime), DateTime.Parse(departureTime), int.Parse(numberOfGuests));
                    Console.WriteLine("List of all reservations: ");
                    phoneOperator.Reservations.ForEach(reservation => Console.WriteLine(reservation));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            //}
            Console.WriteLine("For daily menu press enter: ");
            Console.ReadLine();
            Console.WriteLine(phoneOperator.GetDailyMenu());
            Console.ReadLine();

        }

    }
}