// Дан список некоторых целых чисел, найдите значение 20 в нем и, если оно присутствует, замените его на 200. 
// Обновите список только при первом вхождении числа 20. (можно использовать List<integer> )
// [21, 53,20, 56, 45,20] -> [21, 53,200, 56, 45,20]

int[] arr = {21, 53, 20, 56, 45, 20};
int find = 20;
int index = 0;
int n = arr.Length;

   while (index < n)
  {
    if (arr[index] == find)
    {
        arr[index] = 200;
        Console.WriteLine("Номер элемента: " + index);
        break;
    }
    index++;
    }
    index++;
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i]+ " ");