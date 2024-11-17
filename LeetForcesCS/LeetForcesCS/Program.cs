string s = "abc";
string t = "ahbgdc";
char[] sChar = s.ToCharArray();
char[] tChar = t.ToCharArray();


for (int i = 0; i < sChar.Length; i++)
{
    Console.WriteLine(sChar[i]);
}

//for (int i = 0; i < s.Length; i++)
//{
//    for (int j = 0; j < t.Length; j++)
//    {

//        if (s[i] == t[j])
//        {
//            //added a counter to check how many of the s letters are in t
//            int counter = 1;
//            //will be adding +1 everytime he finds one s letter in t
//            counter++;
//            Console.WriteLine(counter);
//            //this is just for testing 
//            //Console.WriteLine(i);
//            //checking if all the letters are avialble
//            if (counter >= s.Length)
//            {
//                Console.WriteLine("all the letters in s are in t");

//            }
//            else if (counter < t.Length)
//            {
//                Console.WriteLine("some letters from s are missing in t");
//            }

//        }

//    }
//}
