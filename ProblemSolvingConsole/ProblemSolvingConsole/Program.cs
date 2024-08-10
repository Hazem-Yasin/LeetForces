string word1 = "abc";
string word2 = "def";

string word3 = "";

foreach (var word11 in word1)
{
foreach (var word22 in word2)
    {
        word3 += word11;
        word3 += word22;
    }
}

Console.WriteLine(word3);