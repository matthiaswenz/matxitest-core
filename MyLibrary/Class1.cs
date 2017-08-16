using System;

namespace MyLibrary
{
    public class Class1
    {
        public Class1() {
            throw new AccessViolationException();
        }
    }
}
