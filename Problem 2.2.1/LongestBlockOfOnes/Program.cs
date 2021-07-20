using LongestBlockOfOnes;
using System;
using System.Text.Json;

// 011110000111100010000111110

// (pre condition) the input is A, a 0 , 1 array of length n
// (post-condition) the output is the location of the A[k1...k2] of the longest block of ones and its length leng
// begin

Console.WriteLine("Please provide the length of list: ");
// Default n = 10
var n = int.Parse(Console.ReadLine() ?? "10");
var arr = new int[n];
for (int j = 0; j < n; j++)
{
    Console.WriteLine($"Enter the #{j + 1} num: ");
    var v = int.Parse(Console.ReadLine() ?? "1");
    arr[j] = v is 1 or 0 ? v : 0;
}
int i = 0,                 // Iteration Index
    pMax = 1,              // The Start index of where longest block of ones of all iterations
    qMax = 0,              // The Last index of where longest block of ones of all iterations
    lengMax = 0,           // The length of the longest block of ones of all iterations
    pCurrent = 1,          // the current start index inside one block of ones
    lengCurrent = 0;       // the current last index inside one block of ones
while (i < n)
{
    if (arr[i] == 1)
    {
        lengCurrent += 1;
    }
    else
    {
        pCurrent = i + 1;
        lengCurrent = 0;
    }

    if (lengMax < lengCurrent)
    {
        pMax = pCurrent;
        qMax = i + 1;
        lengMax = lengCurrent;
    }
    i++;
}

Console.WriteLine("Array = " + JsonSerializer.Serialize(arr.SubArray(pMax, qMax)));
Console.WriteLine("length = " + lengMax);
Console.WriteLine("Max Start Index (pMax) = " + pMax);
Console.WriteLine("Max Last Index (qMax) = " + qMax);


