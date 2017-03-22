using System;
using Xunit;
using AddressLibrary;

namespace AddressTest
{
    public class AddressTestMaster
    {
        /*[Fact]
        public void Given2Result12() {
        FizzBuzzMaster fbm = new FizzBuzzMaster();
        var expected = "1 2 ";
        var actual = fbm.GetResult(2);
        Assert.Equal(expected, actual);
        }*/

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
        [Fact]
        public void enterAddressBuildingNumber(){
            AddressMaster address = new AddressMaster();
            address.BuildingNumber = 1234;
            var expected = 1234;
            var actual = address.BuildingNumber;
            Assert.Equal(expected,actual);
        }
        //   [Fact]
        // public void enterAddressBuildingNull(){
        //     AddressMaster address = new AddressMaster();
        //     address.BuildingNumber = "";
        //     var expected = 0;
        //     var actual = address.BuildingNumber;
        //     Assert.Equal(expected,actual);
        // }
          [Fact]
        public void enterAddressBuildingNegative(){
            AddressMaster address = new AddressMaster();
            address.BuildingNumber = -12;
            var expected = 0;
            var actual = address.BuildingNumber;
            Assert.Equal(expected,actual);
        }
    }
}
