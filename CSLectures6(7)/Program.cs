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


// // Вывести время создание папки (класс DirectoryInfo) и список файлов:

// string path = "C:/Users/pavel/OneDrive/Рабочий стол/C#Lectures/CSLectures2";
// DirectoryInfo di = new DirectoryInfo(path);
// Console.WriteLine(di.CreationTime);
// FileInfo[] fi = di.GetFiles(); // Список в виде массива

// for (int i = 0; i < fi.Length; i++)
// {
//     Console.WriteLine(fi[i].Name);
// }


// // Обзор папок и вывод файлов с рекурсией:

// void CatalogInfo(string path, string indent = "")
// {
//     DirectoryInfo catalog = new DirectoryInfo(path);
//     DirectoryInfo[] catalogs = catalog.GetDirectories();
//     for (int i = 0; i < catalogs.Length; i++)
//     {
//         Console.WriteLine($"{indent}{catalogs[i].Name}");
//         CatalogInfo(catalogs[i].FullName, indent + " ");
//     }
//     FileInfo[] files = catalog.GetFiles();

//     for (int i = 0; i < files.Length; i++)
//     {
//         Console.WriteLine($"{indent}{files[i].Name}");
//     }

// }

// string path = "C:/Users/pavel/OneDrive/Рабочий стол/C#Lectures/CSLectures3";
// CatalogInfo(path);


// // ДЕЛАЕМ ИГРЫ С ПОМОЩЬЮ РЕКУРСИИ
// // Перекладывание блинов по штырям (пирамидки)


// void Towers(string with="1", string on="3", string some="2", int count=3)
// {
//     if (count>1) Towers(with, some, on, count - 1);
//     Console.WriteLine($"{with}>>{on}");
//     if (count>1) Towers(some, on, with, count - 1);
// }

// Towers();


// // РЕШЕНИЕ БОЛЕЕ СЛОЖНЫХ ЗАДАЧ
// // Обход разных структур
// // ((4 -  2)  * (1 +   3)) / 10
// // Выражение можно разбить на действия и пронумеровать их последовательность:
// //                   (/)1
// //                  /    \
// //                 /     (10)3
// //               (*)2
// //             /      \
// //            /        \
// //          (-)4        (+)5
// //         /  \         /  \ 
// //       (4)8  (2)9   (1)10 (3)11

// //  Верхние действия - родительские для нижних

// //          (a[i]) 
// //          /    \
// //     (a[2i])  (a[2i+1]) 

// //Программа выводит порядок действий :

// string emp = String.Empty;
// string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" }; 
// // emp - чтобы умещалось в одну строку
// void InOrderTraversal(int pos=1)
// {
//     if (pos<tree.Length)
//     {
//         int left = 2*pos;
//         int right = 2* pos + 1;
//         if(left<tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
//         Console.WriteLine(tree[pos]);
//         if(right<tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
//     }
// }
// InOrderTraversal();

// // НЕДОСТАТКИ РЕКУРСИИ
// // Бывает медленной
// // Ряд Фибоначи с рекурсией и без:

// decimal fRec = 0;
// decimal fIte = 0;
// // С рекурсией:
// decimal FibonacciRecursion(int n)
// {
//     fRec++;
//     return n==0 || n==1 ? 1 : FibonacciRecursion(n-1) + FibonacciRecursion(n-2);
// }

// // Без рекурси:
// decimal FibonacciIteration(int n)
// {
//     fIte++;
//     decimal result = 1;
//     decimal f0 = 1;
//     decimal f1 = 1;
//     for (int i = 2; i <= n; i++)
//     {
//      result=f0+f1;
//      f0=f1;
//      f1=result;
//      fIte++;   
//     }
//     return result;
// }
// Console.ReadLine();

// DateTime dt = DateTime.Now;
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciIteration({n})= {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
//     fIte=0;
// }
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// Console.WriteLine();
// Console.ReadLine();
// dt = DateTime.Now;
// for (int n = 10; n < 40; n++)
// {
//     Console.WriteLine($"FibonacciRecursion({n})= {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
//     fRec=0;
// }
// Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);


// // НЕДОСТАТКИ РЕКУРСИИ
// // Ошибки. Самая частая - переполнение стека! (памяти и количества обращений)
// // ЕСЛИ НЕ ПРОПИСАЛИ или НЕ ПРАВИЛЬНО ПРОПИСАЛИ УСЛОВИЕ ВЫХОДА ИЗ РЕКУРСИИ:
// // ИЛИ ПРОГРАММА (как в закрашивании картинок) ДЕЛАЕТ СЛИШКОМ МНОГО ОБРАЩЕНИЙ! 

// void Rec() // Метод, ничего не делает, только вызывает сам себя без выхода
// {
//     Rec(); 
// }

// Rec();

// //То же самое с просмотром в чисел консоль:
// int i=0;
// void Rec()
// {
//     Console.WriteLine(i++);
//     Rec(); 
// }

// Rec();