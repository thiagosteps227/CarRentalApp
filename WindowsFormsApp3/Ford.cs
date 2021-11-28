using System;

class Ford : Car
{

    public Ford(string nm, string pn, int rd, int dr) :
                  base(nm, pn, rd, dr)
    {

    }

    override public String readCarModel()
    {
        return "Ford";
    }

    override public String readRentalDetails()
    {
        return "Total Rental: Daily Rate * Price";
    }
    override public int readTotalPrice()
    {
        return (int)(rentalDays * dailyRate);
    }
}




