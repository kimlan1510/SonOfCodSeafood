using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using SonOfCodSeafood.Models;
using SonOfCodSeafood.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace SonOfCodSeafood.Tests.ControllerTests
{
    public class NewsLetterControllerTest
    {
        [Fact]
        public void Get_Index_View_Test()
        {
            //Arrange
            NewsLetterController controller = new NewsLetterController();
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);
        }
    }
}
