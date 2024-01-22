using NUnit.Framework;
using RIGProjeck.Class;
namespace ProjectTest
{
    public class UserTest
    {
        private User _checkLogIn { get; set; } = null;
        private User _checkSVerifyUser { get; set; } = null;
        private User _checkRegister { get; set; } = null;
        private Nepremičnina _checkBoostProperty { get; set; } = null;
        private Nepremičnina _checkRemoveBoost { get; set; } = null;
        private Nepremičnina _checkLoadUserAds { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _checkLogIn = new User();
            _checkSVerifyUser = new User();
            _checkRegister = new User();

            _checkBoostProperty = new Nepremičnina();
            _checkRemoveBoost = new Nepremičnina();
            _checkLoadUserAds = new Nepremičnina();
        }

        [Test]
        public void _check_LogIn_Test()
        {
            //Assign

            //Act
            string value = _checkLogIn.check_LogIn("123", "123");
            //Assert
            Assert.That("123", Is.EqualTo(value));
        }
        [Test]
        public void _check_Register_Test()
        {
            //Assign

            //Act
            bool value = _checkRegister.check_Register("test","test");
            //Assert
            Assert.IsTrue(value);
        }
        [Test]
        public void _User_Verify_Test()
        {
            //Assign

            //Act
            bool value = _checkSVerifyUser.check_VerifyUser("123");
            //Assert
            Assert.IsTrue(value);
        }
        [Test]
        public void _CheckBoostProperty()
        {
            //Assign

            //Act
            bool value = _checkBoostProperty.BoostPropertyCheck(66);
            bool value2 = _checkBoostProperty.BoostPropertyCheck(11);
            //Assert
            Assert.AreEqual(value, true);
            Assert.AreEqual(value2, true);
        }
        [Test]
        public void _CheckLoadUserAds()
        {
            //Assign
           
            //Act
            int value = _checkLoadUserAds.LoadUserAdsCheck(3);
            int value2 = _checkLoadUserAds.LoadUserAdsCheck(7);
            //Assert
            Assert.AreEqual(value,9);
            Assert.AreEqual(value2, 10);
        }
        
    }
}