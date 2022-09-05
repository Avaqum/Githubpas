//Console.WriteLine("Нахождение максимального из двух чисел");
//Console.Write("Введите два числа : ");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//int max = a;

//if (b > max) max = b;

//Console.Write("max =");
//Console.WriteLine(max);


//Console.WriteLine("Нахождение максимального из 3 чисел");
//Console.Write("Введите 3 числа : ");
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());
//int c = Convert.ToInt32(Console.ReadLine());

//int max = a;

//if (b > max) max = b;
//if (c > max) max = c;

//Console.Write("max =");
//Console.WriteLine(max);



//Console.Write("Введите чётное число : ");
//int b = Convert.ToInt32(Console.ReadLine());
//{
    //if (b%2==0){
        //Console.WriteLine("Число чётное");
         //Console.WriteLine(b);
    //}
    //else Console.WriteLine("Число нечётное");
//}



//Random random = new Random();

//int randomNumber = random.Next(100 , 1000);

//Console.WriteLine(randomNumber);

//int thirdNumber = randomNumber % 10;
//int firstNumber = randomNumber / 100;

//Console.WriteLine($"First and second number is {firstNumber}{thirdNumber}");







// ЗАДАЧА НА НАХОЖДЕНИЕ ЧЕТВЕРТИ ПО ЧИСЛАМ
//Console.WriteLine("Input x");
//bool isNumberX = int.TryParse(Console.ReadLine(), out int x);

//Console.WriteLine("Input y");
//bool isNumberY = int.TryParse(Console.ReadLine(), out int y);

//if (isNumberX != true || isNumberY != true)
//{
//    Console.WriteLine("Числа авведены неверно.");
//}

//bool Validate (int x, int y)
//{
//    if (x == 0 || y == 0)
//    {
//        return false;
//    }
//    return true;
//}

//bool isValid = Validate(x,y);
//if (isValid == false)
//{
//    Console.WriteLine("some number is 0 ");
//    return;
//}

//int result = GetQuartal(x,y);
//Console.WriteLine(result);

//int GetQuartal (int x, int y)
//{
//    if (x>0 && y>0)
//    {
//        return 1;
//    }
    
//    if (x<0 && y>0)
//    {
//        return 2;
//    }
//
//    if (x<0 && y<0)
//    {
//        return 3;
//    }

//    if (x>0 && y<0)
//    {
//        return 4;
//    }
//
//    return -1;
//}






// ЗАДАЧА НА НАХОЖДЕНИЕ КООРДИНАТ В ЧЕТВЕРТИ
//Console.WriteLine("Введите n");
//bool isNumberN = int.TryParse(Console.ReadLine(), out int n);

//if(isNumberN != true)
//{
//    Console.WriteLine("Числа введены не верно.");
//    return;
//}

//bool isValid = Validate(n);
//if(isValid == false)
//{
// Console.WriteLine("Число меньше либо равно 0 или больше 4");
// return;
// }

// string result = GetPosition(n);
// Console.WriteLine(result);

// bool Validate(int n)
// {
//    if(n == 0 || n > 4)
//    {
//        return false;
//    }
//    return true;
// }

// string GetPosition(int n)
// {
//    if(n == 1)
//    {
//        return "x > 0, y > 0";
//    }

//    if(n ==2)
//    {
//        return "x < 0, y > 0";
//    }

/*    if(n == 3)
    {
        return "x < 0, y < 0";
    }

    if(n == 4)
    {
        return "x > 0, y < 0";
    }
    
    return "Число равно 0 или больше 4";
}*/


// Console.WriteLine ("Input N number ");
// bool isNumberN = int.TryParse(Console.ReadLine(), out int n);
// if(isNumberN != true)
// {
//     Console.WriteLine("Числа введены не верно.");
//     return;
// }



// ЗАДАЧА НА НАХОЖДЕНИЕ ВСЕХ КВАДРАТОВ ДО ОПРЕДЕЛЁННОГО ЧИСЛА
// int[] array = GetArray(n);
// foreach(int x in array)
// {
//     System.Console.WriteLine(x);
// }
// int[] GetArray (int n)
// {
//     int [] array = new int [n];
//     for(int i = 1; i <= n; i++)
//     {
//         array[i-1] = i*i;
//     }
//     return array;
// }






// //Проверка вводимого числа 
// Console.Write("Введите длину массива: ");
// bool isNum_x = int.TryParse(Console.ReadLine(), out int x);

// if (!isNum_x)
// {
//     Console.WriteLine("Ошибка ввода");
//     return;
// }

// int [] array = GetArray(x);

// Console.Write("Введите искомое значение: ");
// bool isNum_y = int.TryParse(Console.ReadLine(), out int y);

// Console.WriteLine(GetNumberTrueFalse(array,y));

// bool GetNumberTrueFalse(int[] array, int a)
// {
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == a) return true;
// }
//     return false;
// }

// //Вывод данных из массива
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// //Заполняем массив
// int[] GetArray(int lenght)
// {
//     int[] array = new int[lenght];
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"Введите {i} элемент массива:");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }



// int n = 10;
// int[] PassArr(int n)
// {
//     int[] newArray = new int [n];
//     Random random = new Random();
//     for (int i=0; i<n;i++)
//     {
//         newArray[i]= random.Next(0,500);
//     };
//     return newArray;
// };

// void PrintArr(int[] array)
// {
//     for (int i=0; i<array.Length;i++)
//     {
//         Console.Write($"{array[i]} ");
//     };
// };
// PrintArr(PassArr(n));

// int GetNumber(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array [i]>=10 && array [i]<=99)
//         {
//             result = result + 1;
//         }
//     }
//     return result;
// }
// Console.WriteLine();
// Console.WriteLine(GetNumber(PassArr(n)));





// ПРОГРАММА НА ПЕРЕВОРОТ МАССИВА
int[] array = new int[] {1,2,3,4,5};
PrintArray(array);
int[] reverseArray = ReverseArray(array);
Console.WriteLine();
PrintArray(reverseArray);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int[] ReverseArray(int[] array)
{   
    int tmp;
    tmp = array[1];
    array[1] = array[3];
    array[3] = tmp;

    int[] reverseArray = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        reverseArray[i] = array[array.Length - 1 - i];
    }

    return reverseArray;
}