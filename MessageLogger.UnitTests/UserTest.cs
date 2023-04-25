namespace MessageLogger.UnitTests
{
    public class UserTest
    {
        [Fact]
        public void User_Constructor_UserCreatedCorrectly()
        {
            var John = new User("John", "Johnny");
            Assert.Equal("John", John.Name);
            Assert.Equal("Johnny", John.Username);
            Assert.Equal(new List<Message>(), John.UserMessages);
        }
        [Fact]
        public void User_AddMessageToList()
        {
            var userTested = new User("Tester", "tester");
            var messageTest = new Message("Hello");
            userTested.AddMessagetoList(messageTest);

        }
    }
}
