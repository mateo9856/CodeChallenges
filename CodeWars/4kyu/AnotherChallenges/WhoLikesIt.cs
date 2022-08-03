using System;
using System.Linq;
using System.Collections.Generic;
public static class WhoLikesIt
{
    public static string Likes(string[] name)
    {
        var likeFormat = name.Length <= 1 ? " likes this" : " like this";

        var startFormat = name.Length <= 0 ? "no one" : name.Length == 1 ? name[0] :
        name.Length == 2 ? string.Join(" and ", name) : name.Length == 3 ? string.Concat(string.Join(", ", name.Take(2).ToArray()), $" and {name.Last()}")
        : string.Concat(string.Join(", ", name.Take(2).ToArray()), $" and {name.Skip(2).ToArray().Length} others");

        return string.Concat(startFormat, likeFormat);
    }
}