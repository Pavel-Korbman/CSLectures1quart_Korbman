// //Рекурсия (дополнительное занятие)

//   //Задача 1: Собрать строку с числами от а до b, a<=b

// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = a; i <= b; i++)
//     {
//       result += $"{i} ";  
//     }
//     return result;
// }

// string NumbersRec(int a, int b) // Тот же метод, но с рекурсией
// {
//     if (a< b) return $"{a} " + NumbersRec(a + 1, b);
//     else return $"{b} ";
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));

//  // Задача 1b: Собрать строку с числами от b до a, a<=b

// string NumbersFor(int a, int b)
// {
//     string result = string.Empty;
//     for (int i = b; i >= a; i--)
//     {
//       result += $"{i} ";  
//     }
//     return result;
// }

// string NumbersRec(int a, int b) // Тот же метод, но с рекурсией
// {
//     if (b>a) return $"{b} " + NumbersRec(a, b-1);
//     else return $"{a} ";
// }

// Console.WriteLine(NumbersFor(1, 10));
// Console.WriteLine(NumbersRec(1, 10));


//  // Задача 2: Найти сумму чисел от 1 до n

// int SumFor(int n)
// {
// int result = 0;    
// for (int i = 1; i <= n; i++) result += i;
// return result;
// }

// int SumRec(int n) // Тот же метод, но с рекурсией
// {
// if (n==1) return 1;
// else return n+ SumRec(n-1); 
// }

// Console.WriteLine(SumFor(5));
// Console.WriteLine(SumRec(5));


//  // Задача 3: Найти факториал n

// int FactorialFor(int n)
// {
// int result = 1;
// for (int i = 1; i <= n; i++) result *= i;
// return result;
// }

// int FactorialRec(int n)
// {
// if (n==2) return 2;
// else return n *= FactorialRec(n-1);
// }

// Console.WriteLine(FactorialFor(5));
// Console.WriteLine(FactorialRec(5));

//  // Задача 4: Найти a в степени n :

// int PowerFor (int a, int n)
// {
//     int result = 1;
//     for (int i = 0; i < n; i++) result *= a;
//     return result;
// }

// int PowerRec (int a, int n) // Тот же метод, но с рекурсией
// {
//  if (n==0) return 1;
//  else return a* PowerRec (a, n-1);
// // Можно записать так: 
// // return n==2 ? a*a: a* PowerRec (a, n-1);
// }


// // Можно ускорить алгоритм, сократив количество операций *. 
// // По формулам: (a^n)*(a^m) = a^(n+m) ; (a^n)^m = a^n*m :

// int PowerRecMath (int a, int n)
// {
//  if (n==0) return 1;
//  else if (n%2 ==0) return PowerRecMath (a*a, n/2);
//  else return a* PowerRecMath (a, n-1);
// }

// Console.WriteLine(PowerFor(3, 10));
// Console.WriteLine(PowerRec(3, 10));
// Console.WriteLine(PowerRecMath(3, 10));



//  // Задача 5: Даны 4 буквы - "А" "И" "С" "В". 
// // Переберите все слова состоящие из Т букв из этого алфавита:

// // Решение для Т=2:

// char[] s = {'А', 'И', 'С', 'В'};
// int count = s.Length;
// int n = 1;
// for (int i = 0; i < count; i++)
// {
//    for (int j = 0; j < count; j++)
//    {
//     Console.WriteLine($"{n++,-5} {s[i]} {s[j]}");
//    } 
// }

// // Решение для Т:

// void FindWords (string alphabeth, char [] word, int length=0)
// {
//     int n=1;
//         if (length== word.Length)
//     {
//         Console.WriteLine($"{n++} {new String(word)}"); 
//         return;
//     }
//     for (int i = 0; i < alphabeth.Length; i++)
//     {
//         word[length] = alphabeth[i];
//         FindWords(alphabeth, word, length+1);
//     }
// }

// FindWords("АИСВ", new char[4]);



// string path = "C:\Users\pavel\OneDrive\Рабочий стол\C#Lectures\CSLectures2\.gitignore";
DirectoryInfo di = new DirectoryInfo(Users\pavel\OneDrive\Рабочий стол\C#Lectures\CSLectures2\.gitignore);
Sistem.Console.WriteLine(di.CreationTime);