// / 23. Показать таблицу квадратов чисел от 1 до N
// // void Pow2(int n)
// // {
// //     for (int i = 1; i <= n; i++)
// //     {
// //         Console.WriteLine($"{i}^2 = {i * i}");
// //         // Console.WriteLine($"{i}^2 = {Math.Pow(i,2)}");
// //     }
// // }
// // Pow2(8);

// // 24. Найти кубы чисел от 1 до N

// // void Pow(int n)
// // {
// //     for (int i = 1; i <= n; i++)
// //     {
// //         Math.Pow(i,3);
// //         Console.WriteLine(Math.Pow(i,3));
// //     }
// // }
// // Pow(5);

// // 25. Найти сумму чисел от 1 до А

// // int SummNumb(int n)
// // {
// //     int sum = 0;
// //     for(int i =1; i <=n; i++)
// //     {
// //         sum = sum + i;
// //         Console.WriteLine(sum);
// //     }
// //     return sum;
// // }
// // SummNumb(4);

// 26. Возведите число А в натуральную степень B используя цикл

// int Pow(int a, int b)
// {
//     int temp = a;
//     for (int i = 1; i < b; i++)
//     {
//         temp = a * temp;
//     }
//     return temp;
// }
// Console.WriteLine(Pow(5,4));

// 27. Определить количество цифр в числе

// int ost(int a)
// {
//     int temp = 0;
//     while(a != 0)
//     {
//         int res = a % 10;
//         temp++;
//         a = a / 10;
//     }
//     return temp;
// }
// Console.WriteLine(ost(12));

// 28. Подсчитать сумму цифр в числе

// int ost(int a)
// {
//     int sum = 0;
//     while(a != 0)
//     {
//         int res = a % 10;
//         sum = res + sum;
//         a = a / 10;
//     }
//     return sum;
// }             
// Console.WriteLine(ost(122));

// 29. Написать программу вычисления произведения чисел от 1 до N

// int SummNumb(int n)
// {
//     int sum = 1;
//     for(int i =1; i < n; i++)
//     {
//         sum = sum * (i + 1);
//     }
//     return sum;
// }
// Console.WriteLine (SummNumb(5));

// // 30. Показать кубы чисел, заканчивающихся на четную цифру (доделать!!!!)

// int SummNumb(int arg1, int arg2)
// {
//     int a = 0;
//     while (arg1 < arg2)
//     {
//         if (arg1 % 2 == 0)
//         {
//             a = arg1 * arg1 * arg1;
//             arg1++;
//         }
//         else
//         {
//             arg1++;
//         }
//     }
//     return a;
// }
// Console.WriteLine(SummNumb(1, 10));    

// 31. Задать массив из 8 элементов и вывести их на экран

//int[] CreateArray(int count)
// {
//     return new int[count];
// }
// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// void FillArray(int[] array, int min, int max)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
// }
// int [] arr = CreateArray(8);
// FillArray(arr,1,10);
// Console.WriteLine(PrintArray(arr));

// //32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// int [] arr = CreateArray(8);
// FillArray(arr,0,1);
// Console.WriteLine(PrintArray(arr));

// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

// int[] CreateArray(int count)
// {
//     return new int[count];
// }
// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// void FillArray(int[] array, int min, int max)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
// }
// int[] A = CreateArray(12);
// FillArray(A,-9,9);
// Console.WriteLine(PrintArray(A));

// string Sum(int[] arr)
// {
//     int sumPlus = 0;
//     int sumMinus = 0;
//     for (int i=0;i<arr.Length;i++)
//     {
//         if(arr[i]>0)
//         {
//             sumPlus = sumPlus + arr[i];
//         }
//         if(arr[i]<0)
//         {
//             sumMinus = sumMinus + arr[i];
//         }
//     }
// return $"сумма положительных чисел = {sumPlus}, сумма отрицательных чисел = {sumMinus}";
// }
// Console.WriteLine(Sum(A));

// 34. Написать программу замену элементов массива на противоположные

// int[] CreateArray(int count)
// {
//     return new int[count];
// }
// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// void FillArray(int[] array, int min, int max)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
// }

// void rep(int [] array)
//  {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = -array[i];
//     }
// }
// int [] A = CreateArray(9);
// FillArray(A,-10,10);
// Console.WriteLine(PrintArray(A));
// rep(A);
// Console.WriteLine(PrintArray(A));

// 35. Определить, присутствует ли в заданном массиве, некоторое число

// int[] CreateArray(int count)
// {
//     return new int[count];
// }
// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// void FillArray(int[] array, int min, int max)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
// }
// bool number(int [] array, int x)
// {
//     bool res = false;
//     for(int i =0; i<array.Length; i++)
//     {
//     if(array[i] == x)
//     {
//         res = true;
//         break;
//     }
// }
// return res;
// }
// int [] B = CreateArray(12);
// FillArray(B,0,10);
// Console.WriteLine(PrintArray(B));
// Console.WriteLine(number(B,5));

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// string oddNum(int [] array)
// {
//     int odd = 0;
//     int even = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 ==0)
//         {
//             odd = odd +1;
//         }
//         if(array[i] % 2 !=0)
//         {
//             even = even +1;
//         }
//     }
// return $"количество четных: {odd}, колличество нечетных: {even}";
// }
// Console.WriteLine(oddNum(B));

// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// int findNum(int [] array)
// {
//     int count = 0;
//     for(int i =0; i < array.Length;i++)
//     {
//         if(10<array.Length && array.Length >99)
//         {
//             count = count + 1;
//         }
//     }
// return count;    
// }
// Console.WriteLine(findNum(B));

// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// int sumArr(int [] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array.Length % 2 ==0)
//         {
//             sum = sum + array[i];
//         }
//     }
// return sum;
// }
// Console.WriteLine(sumArr(B));
// Console.WriteLine(SummNumb(1, 10));  

// 39. Найти произведение пар чисел в одномерном массиве. 
/////////////////////Парой считаем первый и последний элемент, второй и предпоследний и т.д./////////////////////////////

// string FindProductPairs (int[] array)
// {
//     string res = String.Empty;
//     int result = 0;
//     int last = array.Length - 1;
//     for (int i = 0; i < array.Length / 2; i++, last--)
//     {
//         result = array[i] * array[last];
//         res += $"{result} ";
//     }
//     return res;
// }
// Console.WriteLine(FindProductPairs(B));

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом.
// int[] CreateArray(int count)
// {
//     return new int[count];
// }
// string PrintArray(int[] array)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }
// void FillArray(int[] array, int min, int max)
// {
//     string res = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
// }
// string difference(int[] array)
// {
//     int max = 0;
//     int min = array[1];
//     int diff = 0;
//     for(int i=1; i < array.Length;i++)
//     {
//         if(array[i] > max)
//         {
//             max = array[i];
//         }
//         if(array[i]<min)
//         {
//             min = array[i];
//         }
//         diff = max - min;   
//     }
//     return $"максимальное: {max}, минимальное: {min}, разница: {diff}";
// }
// int[] B = CreateArray(10);
// FillArray(B,10,100);
// Console.WriteLine(PrintArray(B));
// Console.WriteLine(difference(B));

