using NewsProject.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Xunit;

namespace NewsProject.Tests
{
    class HomeControllerTests
    {
        [Fact]
        public void IndexxViewDataMessage()
        {
            //Arrage
            HomeController controller = new HomeController();

            //act
            ViewResult result = controller.Index() as ViewResult;

            
        }
    }
}
