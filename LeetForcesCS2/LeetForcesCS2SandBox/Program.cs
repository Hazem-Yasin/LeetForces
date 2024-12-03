//leetcode 75 
//1768. Merge String Alternatly 
string word1 = "abc";
string word2 = "def";
string word3 = "";

for (int x = 0; x < word1.Length; x++){
    word3 += word1[x];
}
for (int y = 0; y < word2.Length; y++){
word3 += word2[y];
}

Console.WriteLine(word3);