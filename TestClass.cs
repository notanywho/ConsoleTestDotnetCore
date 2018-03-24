using System;

namespace ConsoleTest
{
    class TestClass
    {
        public string TestProp {get; set;}
        public int TestInteger {get; set;}
       
       public TestClass(){
           TestProp = "small elephant";
           TestInteger = 12;

       }

       public string GetText(){
           return $"The test text is: {this.TestInteger} and {this.TestProp}";
       }
    }
}
