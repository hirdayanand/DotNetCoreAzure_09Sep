
using CoreWebAPIAzure;
using CoreWebAPIAzure.Controllers;
using Xunit;
namespace CoreWebAPIAzure.Test;

public class UnitTest1
{
    ValuesController valuesController=new ValuesController();// Arrange
    [Fact]
    public void Test1()
    {
        var test=valuesController.Get(1); //Act
        Assert.Equal("Yukti23",test);

    }
}