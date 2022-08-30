// I denne opgave skal du lave følgende to Højere Ordens Funktioner:


var CreateWordReplacerFn = (string[] words, string replacementWord) => {
    // TODO!
    return () => {
      var nysætning = words.Contains("");
    };
};

var badWords = new string[] { "tis", "pis", "lort" };
var FilterBadWords = CreateWordReplacerFn(badWords, "kage");
Console.WriteLine(FilterBadWords("Sikke en gang lort"));