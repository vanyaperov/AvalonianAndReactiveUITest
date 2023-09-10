using System;

public static  class Printer
{
    public static void Print(ref string textToUpdate, params string[] args)
    {
        var stringToPrint = "";
        foreach(var arg in args)
        {
            stringToPrint += $"{arg} ";
        }
        textToUpdate = stringToPrint;
        Console.WriteLine(stringToPrint);
    }
}