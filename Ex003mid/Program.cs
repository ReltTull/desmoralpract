int [] array = new int [10];
int index = 0;
while (index < 10)
{
    array[index] = new Random().Next(10,100);
    index++;
}

index = 0;

while (index < 10)
{
    Console.Write(array[index] + " ");
    index++;
}

Console.WriteLine();
index = 0;
while (index < 10)
{
    if (array[index] % 2 == 0)
    {
        Console.Write(array[index] + " ");
    }
    index++;
}
