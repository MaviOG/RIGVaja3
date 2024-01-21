using NUnit.Framework;
using RIGProjeck.Class;
namespace ProjectTest
{
    public class NepremièninaTest
    {
        private Nepremiènina _checkSuperUserTrue { get; set; } = null;
        private Nepremiènina _checkSuperUserFalse { get; set; } = null;
        private Nepremiènina _checkNepremèninaid { get; set; } = null;
        private Obvesèanje _UserOnListTrue { get; set; } = null;
        private Obvesèanje _UserOnListFalse { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _checkSuperUserTrue = new Nepremiènina();
            _checkSuperUserFalse = new Nepremiènina();
            _checkNepremèninaid = new Nepremiènina();
            
            _UserOnListTrue = new Obvesèanje();
            _UserOnListFalse = new Obvesèanje();
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
        public void _NepremièninaID()
        {
            //Assign
           
            //Act
            int value = _checkNepremèninaid.CheckId(33);
            int value2 = _checkNepremèninaid.CheckId(55);
            //Assert
            Assert.AreEqual(value,350000);
            Assert.AreEqual(value2, 78000);
        }
        
    }
}