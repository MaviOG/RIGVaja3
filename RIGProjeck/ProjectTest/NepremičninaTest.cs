using NUnit.Framework;
using RIGProjeck.Class;
namespace ProjectTest
{
    public class NepremičninaTest
    {
        private Nepremičnina _checkSuperUserTrue { get; set; } = null;
        private Nepremičnina _checkSuperUserFalse { get; set; } = null;
        private Nepremičnina _checkNepremèninaid { get; set; } = null;
        private Obvesčanje _UserOnListTrue { get; set; } = null;
        private Obvesčanje _UserOnListFalse { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _checkSuperUserTrue = new Nepremičnina();
            _checkSuperUserFalse = new Nepremičnina();
            _checkNepremèninaid = new Nepremičnina();
            
            _UserOnListTrue = new Obvesčanje();
            _UserOnListFalse = new Obvesčanje();
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
        public void _NepremičninaID()
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