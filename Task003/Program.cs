﻿int [] array = {11, 21, 31, 41, 18, 51, 15, 17, 18, 19};

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index ++;
}