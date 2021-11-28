using System;

class Citroen : Car
{

    public Citroen(string nm, string pn, int rd, int dr) :
                  base(nm, pn, rd, dr)
    {

    }

    override public String readCarModel()
    {
        return "Citroen";
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



