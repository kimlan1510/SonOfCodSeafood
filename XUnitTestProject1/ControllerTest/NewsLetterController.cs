using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using SonOfCodSeafood.Controllers;

namespace XUnitTestProject1.ControllerTest
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
