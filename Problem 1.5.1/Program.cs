using System;


// Bad Solution
System.Console.WriteLine("Please add the number");
var I = int.Parse(Console.ReadLine());
var s = 0;
var i = 1;
while (i <= I)
{
    s = s + i;
    i = i + 1;
}
System.Console.WriteLine($"the summation = {s}");


// Good Solution
System.Console.WriteLine("Please add the number");
var II = int.Parse(Console.ReadLine());
var ss = 0;
var ii = 0;
while (!(ii > II))
{
    ss = ss + ii;
    ii = ii + 1;
}
System.Console.WriteLine($"the summation = {ss}");
