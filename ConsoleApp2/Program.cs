

Tesla tesla = new()
{
    BatteryCapacity = 100000,
    Model = "X",
    ConsumptionForHundredKmTrip=25000
};

Mercedes mercedes = new()
{
    FuelCapacity = 80,
    Model = "CLS",
    ConsumptionForHundredKmTrip=11
};


Consumption consumption = new ();

var t1=consumption.MaximumTripWithFullCapacity(tesla);
var t2=consumption.ConsumptionForTrip(tesla,250);

var m1=consumption.MaximumTripWithFullCapacity(mercedes);
var m2=consumption.ConsumptionForTrip(mercedes,250);


Console.WriteLine();



class Consumption
{
    
    public int ConsumptionForTrip(ICar car,int trip)
    {
        return car.ConsumptionForTrip(trip);
    }
    public int MaximumTripWithFullCapacity(ICar car)
    {
        return car.MaximumTripWithFullCapacity;
    }
}

//
interface ICarWithFuel
{
    public int FuelCapacity { get; set; }
    

}
interface ICarElectric
{
    public int BatteryCapacity { get; set; }
}
interface ICar
{
    public int ConsumptionForTrip(int trip);
    public int Id { get; set; }
    public string Model { get; set; }
    public string FuelType();
    public int ConsumptionForHundredKmTrip { get; set; }
    public int MaximumTripWithFullCapacity{ get; }

}

class Mercedes : ICar, ICarWithFuel
{
    public int Id { get; set; }
    public string Model { get; set; }
    public string FuelType()
    {
        return nameof(Mercedes.FuelCapacity);
    }
    public int FuelCapacity { get; set; }

    public int ConsumptionForHundredKmTrip { get; set; }

    public int ConsumptionForTrip(int trip)
    {
        return ConsumptionForHundredKmTrip * trip / 100;
    }
    public int MaximumTripWithFullCapacity { get => FuelCapacity / ConsumptionForHundredKmTrip*100; }

}
class Tesla : ICar, ICarElectric
{
    public int Id { get; set; }
    public string Model { get; set; }
    public string FuelType ()
    {
        return nameof(Tesla.BatteryCapacity);
    }
    public int FuelCapacity { get; set; }
    public int BatteryCapacity { get; set; }
    public int ConsumptionForHundredKmTrip { get; set; }
    public int ConsumptionForTrip(int trip)
    {
        return ConsumptionForHundredKmTrip * trip / 100;
    }
    public int MaximumTripWithFullCapacity { get => BatteryCapacity / ConsumptionForHundredKmTrip * 100; }

}