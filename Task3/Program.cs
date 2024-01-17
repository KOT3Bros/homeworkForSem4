// Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
// Пример
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    return array;
}

int[] CreateReverseArray(int size, int[] array)
{
    int[] reverseArray = new int[size];
    for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
    {
        reverseArray[i] = array[j];

    }
    return reverseArray;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
int[] reverseArray = CreateReverseArray(size, array);
Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");
Console.WriteLine($"Перевёрнутый массив: [ {string.Join("; ", reverseArray)} ]");