using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Tests
{
    public static class UnitTestFunctionTests
    {
        //Naming Conventions - ClassName_methodName_ExpectedResult
        public static void UnitTestFunction_ReturnsSomethingIfZero_ReturnsString()
        {
            try
            {
                //Arrange - Go get your variables, whatever you need, your classes, your funcitons
                int num = 0;

                UnitTests.UnitTestFunction worldsDumbest = new UnitTests.UnitTestFunction();
                //Act -Execute this function
                string result = worldsDumbest.ReturnsSomethingIfZero(num);

                //Assert - Whatever is returned is it what you want 
                if (result == "Something")
                {
                    Console.WriteLine("PASSED: UnitTestFunction.ReturnsSomethingIfZero_ReturnsString");
                }
                else
                {
                    Console.WriteLine("FAILED: UnitTestFunction.ReturnsSomethingIfZero_ReturnsString");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
