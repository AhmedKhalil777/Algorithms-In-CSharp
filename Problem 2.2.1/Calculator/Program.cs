
using System;
using static System.Console;
string screenInput = "";
string screenOutput = "";
int accum, current;
accum = current = 0;
while (true){ 

    var c = ReadLine();
    if(char.IsNumber(c[0]))
    {
        current = 10 * current + int.Parse(c[0].ToString());
        screenInput =  current.ToString();
        screenOutput =  accum.ToString();
    }
    else if (c[0] == '+')
    {
        screenInput = "";
        accum +=  current;
        current = 0;
        screenOutput = accum.ToString();
    }
    else if (c[0] =='c')
    {
        accum = 0;
        screenOutput = "Output: 0";
        screenInput = "Input : ";
    }
    Clear();
    WriteLine("Input: "+ screenInput);
    WriteLine("OutPut : "+ screenOutput);
}