using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Xunit;
using MVCCore.BL;


namespace XUnitTestProject
{
    public class LoginTest1
    {
        [Fact]
        public void LTest1()
        {
            Assert.Equal("pass@1234", "pass@1234");
            
        }


        
 
    }
}
