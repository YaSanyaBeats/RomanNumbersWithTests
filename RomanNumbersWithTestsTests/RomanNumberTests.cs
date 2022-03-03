using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class RomanNumberTests
    {
        [TestMethod()]
        public void RomanNumberTest()
        {
            RomanNumber a = new RomanNumber(1);
            RomanNumber b = new RomanNumber(1234);
            RomanNumber c = new RomanNumber(3999);

            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(0));
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(4000));
            Assert.ThrowsException<RomanNumberException>(() => new RomanNumber(29999));
        }
        [TestMethod()]
        public void ToStringTest()
        {
            RomanNumber a = new RomanNumber(1);
            RomanNumber b = new RomanNumber(123);
            RomanNumber c = new RomanNumber(456);
            RomanNumber d = new RomanNumber(789);
            RomanNumber e = new RomanNumber(1009);
            RomanNumber f = new RomanNumber(3999);

            Assert.AreEqual("I", a.ToString());
            Assert.AreEqual("CXXIII", b.ToString());
            Assert.AreEqual("CDLVI", c.ToString());
            Assert.AreEqual("DCCLXXXIX", d.ToString());
            Assert.AreEqual("MIX", e.ToString());
            Assert.AreEqual("MMMCMXCIX", f.ToString());
        }
        [TestMethod()]
        public void AddTest()
        {
            RomanNumber a = new RomanNumber(1);
            RomanNumber b = new RomanNumber(500);
            RomanNumber c = new RomanNumber(1000);
            RomanNumber d = new RomanNumber(3999);
            RomanNumber n = null;

            RomanNumber result = new RomanNumber(1500);

            Assert.AreEqual(result.ToString(), (b + c).ToString());
            Assert.ThrowsException<RomanNumberException>(() => a + d);
            Assert.ThrowsException<RomanNumberException>(() => d + d);
            Assert.ThrowsException<RomanNumberException>(() => n + c);
            Assert.ThrowsException<RomanNumberException>(() => c + n);
            Assert.ThrowsException<RomanNumberException>(() => n + n);
        }
        [TestMethod()]
        public void SubTest()
        {
            RomanNumber a = new RomanNumber(1);
            RomanNumber b = new RomanNumber(500);
            RomanNumber c = new RomanNumber(1000);
            RomanNumber d = new RomanNumber(3999);
            RomanNumber n = null;

            RomanNumber result = new RomanNumber(500);

            Assert.AreEqual(result.ToString(), (c - b).ToString());
            Assert.ThrowsException<RomanNumberException>(() => a - d);
            Assert.ThrowsException<RomanNumberException>(() => c - c);
            Assert.ThrowsException<RomanNumberException>(() => n - c);
            Assert.ThrowsException<RomanNumberException>(() => c - n);
            Assert.ThrowsException<RomanNumberException>(() => n - n);
        }
        [TestMethod()]
        public void MulTest()
        {
            RomanNumber b = new RomanNumber(25);
            RomanNumber c = new RomanNumber(30);
            RomanNumber d = new RomanNumber(3999);
            RomanNumber e = new RomanNumber(20);
            RomanNumber f = new RomanNumber(200);
            RomanNumber n = null;

            RomanNumber result = new RomanNumber(750);

            Assert.AreEqual(result.ToString(), (b * c).ToString());
            Assert.ThrowsException<RomanNumberException>(() => d * d);
            Assert.ThrowsException<RomanNumberException>(() => e * f);
            Assert.ThrowsException<RomanNumberException>(() => n * c);
            Assert.ThrowsException<RomanNumberException>(() => c * n);
            Assert.ThrowsException<RomanNumberException>(() => n * n);
        }
        [TestMethod()]
        public void DivTest()
        {
            RomanNumber a = new RomanNumber(1);
            RomanNumber b = new RomanNumber(500);
            RomanNumber c = new RomanNumber(1000);
            RomanNumber d = new RomanNumber(3999);
            RomanNumber n = null;

            RomanNumber result = new RomanNumber(2);

            Assert.AreEqual(result.ToString(), (c / b).ToString());
            Assert.ThrowsException<RomanNumberException>(() => a / d);
            Assert.ThrowsException<RomanNumberException>(() => n / c);
            Assert.ThrowsException<RomanNumberException>(() => c / n);
            Assert.ThrowsException<RomanNumberException>(() => n / n);
        }
        [TestMethod()]
        public void CloneTest()
        {
            RomanNumber a = new RomanNumber(1234);
            RomanNumber b = (RomanNumber)a.Clone();

            Assert.AreEqual(a.ToString(), b.ToString());
            Assert.AreNotSame(a, b);
        }
        [TestMethod()]
        public void CompareTest()
        {
            RomanNumber a = new RomanNumber(1234);
            RomanNumber b = new RomanNumber(3210);
            RomanNumber c = null;

            Assert.IsTrue(a.CompareTo(b) > 0);
            Assert.IsTrue(b.CompareTo(a) < 0);
            Assert.IsTrue(a.CompareTo(a) == 0);

            Assert.ThrowsException<RomanNumberException>(() => b.CompareTo(c));
        }
    }
}