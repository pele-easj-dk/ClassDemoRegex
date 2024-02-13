﻿// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Console.WriteLine("Regular expression");

string text = "1 One, 2 Two, 3 Three is good. 4      hi.";
string pattern = @"\d\s*(\D*)[,.]";

Console.WriteLine("Text ::" + text + "::");
Console.WriteLine("Pattern ::" + pattern + "::");


// exists?
Console.WriteLine("Exists");
Console.WriteLine(Regex.IsMatch(text, pattern));
Console.WriteLine();

// get match
Console.WriteLine("GET ELEMENT");
Match m = Regex.Match(text, pattern);
Console.WriteLine("Found=" + m);
Console.WriteLine("Found full group=" + m.Groups[0]);
Console.WriteLine("Found inner group=" + m.Groups[1]);
Console.WriteLine();

// get groups
Console.WriteLine("GET GROUPS");
MatchCollection ms = Regex.Matches(text, pattern);
foreach (Match match in ms)
{
    int grpno = 0;
    foreach (Group g in match.Groups)
    {
        Console.WriteLine("    Group " + grpno++);
        Console.WriteLine("    " + g);
    }
}


Console.WriteLine("Split");
string[] digits = Regex.Split(text, @"\d\s*");
foreach (string str in digits)
{
    Console.WriteLine(str);
}

Console.WriteLine("Replace");
String str2 = Regex.Replace(text, @"[^0-9a-zA-Z]+", "::");
Console.WriteLine(str2);

Console.WriteLine("Fin");