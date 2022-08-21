// Задача №34

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input size: ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// int min = 100;
// Console.WriteLine("Input max: ");
// int max = int.Parse(Console.ReadLine() ?? "0");
// int CountPosNumber = 0;
// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         CountPosNumber ++;
//     }

// }
// Console.WriteLine(CountPosNumber);


// Задача №36

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input size: ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Input min: ");
// int min = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Input max: ");
// int max = int.Parse(Console.ReadLine() ?? "0");
// int sum = 0;
// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// for (int i = 1; i < array.Length; i+=2)
// {
//     if (array[i] % 2 != 0)
//     {
        
//         sum = sum + array[i];
        
//     }
    
// }
// Console.WriteLine(sum);


// Задача №38


// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input size: ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Input min: ");
// int min = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Input max: ");
// int max = int.Parse(Console.ReadLine() ?? "0");
// int difference = 0;
// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// for (int i = 0; i < array.Length; i++)
// {
//      difference = max - min;
// }
// Console.WriteLine("The difference between the maximum and minimum value = " + difference);
