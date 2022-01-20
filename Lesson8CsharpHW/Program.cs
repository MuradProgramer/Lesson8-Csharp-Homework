using System;

Map map = new Map(new Pair[]
{
    new Pair("apple", "alma"),
    new Pair("sleep", "yatmaq"),
    new Pair("friend", "dost"),
    new Pair("food", "yemek"),
    new Pair("job", "ish"),
    new Pair("love", "sevgi"),
    new Pair("life", "heyat"),
    new Pair("live", "yashamaq"),
    new Pair("leave", "terk etmek"),
    new Pair("house", "ev"),
    new Pair("money", "pul"),
    new Pair("monkey", "meymun"),
    new Pair("talk", "danishmaq"),
    new Pair("walk", "gezmek"),
    new Pair("go", "getmek"),
    new Pair("win", "udmaq"),
    new Pair("rapidly", "tez"),
    new Pair("lose", "uduzmaq"),
    new Pair("drink", "icmek"),
    new Pair("die", "olmek"),
    new Pair("dream", "arzu"),
    new Pair("cat", "pishik"),
    new Pair("dog", "it"),
    new Pair("man", "kishi"),
    new Pair("woman", "qadin"),
    new Pair("copier", "ramazan"),
    new Pair("make", "duzeltmek"),
    new Pair("paradise", "cennet"),
    new Pair("programing", "en yaxshi ixtisas"),
    new Pair("teacher", "muellim"),
});

Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\n\n\n\t\tE N T E R   W O R D: ");
var word = Console.ReadLine();
Console.WriteLine($"\t\tT H E   M E A N I N G: {map[word]}");