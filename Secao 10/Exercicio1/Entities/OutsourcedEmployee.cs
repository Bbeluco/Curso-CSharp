﻿namespace Exercicio1;

public class OutsourcedEmployee : Employee
{
    public double AdditionalCharge { get; set; }

    public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
        : base(name, hours, valuePerHour)
    {
        AdditionalCharge = additionalCharge;
    }

    public override double Payment()
    {
        return (Hours * ValuePerHour) + (AdditionalCharge * 1.1);
    }
}
