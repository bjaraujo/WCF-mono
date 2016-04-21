using System;

namespace WcfMonoService
{
    public class MyService : IMyService
    {
        public string GetData()
        {
            return "Hello WCF over MONO";
        }
    }
}

