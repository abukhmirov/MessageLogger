namespace MessageLogger.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Message_Constructor_MessageIsCreatedWithCorrectContent()
        {
            DateTime now = DateTime.Now;
            Message message = new Message("Test");
            Assert.Equal("Test", message.Content);
        }
        
       
    }
}