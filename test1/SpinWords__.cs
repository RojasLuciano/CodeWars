using Clases;
namespace UnitTest;


[TestClass]
public class UnitTest1
{


    [TestMethod]
    public void Test1()
    {
        Assert.AreEqual("emocleW", PracticeClass.SpinWords("Welcome"));
    }

    [TestMethod]
    public void Test2()
    {
        Assert.AreEqual("Hey wollef sroirraw", PracticeClass.SpinWords("Hey fellow warriors"));
    }

    [TestMethod]
    public void Test3()
    {
        Assert.AreEqual("This is a test", PracticeClass.SpinWords("This is a test"));
    }

    [TestMethod]
    public void Test4()
    {
        Assert.AreEqual("This is rehtona test", PracticeClass.SpinWords("This is another test"));
    }

    [TestMethod]
    public void Test5()
    {
        Assert.AreEqual("You are tsomla to the last test", PracticeClass.SpinWords("You are almost to the last test"));
    }

    [TestMethod]
    public void Test6()
    {
        Assert.AreEqual("Just gniddik ereht is llits one more", PracticeClass.SpinWords("Just kidding there is still one more"));
    }



}
