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


