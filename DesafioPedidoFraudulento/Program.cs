// See https://aka.ms/new-console-template for more information
using System;

string[] Fraud = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

foreach (string fraude in Fraud)
{
    if (fraude.StartsWith("B"))
    {
        Console.WriteLine(fraude);
    }
}
