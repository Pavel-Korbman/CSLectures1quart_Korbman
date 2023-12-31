﻿// Двумерный массив с текстовыми данными 2 строки, 5 столбцов
// string[,] table = new string[2, 5];
// Нумерация в двумерном массиве - как в одномерном строки и столбцы с нуля 
// table[0,0] table[0,1] ... table[0,4] - столбцы
// table[0,0] ... table[1,4] - строки
// String.Empty - инициализация для пустых строк по умолчанию

// table[1, 2] = "Слово";

// for(int rows =0; rows < 2; rows++) // Распечатать 2 мерный массив
// {
//   for(int columns =0; columns < 5; columns++)
//   {
//      Console.WriteLine($"-{table[rows, columns]}-");
//   }
// }

// Двумерный массив с целочисленными данными 3 строки, 5 столбцов
// int[,] matrix = new int[3, 5];

// for(int i =0; i < 3; i++) // Распечатать 2 мерный массив
// {
//   for(int j =0; j < 5; j++)
//   {
//      Console.WriteLine(matrix[i, j]); // Console.Write(matrix[i, j]); что бы элементы строки в строку
//   }
// }


// Способ вывода на печать прямоугольником:

// int[,] matrix = new int[3, 5];

// for(int i =0; i < matrix.GetLength(0); i++) // for(int i =0; i < 3; i++)
// {
//   for(int j =0; j < matrix.GetLength(1); j++) //for(int j =0; j < 5; j++)
//   {
//      Console.Write($"{matrix[i, j]} ");
//   }
// Console.WriteLine();
// }



// Метод для вывода массива на печать:

// void PrintArray(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//       Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }



// Метод для заполнения массива случайными данными:

// void FillArray(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//     matr[i, j] = new Random().Next(1, 10);
//     }
//   }
// }


// int[,] matrix = new int[3, 5];

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine(); // Для отступа между таблицами при печати
// PrintArray(matrix);


// РИСОВАНИЕ

// Задаём массив "Лайк" нарисованный единицами:

// int[,] pic = new int[,]
// {
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//     {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//     {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//     {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// // Метод печати контура плюсами:

// void PrintImage(int[,] image)
// {
//  for (int i = 0; i < image.GetLength(0); i++)
//   {
//     for (int j = 0; j < image.GetLength(1); j++)
//     {
//       if (image[i,j]==0) Console.Write($" ");
//       else Console.Write($"+");
//     }
//     Console.WriteLine();
//   } 
// }
// // PrintImage(pic);


// // Метод закрашивания изображения плюсами:

// void FillImage(int row, int col)
// {
//   if (pic[row, col] == 0)
//   {
//     pic[row, col] = 1;
//     FillImage(row-1, col); // РЕКУРСИЯ (Метод вызывает сам себя)
//     FillImage(row, col-1);
//     FillImage(row+1, col);
//     FillImage(row, col+1);
//   }
// }

// PrintImage(pic);
// FillImage(13, 13);
// PrintImage(pic);


// // Метод вычисления факториала с рекурсией:


// double Factorial (int n)
// {
//   if (n==1) return 1;
//   else return n* Factorial(n-1);
// }

// for (int i=1; i<20; i++)
// {
// Console.WriteLine($"{i}!= {Factorial (i)}");
// }

// Вычисление чисел Фибоначи: f(1)=1, f(2)=1, f(n) = f(n-1) + f(n-2)

double Fibonacci(int n)
{
  if(n==1 || n==2) return 1;
  else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i=1; i<50; i++)
{
Console.WriteLine($"F{i}= {Fibonacci(i)}");
}