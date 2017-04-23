using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortScores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortScores.Tests
{
    [TestClass()]
    public class PersonTests
    {
        [TestMethod()]
        public void getFirstNameTest()
        {
            Person p = new Person("hishan", "de silva", 99);
            Assert.AreEqual("hishan", p.getFirstName());
        }

        [TestMethod()]
        public void setFirstNameTest()
        {
            Person p = new Person("hishan", "de silva", 99);
            if (p.setFirstName("krishan"))
            {
            }
            else
                Assert.Fail("First Name is not set.");
        }

        [TestMethod()]
        public void setLastNameTest()
        {
            Person p = new Person("hishan", "de silva", 99);
            if (p.setLastName("fernando"))
            {
            }
            else
                Assert.Fail("Last Name is not set.");
        }

        [TestMethod()]
        public void getLastNameTest()
        {
            Person p = new Person("hishan", "de silva", 99);
            Assert.AreEqual("de silva", p.getLastName());
        }

        [TestMethod()]
        public void setScoreTest()
        {
            Person p = new Person("hishan", "de silva", 99);
            if (p.setScore(100))
            {
            }
            else
                Assert.Fail("Score is not set.");
        }

        [TestMethod()]
        public void getScoreTest()
        {
            Person p = new Person("hishan", "de silva", 99);
            Assert.AreEqual(99, p.getScore());
        }
    }
}