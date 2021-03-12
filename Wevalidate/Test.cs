using LanguageExt;
using Xunit;

namespace ClassLibrary1
{
    public class Test
    {
        [Fact]
        public void TestSomething()
        {

            string validGuid = "43c3ff9a-6fcf-4ae9-959d-fe9ed6c38ab8";
            Either<string, Id> validation = Id.Validate(validGuid);
            
            Assert.True(validation.IsRight);
        }
        
    }
}