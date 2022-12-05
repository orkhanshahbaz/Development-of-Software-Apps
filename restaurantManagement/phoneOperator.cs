using System;

namespace restaurantManagement
{
	public class phoneOperator
    {
		public List<Table> Tables { get; set; } = new List<Table>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

		public dailyMenu dailyMenu { get; set; }
		public string Name { get; set; }
        public phoneOperator (string name)

		{
			Name = name;
		}

		public dailyMenu GetDailyMenu()
		{
			return dailyMenu;
		}

		public List<Table> GetAvailableTables(DateTime currentTime)
		{

             List<Table> availableTables = new List<Table>();
			foreach (var table in Tables)
			{
				var bookedTable = false;

				foreach (var reservation in Reservations)
				{

					if(reservation.tableNumber != table.tableNumber)
					{
						continue;
					}
					if (reservation.arrivalTime <= currentTime && reservation.departureTime >= currentTime)
					{
						bookedTable = true;
						break;
					}
					
				}
				if (bookedTable == false)
				{
					availableTables.Add(table);
				}

			}

			return availableTables;

		}
		public Reservation addReservation (int tableNumber, string guestName, DateTime arrivalTime, DateTime departureTime, int numberOfGuests)
		{
            var availTables = GetAvailableTables(DateTime.Now);

			if (availTables.Any(table => table.tableNumber == tableNumber && table.chairs >= numberOfGuests))
			{
				Reservation reservation = new Reservation(tableNumber, guestName, arrivalTime, departureTime, numberOfGuests);
				Reservations.Add(reservation);
				return reservation;
			}
			throw new Exception("There is no available table");
			
		}
	}
}

