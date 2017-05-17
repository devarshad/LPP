using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using LPP.APP.Model.Abstract;
using LPP.APP.Model.Domain;
using Moq;

namespace LPP.Test
{
    [TestFixture]
    class SignInFixture
    {
        Mock<ILPPUser> _repo = null;
        LPPUserBO _user = null;

        [SetUp]
        public void TestInit()
        {
            _repo = new Mock<ILPPUser>();
            _repo.Setup(m => m.SignInAsync("testvip", "Password1")).ReturnsAsync(true);
            _user = new LPPUserBO(_repo.Object);
        }

        [Test]
        public async Task Check_SignIn_Empty_UserName_And_Password()
        {
            var actual = await _user.SignInAsync("", "");

            Assert.AreEqual(SignInStatus.EmptyUserNameAndPassword, actual);
        }

        [Test]
        public async Task Check_SignIn_Empty_UserName()
        {
            var actual = await _user.SignInAsync("", "Password1");

            Assert.AreEqual(SignInStatus.EmptyUserName, actual);
        }

        [Test]
        public async Task Check_SignIn_Empty_Password()
        {
            var actual = await _user.SignInAsync("testvip", "");

            Assert.AreEqual(SignInStatus.EmptyPassword, actual);
        }

        [Test]
        public async Task Check_SignIn_Success()
        {
            var actual = await _user.SignInAsync("testvip", "Password1");

            Assert.AreEqual(SignInStatus.Success, actual);
        }

        [Test]
        public async Task Check_SignIn_Failure()
        {
            var actual = await _user.SignInAsync("test", "Password2");

            Assert.AreEqual(SignInStatus.Failure, actual);
        }
    }
}