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
    
    //street
     private string _Street;
    
    public string Street{
        get{return _Street;}
        set{
           if(value == null)
           _Street = "";
           else
                if(!Regex.IsMatch(value, "^[a-zA-Z]+$"))
                     _Street = "";
                else
                    _Street = value;
            
    }
    }
    //City
     private string _City;
    
    public string City{
        get{return _City;}
        set{
           if(value == null)
           _City = "";
           else
                if(!Regex.IsMatch(value, "^[a-zA-Z]+$"))
                     _City = "";
                else
                    _City = value;
            
    }
    }

    //Country
      private string _Country;
    
    public string Country{
        get{return _Country;}
        set{
           if(value == null)
           _Country = "";
           else
                if(!Regex.IsMatch(value, "^[a-zA-Z]+$"))
                     _Country = "";
                else
                    _Country = value;
            
    }
    }
   
      //CanadaPostalCode
      private string _CanadaPostalCode;
    
    public string CanadaPostalCode{
        get{return _CanadaPostalCode;}
        set{
           if(value == null)
           _CanadaPostalCode = "";
           else
                 if(!Regex.IsMatch(value, "[A-Za-z][0-9][A-Za-z][0-9][A-Za-z][0-9]"))
                     _CanadaPostalCode = "";
                else
                    _CanadaPostalCode = value;
            
    }
    }
    
    


   



}
}
