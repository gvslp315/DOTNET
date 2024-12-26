using UnitTest.Controllers;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var hc = new HomeController(null);
            string? result;

            //ACT
            result = hc.EO(7);

            //Assert
            Assert.Equal(actual: "odd", expected: result);
        }
        [Fact]
        public void Test2()
        {
            //Arrange
            var hc = new HomeController(null);
            int? result;

            //ACT
            result = hc.fact(5);

            //Assert
            Assert.Equal(actual:120 , expected: result);
        }
        [Fact]
        public void Test3() {
            var t3 = new HomeController(null);
            string result=t3.text();
            Assert.Contains("Priya",result);


}
    }
    


    }
