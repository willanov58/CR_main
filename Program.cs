﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
        // длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
        // либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
        // лучше обойтись исключительно массивами.
        // [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
        // [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
        // [“Russia”, “Denmark”, “Kazan”] → []
 
 
 
string[] arr1 = {"Hello", "2", "world", ":-)"};
        string[] arr2 = {"1234", "1567", "-2", "computer science"};
        string[] arr3 = {"Russia", "Denmark", "Kazan"};
        
        int max_lenght = 3;
        string[] GetShortArray(string[] array)
        {
            int length = array.Length;          
            string[] result = new string[length];
            int count = 0;
            
            for (int i = 0; i < length; i++)
            {
                if(array[i].Length <= max_lenght)
                {
                    result[count] = array[i];
                    count++;
                }
            }
            Array.Resize(ref result, count);
            
            return result;
        }