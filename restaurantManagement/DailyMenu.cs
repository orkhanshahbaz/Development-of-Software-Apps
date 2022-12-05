
using System;
namespace restaurantManagement
{
    public class dailyMenu
    {
        public string[] menu;


        public dailyMenu(string[] menu)
        {
            this.menu = menu;
        }

        public override string ToString()
        {
            return string.Join(", ", menu);
        }
    }
}

