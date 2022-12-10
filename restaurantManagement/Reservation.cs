using System;

namespace restaurantManagement
{
    public class Reservation  // Derived class
    {
        public Table table;
        public int tableNumber;
        public string guestName;
        public DateTime arrivalTime;
        public DateTime departureTime;
        public int numberOfGuests;

        public Reservation(int tableNumber, string guestName, DateTime arrivalTime, DateTime departureTime, int numberOfGuests)
        {


            this.tableNumber = tableNumber;
            this.guestName = guestName;
            this.arrivalTime = arrivalTime;
            this.departureTime = departureTime;
            this.numberOfGuests = numberOfGuests;

        }

        public override string ToString()
        {
            return "Reservation: " + tableNumber + guestName + arrivalTime + departureTime + numberOfGuests;
        }




    }
}