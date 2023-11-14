// // Проверка на чётность. Метод

// int val = Convert.ToInt32(Console.ReadLine());

// bool IsEven (int value) 
// {
//     return value % 2 == 0;
// }

// Console.WriteLine(IsEven(val));

// // Упрощаем:

// int val = Convert.ToInt32(Console.ReadLine());

// bool IsEven (int value) => value % 2 == 0;

// Console.WriteLine(IsEven(val));

// using System.Linq;

// var a=12;
// Console.WriteLine(a.GetType()); // Печатает разрядностть переменной 
// напр System.Int32
// Console.WriteLine(a.GetType().Name); // Печатает разрядностть переменной 
// // напр Int32
// var data = new int [] {1,2,3,4}
// .Where(e=> e>0)
// .Select(e=> new{q=e, w=e+1});

// Console.WriteLine(data.GetType().Name); // Напечатает WhereSelectArrayIterator`2 
// // (здесь необходимо было использовать var типизацию вместо int )

