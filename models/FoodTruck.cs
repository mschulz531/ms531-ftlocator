using System;
using System.Drawing;
using System.Text.Json.Serialization;

/*
Columns in the SF Mobile Food Schedule dataset:
(https://data.sfgov.org/Economy-and-Community/Mobile-Food-Schedule/jjew-r69b)

ColumnName	        Description	                                                    Type
==================  ==============================================================  ===========
DayOrder	        Number corresponding to day of week: 0=Sunday, 1=Monday, etc.   Number
DayOfWeekStr	    Day of Week                                                     Plain Text
starttime	        Start time                                                      Plain Text
endtime	            End time                                                        Plain Text
permit	            Permit number                                                   Plain Text
PermitLocation	    Address or blocklot (parcel) number of location                 Plain Text
locationdesc	    Description of street segment or intersection location          Plain Text
optionaltext	    A description of food items sold                                Plain Text
locationid	        Location id of facility                                         Number
scheduleid          Schedule id of facility                                         Number
start24             Start time in 24 hour format                                    Plain Text
end24	            End time in 24 hour format                                      Plain Text
CNN	                CNN of street segment or intersection location                  Number
Addr_Date_Create    Date schedule record created                                    Date & Time
Addr_Date_Modified	Date schedule record modified                                   Date & Time
block	            Block number                                                    Plain Text
lot	                Lot number                                                      Plain Text
ColdTruck	        cold truck: Y or N                                              Plain Text
Applicant	        Name of permit holder                                           Plain Text
X	                CA State Plane III                                              Number
Y	                CA State Plane III                                              Number
Latitude	        WGS84                                                           Number
Longitude	        WGS84                                                           Number
Location	        Location formatted for mapping                                  Point
*/

public class MobileFoodSource
{
    public long DayOrder { get; set; }

    public string DayOfWeekStr  {get; set; }
    
    [JsonPropertyName("starttime")]
    public string StartTime { get; set; }
    
    [JsonPropertyName("endtime")]
    public string EndTime { get; set; }
    
    [JsonPropertyName("permit")]
    public string PermitNumber { get; set; }

    public string PermitLocation { get; set; }
    
    [JsonPropertyName("locationdesc")]
    public string LocationDescription { get; set; }

    [JsonPropertyName("optionaltext")]
    public string FoodDescription { get; set; }

    [JsonPropertyName("locationid")]
    public long LocationId { get; set;}

    [JsonPropertyName("scheduleid")]
    public long ScheduleId { get; set; }

    [JsonPropertyName("start24")]
    public string Start24 { get; set; }

    [JsonPropertyName("end24")]
    public string End24 { get; set; }

    [JsonPropertyName("CNN")]
    public int Cnn { get; set; }

    [JsonPropertyName("Addr_Date_Created")]
    public DateTime DateCreated { get; set; }

    [JsonPropertyName("Addr_Date_Modified")]
    public DateTime DateModified { get; set; }

    [JsonPropertyName("block")]
    public int BlockNumber { get; set; }
  
    [JsonPropertyName("lot")]
    public int LotNumber { get; set; }
  
    public string ColdTruck { get; set; }
  
    public string Applicant { get; set; }
  
    public int X { get; set; }
  
    public int Y { get; set; }
  
    public int Latitude { get; set; }
  
    public int Longitude { get; set; }
  
    public Point Location { get; set; }
 }