int[] array = new int[8];
FillArray(array);

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
       array[i] = new Random().Next(0, 100); // Задан диапозон цифр для массива
    }
}
void PrintArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write ($"{array[i]} ");
    }
}

PrintArray(array);