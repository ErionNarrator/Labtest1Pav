using Labtest1Pav;
namespace TestProject3;

public class Tests 
{
    [Test]
    public void TestProject3()
    {
        Labtest1Pav.Class1 matrix = new Labtest1Pav.Class1 ();
        Assert.AreEqual(true, matrix.Equals(matrix));
        Assert.AreNotEqual(false, matrix.Equals(matrix));


    }
}
