namespace GA_CustomList_Ronda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Custom List Class Example");

            // Test code
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Hello");
            myList.AddAtIndex("World", 1);
            myList.Add("Good night");
            myList.Add("Moon");
            myList.AddAtIndex("Star", 2);

            // Print List
            for (int i = 0, imax = myList.Count; i < imax; i++)
            {
                Console.WriteLine($"{myList.GetItem(i)}");
            }
            Console.WriteLine($"Count: {myList.Count}");
            Console.WriteLine();

            // Test GetItem
            Console.WriteLine($"{myList.GetItem(0)}"); // Hello
            Console.WriteLine();

            // Test Remove
            myList.Remove("Star");

            // Print List
            for (int i = 0, imax = myList.Count; i < imax; i++)
            {
                Console.WriteLine($"{myList.GetItem(i)}");
            }
            Console.WriteLine($"Count: {myList.Count}");
            Console.WriteLine();

            // Test increase capacity
            myList.Add("Bonjour");
            myList.Add("tout le monde");
            myList.Add("Bonne nuit");
            myList.Add("Stella");
            myList.Add("Stern");
            myList.Add("Estrella");
            myList.Add("Sol");
            myList.Add("Parapluie");

            // Print List
            for (int i = 0, imax = myList.Count; i < imax; i++)
            {
                Console.WriteLine($"{myList.GetItem(i)}");
            }
            Console.WriteLine($"Count: {myList.Count}");
            Console.WriteLine();

        }

    }
}
