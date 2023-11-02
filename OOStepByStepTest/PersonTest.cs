namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class PersonTest
    {
        [Theory]
        [InlineData("Tom", 21, "My name is Tom. I am 21 years old")]
        public void Should_introduce_person_when_self_introduce_given_person(string personName, int age, string expectMsg)
        {
            Person person = new Person(personName, age);
            string msg = person.SelfIntroduce();

            Assert.Equal(msg, expectMsg);
        }
    }
}
