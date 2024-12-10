string str1 = "ABCABC";
string str2 = "ABC";


for (int i = 0; i < str1.Length; i++)
{
    if (str1[i] == str2[i])
    {
        Console.WriteLine($"this is string 1 i = {str1[i]} and this is string 2 i {str2[i]}");
    }
    else if (str1[i] != str2[i]) {
        Console.WriteLine($"the string 1 {str1[i]} isn't the same as {str2[i]}");
    } }