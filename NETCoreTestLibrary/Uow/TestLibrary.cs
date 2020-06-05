using System;
using System.Configuration;

namespace NETCoreTestLibrary
{
    public class TestLibrary:ITestLibrary
    {
        public void LoadAppSettings(string name)
        {
            string serachPattern =
            ConfigurationManager.AppSettings["Name"];
        }
    }
}
