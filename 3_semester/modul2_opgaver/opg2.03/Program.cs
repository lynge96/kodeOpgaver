
using System.Linq;

var CreateWordReplacerFn = (string[] words, string replacementWord) => {
    // TODO!
    return () =>
    {
        var nySætning = words.Contains(words);
    };
};

var badWords = new string[] { "tis", "pis", "lort" };
var FilterBadWords = CreateWordReplacerFn(badWords, "kage");
Console.WriteLine(FilterBadWords("Sikke en gang lort"));