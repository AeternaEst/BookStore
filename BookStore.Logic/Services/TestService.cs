using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Logic.Services
{
    public class TestService : ITestService
    {
        public string GetMessage()
        {
            return "Hello World";
        }
    }
}
