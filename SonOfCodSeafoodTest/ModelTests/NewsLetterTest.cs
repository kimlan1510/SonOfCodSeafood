using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using SonOfCodSeafood.Models;
using Xunit;

namespace SonOfCodSeafoodTests.ModelTests
{
    public class NewsLetterTest
    {
        [Fact]
        public void GetEmailTest()
        {
            //Arrange
            var email = new NewsLetter();
            email.Email = "kimlan@kimlan.com";
            //Act
            var result = email.Email;

            //Assert
            Assert.Equal("kimlan@kimlan.com", result);
        }
    }
}