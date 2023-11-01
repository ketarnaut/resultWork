/*
План:
1. Запросить количество элементом массива для ввода

2. Запросить массив

3. Перебрать каждый элемент массива и добавить подходящие по условию элемены в новый массов

*/


//Запросить сколько элементов массива будет вводить пользователь (count)
Console.WriteLine("укажите, сколько элементов в массив будет введено");
int count = Convert.ToInt32(Console.ReadLine());

if (count < 1) 
{
    Console.WriteLine("введите число больше 0");    
}


string [] arrayOfText = new string[count];
string [] newarrayOfText = new string[count];
  for (int i = 0, i2 = 0; i < count; i++) {
    Console.WriteLine("введите элемент массива " +i);
        arrayOfText[i] = Console.ReadLine();// Заполняем массив элементами, введёнными с клавиатуры
        
        if (arrayOfText[i].Length < 4)
        {
newarrayOfText[i2]=arrayOfText[i];
i2++;
        }
    }

//Вывести массив
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(" " + newarrayOfText[i]);
    }
        Console.Write("]");

        Console.WriteLine(" --> ");