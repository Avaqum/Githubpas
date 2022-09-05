//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.WriteLine("Введите трёхзначное число N");
// string input = Console.ReadLine();

// bool ValidateInput(string input)
// {
//     bool isNumberN = int.TryParse(input, out int n);
//    if (n <=0 || n < 100)
// {
//    Console.WriteLine("No third number ");
//        return false;
// }
//    return true;

// }

// char FindThrdNumber(string number)
// {
//     return number[2];
// }
//  bool isValid = ValidateInput(input);

//  if(!isValid)
//  {
//     return;
//  }

//  char result = FindThrdNumber(input);
//  Console.WriteLine($"Third number is {result}");




// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


// Console.WriteLine("Введите число от 1 до 7 ");

// bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

// if (isNumberX != true)
// {
//     Console.WriteLine("Числo введенo неверно.");
// }
// bool isValid = Validate(x);

// if(isValid == false)
// {
// Console.WriteLine("Число меньше либо равно 0 или больше 7");
// return;
// }

// string result = GetWeekend(x);
// Console.WriteLine(result);

// bool Validate(int x)
// {
//    if(x == 0 || x > 7)
//    {
//        return false;
//    }
//    return true;
// }
// string GetWeekend(int x)
// {
//    if(x == 1)
//    {
//        return "No weekend :c ";
//    }

//    if(x == 2)
//    {
//        return "Just second day :c ";
//    }

//    if(x == 3)
//    {
//        return "Half of the week :c ";
//    }

//    if(x == 4)
//    {
//        return "No weekend :c but... ";
//    }

//    if(x == 5)
//    {
//        return "Very close to the Weekends! ";
//    }

//    if(x == 6)
//    {
//        return "Yes, saturday is weekend! c: ";
//    }

//    if(x == 7)
//    {
//        return "Already SundaY?! Why so fast :c but anyway it's Weekend! c: ";
//    }

// return "Число меньше или равно 0 или больше 7";
// }









// БУЛЛИНГ ПАЛИНДРОМА
// bool CheckPalindrom(string lstr)
// {
// string reverseString=ReverseString(str);
// return str == reverseString;
// }
// Console.WriteLine(str);






// ПРИНИМАЕТ ЧИСЛО И СУММИРУЕТ ВСЕ ЧИСЛА ДО ЭТОГО ЧИСЛА

// bool isNumber = int.TryParse(Console.ReadLine(), out int number);

// if(isNumber == false)
// {
//     Console.WriteLine("Wrong number");
//     return;
// }

// int result = GetSumNumber(number);

// Console.WriteLine(result);

// {
//     int sum = 0;
//     for (int i = 1; i<=number; i++)
//     {
//         sum+=i;
//     }
//     return sum;
// }





// Console.WriteLine("Write Number");
// int number = Convert.ToInt32(Console.ReadLine());

// int Count (int number)
// {
//     int count = 0;
//     int temp = number;
//     if (temp == 0)
//     {
//         return 1;
//     };
//     while (temp != 0)
//     {
//         temp = temp / 10;
//         count++;
//     };
//     return count;

// };

// Console.WriteLine($"Count of Numbers: {Count(number)}");







// ЗАДАЧА С ПЕРЕМНОЖЕНИЕМ ЧИСЕЛ ДО ОПРЕДЕЛЁННОГО ЧИСЛА
// Console.WriteLine("Write number ");
// bool isNumber = int.TryParse(Console.ReadLine(), out int number);

// int Multiply(int number)
// {
//     int result = 1;
//     for (int i = 1; i<= number; i++)
//     {
//         result = result * i;
//     };
//     return result;
// };

// if(isNumber == false || number<1 ) {Console.WriteLine("Wrong number ");return;}

// Console.WriteLine($"Multiples of numbers is: {Multiply(number)}");









// ЗАДАЧА С МАССИВОМ НА 8 ЧИСЕЛ В НЁМ
// int[] PassArr(int n)
// {
//     int[] newArray = new int [n];
//     for (int i=0; i<n;i++)
//     {
//         newArray[i]=new Random().Next(0,2);
//     };
//     return newArray;
// };

// void PrintArr(int[] array)
// {
//     for (int i=0; i<array.Length;i++)
//     {
//         Console.Write($"{array[i]}");
//     };
// };

// bool isNumber = int.TryParse(Console.ReadLine(), out int number);
// if (isNumber==false || number!=8)
// {
//     Console.WriteLine("Wrong number");
//     return;
// };
// PrintArr(PassArr(number));









// PALINDROM
// Console.WriteLine("Является ли чилсо палиндромом?");

// string RevString (string str)
// {
//     string result = string.Empty;
//     for (int i = 0; i<str.Length; i++)
//     {
//         result += str[str.Length -1 -i];
//     }
//     return result;
// }

// string input = Console.ReadLine();

// string str = RevString(input);

// if(input==str)
// {
//     Console.WriteLine("Это палиндром");
// }    
//     else
//     {
//         {
//             Console.WriteLine("А это не палиндром");
//         }
//     }


// *PALINDROM*
// string numb = Console.ReadLine();

// char[] revnumb = numb.ToCharArray();

// Array.Reverse(revnumb);


// string finalnumb = new string(revnumb);
// if (numb == finalnumb)
// {
//    Console.WriteLine("Да, это палиндром");
// }
// if (numb!=finalnumb)
// {
//    Console.WriteLine("Нет, это не палиндром");
// }





// ЗАДАЧА С КООРДИНАТАМИ 3-Х МЕРНЫХ ТОЧЕК И НАХОЖДЕНИЕ РАССТОЯНИЯ МЕЖДУ НИМИ
// Console.WriteLine("Программа принимает на вход координаты двух точек и находит расстояние между ними в трёхмерном пространстве ");

// Console.Write("Write first dot x coordinates: ");
// bool isNumberX_1 = int.TryParse(Console.ReadLine(), out int x1);
// Console.Write("Write first dot y coordinates: ");
// bool isNumberY_1 = int.TryParse(Console.ReadLine(), out int y1);
// Console.Write("Write first dot z coordinates: ");
// bool isNumberZ_1 = int.TryParse(Console.ReadLine(), out int z1);

// Console.Write("Write second dot x coordinates: ");
// bool isNumberX_2 = int.TryParse(Console.ReadLine(), out int x2);
// Console.Write("Write second dot y coordinates: ");
// bool isNumberY_2 = int.TryParse(Console.ReadLine(), out int y2);
// Console.Write("Write second dot z coordinates: ");
// bool isNumberZ_2 = int.TryParse(Console.ReadLine(), out int z2);

// if(!isNumberX_1 || !isNumberX_2 || !isNumberY_1 || !isNumberY_2 || !isNumberZ_1 || !isNumberZ_2)
// {
//     Console.WriteLine("Wrong numbers was wrote. Please try again c: ");
//     return;
// }

// Console.Write($"Distance is: {GetLenght(x1,y1,z1,x2,y2,z2)}");

// double GetLenght(int x1, int y1, int z1, int x2, int y2, int z2)
// {
//     return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
// }





// ЗАДАЧА НА НАХОЖДЕНИЕ ВСЕХ КУБОВ ДО ОПРЕДЕЛЁННОГО ЧИСЛА
// Console.WriteLine("Сейчас мы будем находить все кубы))))))) так что число вводи ");

// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = GetArray(n);
// foreach(int x in array)
// {
//     Console.WriteLine(x);
// }
// int[] GetArray (int n)
// {
//     int [] array = new int [n];
//     for(int i = 1; i <= n; i++)
//     {
//         array[i-1] = i*i*i;   //or double GetTriple (int i){ return Math.Pow((i), 3);}
//     }
//     return array;
// }   





//Напишите программу, которая принимает на вход 2 числа и возводит первое в степень второго числа
// Console.WriteLine();
// Console.WriteLine("Программа на возведение числа А в степень В");
// Console.WriteLine();
// Console.Write("Введите число А: ");
// bool isNumberA = int.TryParse(Console.ReadLine(), out int A);
// Console.Write("Введите число В: ");
// bool isNumberB = int.TryParse(Console.ReadLine(), out int B);

// if (isNumberA != true || isNumberB != true)
// {
//    Console.WriteLine("Числа авведены неверно.");
// }
// Console.WriteLine("Число А в степени В = " + Math.Pow(A, B));
// Console.ReadKey();








// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.WriteLine();
// Console.WriteLine("Программа суммирующая цифры в числе");         
// Console.WriteLine();
// Console.Write("Введите любое положительное число (желательно состоящие из хотя бы 2 цифр): ");
// Console.WriteLine();

// bool isNumberX = int.TryParse(Console.ReadLine(), out int x);
// if (isNumberX != true)
// {
//     Console.WriteLine("Это же даже не число");
// }
// Sum2();
// int Sum(int summary)
// {
//     if (summary < 10)
//     return summary;

//     int y = summary%10;
//     int sum2 = summary/10;
//     return y + Sum(sum2);
// }
// void Sum2()
// {
//     int digit = x;
//     int result = Sum(digit);
//     Console.WriteLine(result);
// }







//  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// int[] PassArr(int n)
// {
//     int[] newArray = new int [n];
//     for (int i=0; i<n;i++)
//     {
//         newArray[i]=new Random().Next(0,1000);
//     };
//     return newArray;
// };
// int number = 8;
// void PrintArr(int[] array)
// {
//     for (int i=0; i<array.Length;i++)
//     {
//         Console.Write($" {array[i]}");
//     };
// };
// PrintArr(PassArr(number));