// See https://aka.ms/new-console-template for more information
using ConsoleApp.Convert;

Console.WriteLine("Alien numerals are usually written from largest to smallest. However, the numeral for four is not AAAA. Instead, 4 is written as AB. Because A (1) is before B (5) we subtract it making four. The same principle applies to 9, which is written as A (1) and Z (10).");
Console.WriteLine(" A =>1 ,\n B =>5 ,\n Z =>10 ,\n L =>50 ,\n C =>100 ,\n D =>500 ,\n R =>1000");

AlienSymbolToInteger convert = new AlienSymbolToInteger();
convert.Main();
