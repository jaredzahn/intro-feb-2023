namespace Demo1.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            
        }

        [Fact]
        public void CanAddTwoNumbers()
        {
            //Given (Arrange)
            int a = 10, b = 20, c;
            //When (Act)
            c = a + b;
            //Then (Assert)
            Assert.Equal(30, c);
        }
    }
}