namespace PracticeProblem4B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 2, 3, 4, 6, 7, 8, 9, 5 };

          /*  DuplicateCount DC = new DuplicateCount();
            int duplicateCount = DC.CountDuplicate(array);


            Console.WriteLine("Total number of duplicate elements: " + duplicateCount);   */

            UniqueElement UE = new UniqueElement();
            UE.PrintUniqueElements(array);
            Console.ReadLine();
        }
    }
}