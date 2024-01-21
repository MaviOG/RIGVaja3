using NUnit.Framework;
using RIGProjeck.Class;
namespace ProjectTest
{
    public class Nepremi�ninaTest
    {
        private Nepremi�nina _checkSuperUserTrue { get; set; } = null;
        private Nepremi�nina _checkSuperUserFalse { get; set; } = null;
        private Nepremi�nina _checkNeprem�ninaid { get; set; } = null;
        private Obves�anje _UserOnListTrue { get; set; } = null;
        private Obves�anje _UserOnListFalse { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _checkSuperUserTrue = new Nepremi�nina();
            _checkSuperUserFalse = new Nepremi�nina();
            _checkNeprem�ninaid = new Nepremi�nina();
            
            _UserOnListTrue = new Obves�anje();
            _UserOnListFalse = new Obves�anje();
        }

        [Test]
        public void check_SuperUse_TrueTest()
        {
            //Assign

            //Act
            bool value = _checkSuperUserTrue.check_SuperUser(1);
            //Assert
            Assert.IsTrue(value);
        }
        [Test]
        public void check_SuperUse_TrueFalse()
        {
            //Assign

            //Act
            bool value = _checkSuperUserTrue.check_SuperUser(2);
            //Assert
            Assert.IsFalse(value);
        }
        [Test]
        public void _UserOnListTestTrue()
        {
            //Assign

            //Act
            bool value = _UserOnListTrue.IsUserOnList(1);
            //Assert
            Assert.IsTrue(value);
        }
        [Test]
        public void _UserOnListTestFalse()
        {
            //Assign

            //Act
            bool value = _UserOnListFalse.IsUserOnList(0);
            //Assert
            Assert.IsFalse(value);
        }
        [Test]
        public void _Nepremi�ninaID()
        {
            //Assign
           
            //Act
            int value = _checkNeprem�ninaid.CheckId(33);
            int value2 = _checkNeprem�ninaid.CheckId(55);
            //Assert
            Assert.AreEqual(value,350000);
            Assert.AreEqual(value2, 78000);
        }
        
    }
}