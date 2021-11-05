// Есть массив, заполненный генерируемыми числами [10, 100). Создать на его основе массив, отбрасывающий элементы,
// больше среднего арифметического

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
int sum = 0;
while (index < 10)
{
    sum = sum + array[index];
    index++;
}
Console.WriteLine(sum);

