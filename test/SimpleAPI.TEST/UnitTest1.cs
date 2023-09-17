namespace SimpleAPI.TEST;
using Xunit;
using SimpleAPI.Controllers;


public class UnitTest1
{
  

    [Fact]
    public void Test1()
    {
    

    } 
    
    WeatherForecastController controller = new WeatherForecastController();
     [Fact]
    public void GetReturnsCoorectNumber(){
        var returnValue= controller.Get(1);
        Assert.Equal("something good is coming towards you", returnValue.Value);
    }



}