using BuildApp.Modules;
using Xunit;

namespace webtest
{
    public class webtest
    {
        [Fact]
        public void demotest()
        {
            int i = 1;
            bool result = false;
            if (i == 1) result = true;
            Assert.True(result, "Value should be equal to 1");

        }
        [Fact]

        public void CheckAddFunctions()
        {
            Functions func = new Functions();
            int y = func.Add(3, 2);
            bool result = false;

            if (y == 5) result = true;
            Assert.True(result, "Value should be equal to 5");

        }
    }
}