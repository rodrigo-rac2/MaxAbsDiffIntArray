using System;
using System.Linq;

class Difference
{
    private int[] elements;
    public int maximumDifference;

    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        int tempMax = 0;
        for (int i = 0; i < elements.Count(); i++)
        {
            for (int j = 0; j < elements.Count(); j++)
            {
                int absDiff = Math.Abs(elements[i] - elements[j]);
                if ((j != i) && (absDiff > tempMax))
                    tempMax = absDiff;
            }
        }
        this.maximumDifference = tempMax;
    }
} // End of Difference Class

class Program
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}