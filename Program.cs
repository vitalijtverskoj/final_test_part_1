﻿string[] GetShortStringArray(string[] array)
{
    string strResult = "";
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            strResult = strResult + array[i] + ";";
        }
    }
    strResult = strResult.Remove(strResult.Length - 1);
    string[] arrayResult = strResult.Split(";");
    return arrayResult;
}

string[] strArray = {
    "str",
    "strong",
    "st",
    "stronger",
    "s",
    "strongless"
};

string [] shortStrArray = GetShortStringArray(strArray);
Console.WriteLine($"[ {string.Join(", ", shortStrArray)} ]");