//student
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


abstract class Car
{
    private string name;
    private string plateNumber;
    protected int rentalDays;
    protected int dailyRate;

    public Car(string nm, string pn, int rd, int dr)
    {
        name = nm;
        plateNumber = pn;
        rentalDays = rd;
        dailyRate = dr;
    }
    public string readName()
    {
        return name;
    }
    public string readPlateNumber()
    {
        return plateNumber;
    }
    public int readRentalDays() { return rentalDays; }

    public int readDailyRate() { return dailyRate; }

    public bool setRentalDays(int r)
    {
        if (r > 10) return false;
        else { rentalDays = r; return true; }
    }
    public bool setDailyRate(int d)
    {
        if (d > 10) return false;
        else { dailyRate = d; return true; }
    }
    abstract public String readCarModel();
    abstract public String readRentalDetails();
    abstract public int readTotalPrice();

}

