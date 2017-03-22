using System;
using System.Text.RegularExpressions;

namespace AddressLibrary
{
   public class AddressMaster {
    private string _FirstName;
    
    public string FirstName{
        get{return _FirstName;}
        set{
           if(value == null)
           _FirstName = "";
           else
                if(!Regex.IsMatch(value, "^[a-zA-Z]+$"))
                     _FirstName = "";
                else
                    _FirstName = value;
            
    }
    }
    private string _LastName;
    public string LastName { get {return _LastName;} set{
        if(Regex.IsMatch(value, "^[a-zA-Z]+$"))
        _LastName = value;
        else
        _LastName = "";
    }}
    private int _BuildingNumber;
    public int BuildingNumber { get{return _BuildingNumber;  } 
    set{
        if(_BuildingNumber == null)
        _BuildingNumber = 0;
        else
            if(value < 0)
                 _BuildingNumber = 0;
            else
                _BuildingNumber = value;}}
    private 
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string CanadaPostalCode { get; set; }


   



}
}
