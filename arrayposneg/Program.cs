int [] array = new int [12];
for(int i=0;i<array.Length;i++)
{
    array [i] = new Random().Next(-9,10);
    Console.Write($"{array[i]}, ");
}

int sumPos = 0;
int sumNeg = 0;

for (int i=0;i<array.Length;i++)
{
    if (array [i] > 0) 
    {
        sumPos = sumPos + array [i];
    }
    else
    {
        sumNeg = sumNeg + array [i];
    }
}
Console.WriteLine();
Console.WriteLine($"Sum of positive numbers in array is {sumPos}, of negative is {sumNeg}");