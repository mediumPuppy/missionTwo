using System.Security.Cryptography.X509Certificates;
using System.Linq;

internal class Program
{
    
    private static void Main(string[] args)
    {
        
        System.Console.WriteLine("How many times would you like to roll the two dice? Only enter whole numbers...");
        int rolls = int.Parse(System.Console.ReadLine());

        // Line to separate the histogram from the input
        System.Console.WriteLine();

        // Declare array to be counted from
        double[] printArr = Roll(rolls);

        // write the lines
        for (int i = 2; i < printArr.Length; i++)
        {
            double divi = (printArr[i] / rolls) * 100;
            int myValue = (int)divi;
            string output = i + ": ";
            foreach (int x in Enumerable.Range(1, myValue))
            {
                output += "*"; 
            }
           System.Console.WriteLine(output);    
        }
    }

    public static double[] Roll(int pRolls)
    {
        // Use random number generator
        System.Random rnd = new System.Random();

        double[] myArray = new double[13];

        for (int i = 0; i < pRolls; i++)
        {
            // gather random dice in set
            int x = rnd.Next(1, 7);
            int y = rnd.Next(1, 7);

            int sum = x + y;

            myArray[sum] += 1;
        }

        return myArray;

}
}