using Microsoft.Data.SqlClient;

namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        var c = new SqlConnection();
        Assert.Pass();
    }
}