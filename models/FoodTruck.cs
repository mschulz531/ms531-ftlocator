using System;

public class FoodTruck
{
    public long LocationId { get; set; }
    public string Applicant { get; set; }
    public string FacilityType { get; set; }
    public int Cnn { get; set; }
    public string LocationDescription { get; set; }
    public string Address { get; set; }
    public int BlockLot { get; set; }
    public int Lot { get; set; }
    public string Permit { get; set; }
    public string PermitStatus { get; set; }
    public string FoodItems { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public int Latitude { get; set; }
    public int Longitude { get; set; }
    public Tuple<int, int> LocationPoint { get; set; }
    public string Schedule { get; set; }
    public string DaysHours { get; set; }
    public DateTime NoiSent { get; set; }
    public DateTime NoiApproved { get; set; }
    public DateTime NoiReceived { get; set; }
     public int PriorPermits { get; set; }
    public DateTime PermitExpirationDate { get; set; }
}