using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SonOfCodSeafood.Models;
using Xunit;

namespace SonOfCodSeafood.Tests.ModelTests
{
    public class NewsLetterTest
    {
        [Fact]
        public void GetEmailTest()
        {
            //Arrange
            var newsLetter = new NewsLetter();
            newsLetter.Email = "kimlan@kimlan";
            //Act
            var result = newsLetter.Email;

            //Assert
            Assert.Equal("kimlan@kimlan", result);
        }
    }
}
