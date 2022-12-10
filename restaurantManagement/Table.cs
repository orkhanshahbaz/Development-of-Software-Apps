using System;
namespace restaurantManagement
{
    public class Table  // Base class
    {
        public int tableNumber;

        public int chairs;
        public string location = "restaurant";
        

        public Table(int tableNumber, int chairs, string location)
        {

            this.tableNumber = tableNumber;
            this.chairs = chairs;
            this.location = location;

        }

        public override string ToString()
        {
            return "Number of chairs: " + chairs + "\n Location of table" + location + "\n Table number: " + tableNumber;

        }

    }
}

