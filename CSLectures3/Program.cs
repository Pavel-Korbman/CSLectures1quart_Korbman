// Двумерный массив с текстовыми данными 2 строки, 5 столбцов
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

void PrintArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
      Console.Write($"{matr[i, j]} ");
    }
    Console.WriteLine();
  }
}



// Метод для заполнения массива случайными данными:

void FillArray(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
  {
    for (int j = 0; j < matr.GetLength(1); j++)
    {
    matr[i, j] = new Random().Next(1, 10);
    }
  }
}


int[,] matrix = new int[3, 5];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine(); // Для отступа между таблицами при печати
PrintArray(matrix);