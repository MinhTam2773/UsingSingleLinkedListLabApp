using UsingSingleLinkedListLab;

namespace Testing
{
    [TestFixture]
    public class Testing
    {
        [Test]
        public void AddNodesToTheBegining()
        {
            SingleLinkedList<string> people = new SingleLinkedList<string>();

            double expectedCount = people.Count + 3;

            people.AddFirst("John Smith");
            people.AddFirst("Joe Schmoe");
            people.AddFirst("Joe Blow");

            double actualCount = people.Count;
            string firstPerson = people.GetValue(0);

            Assert.That(actualCount, Is.EqualTo(expectedCount));
            Assert.That(firstPerson, Is.EqualTo("Joe Blow"));
        }

        [Test]
        public void AddNodesToTheEnd()
        {
            SingleLinkedList<string> people = new SingleLinkedList<string>();

            double expectedCount = people.Count + 3;

            people.AddLast("Bob Bobberson");
            people.AddLast("Sam Sammerson");
            people.AddLast("Dave Daverson");

            double actualCount = people.Count;
            string lastPerson = people.GetValue(people.Count - 1);

            Assert.That(actualCount, Is.EqualTo(expectedCount));
            Assert.That(lastPerson, Is.EqualTo("Dave Daverson"));
        }

        [Test]
        public void RemovingFirstNode()
        {
            SingleLinkedList<string> people = new SingleLinkedList<string>(); 

            people.AddFirst("John Smith");
            people.AddFirst("Joe Schmoe");
            people.AddFirst("Joe Blow");

            double expectedCount = people.Count - 1;

            people.RemoveFirst();

            //After remove "Joe Blow"
            double actualCount = people.Count;
            string firstPerson = people.GetValue(0);

            Assert.That(actualCount, Is.EqualTo(expectedCount));
            Assert.That(firstPerson, Is.EqualTo("Joe Schmoe"));
        }

        [Test]
        public void RemovingLastNode()
        {
            SingleLinkedList<string> people = new SingleLinkedList<string>();

            people.AddLast("Bob Bobberson");
            people.AddLast("Sam Sammerson");
            people.AddLast("Dave Daverson");

            double expectedCount = people.Count - 1;

            people.RemoveLast();

            //After remove "Dave Daverson"
            double actualCount = people.Count;
            string lastPerson = people.GetValue(people.Count - 1);

            Assert.That(actualCount, Is.EqualTo(expectedCount));
            Assert.That(lastPerson, Is.EqualTo("Sam Sammerson"));
        }

        [Test]
        public void RetrivingValueOfANode()
        {
            SingleLinkedList<string> people = new SingleLinkedList<string>();

            people.AddFirst("John Smith");
            people.AddFirst("Joe Schmoe");
            people.AddFirst("Joe Blow");

            string expected = "Joe Schmoe";
            string actual = people.GetValue(1); //get "Joe Schmoe"

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void DetermineTheSizeOfTheList() 
        {
            SingleLinkedList<string> people = new SingleLinkedList<string>();

            people.AddFirst("John Smith");
            people.AddFirst("Joe Schmoe");
            people.AddFirst("Joe Blow");
            people.AddLast("Jane Doe");
            people.AddLast("Bob Bobberson");
            people.AddLast("Sam Sammerson");
            people.AddLast("Dave Daverson");

            int expectedCount = 7;
            int actualCount = people.Count;

            Assert.That(actualCount, Is.EqualTo(expectedCount));
        }

        [Test]
        public void RetrivingAndRemovingFromEmptyList()
        {
            SingleLinkedList<string> emptyList = new SingleLinkedList<string>();

            Assert.Throws<Exception>(() => emptyList.GetValue(0));
            Assert.Throws<Exception>(() => emptyList.RemoveFirst());
            Assert.Throws<Exception>(() => emptyList.RemoveLast());
        }
    }
}
