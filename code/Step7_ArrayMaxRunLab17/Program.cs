int[] array = { 5, 32, 11, 52, 3, 17 };
int max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
         max = array[i];
    }
}

Console.WriteLine($"Массивчик как у богов: {string.Join(", ", array)}");
Console.WriteLine($"Максимальный профессиональный элемент: {max}");