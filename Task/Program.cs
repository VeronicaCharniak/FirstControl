//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам.

// метод подсчета длины итогового массива
int SizeCounter(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3)
        {
            size = size + 1;
        }
    }
    return size;
}

// метод, заполняющий массив числами длиной меньше 3
void LessThan3Length(string[] arr_1, string[] arr_2)
{
    int count = 0;
    for (int i = 0; i < arr_1.Length; i++)
    {
    if(arr_1[i].Length <= 3)
        {
        arr_2[count] = arr_1[i];
        count = count + 1;
        }
    }
}

//метод печати массива
void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

﻿string[] array = new string[4] {"Hello", "2", "world", ":-)"};
string[] result_array = new string[SizeCounter(array)];
LessThan3Length(array, result_array);
PrintArray(result_array);