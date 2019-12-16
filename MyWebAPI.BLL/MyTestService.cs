using System;

namespace MyWebAPI.BLL
{
    public class MyTestService : IMyTestService
    {
        public string GetMyString()
        {
            return "Hello";
        }
    }
}
