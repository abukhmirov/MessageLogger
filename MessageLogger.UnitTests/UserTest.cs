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
        public void User_AddMessageToList_MessageAdded()
        {
            var userTested = new User("Tester", "tester");
            var messageTest = new Message("Hello");
            var messageTest2 = new Message("Hello2");
            userTested.AddMessagetoList(messageTest);
            Assert.Equal(messageTest, userTested.UserMessages[0]);
            Assert.Equal(messageTest2, userTested.UserMessages[1]);

        }
    }
}
