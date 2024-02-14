Console.WriteLine("-----------(Greatest and Smallest Height of 30 values)------------");
float[] StoredHeights = new float[30];
float totalSum = 0;
float totalMean;
Console.WriteLine("Enter the height of the person");
for (int Counter = 0; Counter <= 29; Counter++)
{
    Console.WriteLine($"Enter the {Counter + 1}st height");
    StoredHeights[Counter] = Convert.ToSingle(Console.ReadLine());
    totalSum += StoredHeights[Counter];
}

float GreatestHeight = StoredHeights.Max();
float SmallestHeight = StoredHeights.Min();
totalMean = totalSum / 30;

Console.WriteLine("Greatest height is [" + GreatestHeight + "]");
Console.WriteLine("Smallest height is [" + SmallestHeight + "]");
Console.WriteLine("The sum of all is [" + totalSum + "]");
Console.WriteLine("The mean is [" + totalMean + "]");
