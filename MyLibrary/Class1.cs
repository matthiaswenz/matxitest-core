using System;
using Newtonsoft.Json;

namespace MyLibrary
{
    public class Class1
    {
        public Class1() {
            string json = "{}";

            Object o = JsonConvert.DeserializeObject<Object>(json);
            
            throw new AccessViolationException();
        }
    }
}
