namespace PracticeProblem4B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 3, 4, 5, 6, 4, 3, 9, 6, 7 };

            DuplicateCount DC = new DuplicateCount();
            int duplicateCount = DC.CountDuplicate(array);


            Console.WriteLine("Total number of duplicate elements: " + duplicateCount);
            Console.ReadLine();
        }
    }
}