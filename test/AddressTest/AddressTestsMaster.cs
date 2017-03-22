using System;
using Xunit;
using AddressLibrary;

namespace AddressTest
{
    public class AddressTestMaster
    {
        
        [Fact]
        public void enterAddressFirstNameNormal(){
            AddressMaster address = new AddressMaster();
            address.FirstName = "tom";
            var expected = "tom";
            var actual = address.FirstName;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void enterAddressFirstNameNull(){
            AddressMaster address = new AddressMaster();
            address.FirstName = null;
            var expected = "";
            var actual = address.FirstName;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void enterAddressFirstNameEmpty(){
            AddressMaster address = new AddressMaster();
            address.FirstName = "";
            var expected = "";
            var actual = address.FirstName;
            Assert.Equal(expected,actual);
        }
         [Fact]
        public void enterAddressFirstNumbers(){
            AddressMaster address = new AddressMaster();
            address.FirstName = "abab234423432";
            var expected = "";
            var actual = address.FirstName;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void enterAddressLastNameNormal(){
            AddressMaster address = new AddressMaster();
            address.LastName = "ABC";
            var expected = "ABC";
            var actual = address.LastName;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void enterAddressLastNameNumbers(){
            AddressMaster address = new AddressMaster();
            address.LastName = "ABC#*(*(34)*()#*";
            var expected = "";
            var actual = address.LastName;
            Assert.Equal(expected,actual);
        }
        //Building Tests
        [Fact]
        public void enterAddressBuildingNumber(){
            AddressMaster address = new AddressMaster();
            address.BuildingNumber = 1234;
            var expected = 1234;
            var actual = address.BuildingNumber;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void enterAddressBuildingNegative(){
            AddressMaster address = new AddressMaster();
            address.BuildingNumber = -12;
            var expected = 0;
            var actual = address.BuildingNumber;
            Assert.Equal(expected,actual);
        }
        //Street tests
        [Fact]
        public void enterAddressStreetNormal(){
            AddressMaster address = new AddressMaster();
            address.Street = "tom";
            var expected = "tom";
            var actual = address.Street;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void enterAddressStreetNull(){
            AddressMaster address = new AddressMaster();
            address.Street = null;
            var expected = "";
            var actual = address.Street;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void enterAddressStreetEmpty(){
            AddressMaster address = new AddressMaster();
            address.Street = "";
            var expected = "";
            var actual = address.Street;
            Assert.Equal(expected,actual);
        }

        //Street Tests
        [Fact]
        public void enterAddressCityNormal(){
            AddressMaster address = new AddressMaster();
            address.City = "tom";
            var expected = "tom";
            var actual = address.City;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void enterAddressCityNull(){
            AddressMaster address = new AddressMaster();
            address.City = null;
            var expected = "";
            var actual = address.City;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void enterAddressCityEmpty(){
            AddressMaster address = new AddressMaster();
            address.City = "";
            var expected = "";
            var actual = address.City;
            Assert.Equal(expected,actual);
        }

        //Country Tests
        [Fact]
        public void enterAddressCountryNormal(){
            AddressMaster address = new AddressMaster();
            address.Country = "tom";
            var expected = "tom";
            var actual = address.Country;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void enterAddressCountryNull(){
            AddressMaster address = new AddressMaster();
            address.Country = null;
            var expected = "";
            var actual = address.Country;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void enterAddressCountryEmpty(){
            AddressMaster address = new AddressMaster();
            address.Country = "";
            var expected = "";
            var actual = address.Country;
            Assert.Equal(expected,actual);
        }
        //Postal Tests
          [Fact]
        public void enterAddressCanadaPostalCodeNormal(){
            AddressMaster address = new AddressMaster();
            address.CanadaPostalCode = "V5W3M4";
            var expected = "V5W3M4";
            var actual = address.CanadaPostalCode;
            Assert.Equal(expected,actual);
        }

        [Fact]
        public void enterAddressCanadaPostalCodeNull(){
            AddressMaster address = new AddressMaster();
            address.CanadaPostalCode = null;
            var expected = "";
            var actual = address.CanadaPostalCode;
            Assert.Equal(expected,actual);
        }
        [Fact]
        public void enterAddressCanadaPostalCodeEmpty(){
            AddressMaster address = new AddressMaster();
            address.CanadaPostalCode = "";
            var expected = "";
            var actual = address.CanadaPostalCode;
            Assert.Equal(expected,actual);
        }
        



    }
}
