// Двумерный массив с текстовыми данными 2 строки, 5 столбцов
// string[,] table = new string[2, 5];
// Нумерация в двумерном массиве - как в одномерном строки и столбцы с нуля 
// table[0,0] table[0,1] ... table[0,4] - столбцы
// table[0,0] ... table[1,4] - строки
// String.Empty - инициализация для строк по умолчанию

// table[1, 2] = "Слово";

// for(int rows =0; rows < 2; rows++) // Распечатать 2 мерный массив
// {
//   for(int columns =0; columns < 5; columns++)
//   {
//      Console.WriteLine($"-{table[rows, columns]}-");
//   }
// }

// Двумерный массив с целочисленными данными 2 строки, 5 столбцов
int[,] matrix = new int[3, 5];

for(int i =0; i < 3; i++) // Распечатать 2 мерный массив
{
  for(int j =0; j < 5; j++)
  {
     Console.WriteLine(matrix[i, j]);
  }
}
