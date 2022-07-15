using NUnit.Framework;
using Methods;
namespace TestMyMaths
{
    public class Tests
    {
        MyMaths m;
        [SetUp]
     
        public void Setup()
        {
            m = new MyMaths();
        }

        [Test]
        public void Test1()
        {
            int exp = 15;
            int act = m.Add(5, 11);

            Assert.AreEqual(exp, act, "Wrong result");
        }

        [Test]
        public void Test2()
        {
            int exp = 15;
            int act = m.Mul(5, 3);

            Assert.AreEqual(exp, act, "Wrong result");
        }

    }
}