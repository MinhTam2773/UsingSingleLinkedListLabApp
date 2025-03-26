namespace UsingSingleLinkedListLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<string> people = new SingleLinkedList<string>();
            people.AddFirst("Joe Blow");
            people.AddLast("Joe Schmoe");
            people.AddLast("John Smith");
            people.AddLast("Jane Doe");
            people.AddLast("Bob Bobberson");
            people.AddLast("Sam Sammerson");
            people.AddLast("Dave Daverson");

            Console.WriteLine(RemovingFirstNode(people));
        }

        static void P(SingleLinkedList<string> list)
        {
            Node<string> current = list.Head;
            while (list.Count > 0 && current != null) 
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        public static bool RemovingFirstNode(SingleLinkedList<string> people)
        {
            double expectedCount = people.Count - 1;

            people.RemoveFirst();

            double actualCount = people.Count;
            bool success = false;

            bool firstCheck = people.Head!.Value == "Joe Schmoe" ? true : false;

            if (firstCheck && (expectedCount == actualCount))
            {
                success = true;
            }

            return success;
        }
    }
}
