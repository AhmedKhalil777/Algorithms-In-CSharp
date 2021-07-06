
using System;
string screenInput = "Input : ";
string screenOutput = "Output : ";
int accum, current;
accum = current = 0;
while (true){ 

    var c = Console.ReadLine();
    if(char.IsNumber(c[0]))
    {
        current = 10 * current + int.Parse(c[0].ToString());
        screenInput = current.ToString();
        screenOutput =  current.ToString();
    }
    else if (c[0] == '+')
    {
        screenInput = "Input : ";
        accum = accum + current;
        current = 0;
        screenOutput = accum.ToString();
    }
    else if (c[0] =='c')
    {
        accum = 0;
        screenOutput = "Output: 0";
        screenInput = "Input : ";
    }
    Console.Clear();
    Console.WriteLine(screenInput);
    Console.WriteLine(screenOutput);
}