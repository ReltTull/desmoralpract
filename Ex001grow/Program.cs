// Есть массив, заполненный генерируемыми числами [10, 100). Создать на его основе массив, отбрасывающий элементы,
// нарушающие порядок возрастания

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
Console.Write(array[0]);
index = 1;
int min = array[0];
while (index < 10)
{
    if (array[index] > min)
    {
        Console.Write(" " + array[index]);
        min = array[index];
    }
    index++;
}











// Не относится к дз. Косячные версии, над которыми можно подумать

// int [] array = { 2, 5, 3, 8, 9};
// int AL = array.Length;
// int index = 1;
// Console.Write(array[0]);
// while (index < AL)
// {
//     if (array[index] > array[index - 1])
// {
//     Console.Write(" " + array[index]);
// }
// index++;
// }



// int [] array = { 2, 5, 3, 8, 9};
// int AL = array.Length;
// int index = 1;
// int index2 = 1;
// int [] array2 = new int []{};
// array2[0] = array[0];
// while (index < AL)
// {
//     if (array[index] > array[index - 1])
// {
//     array2[index2] = array[index];
// }
// index++;
// index2++;
// }
// System.Console.WriteLine(array2);
