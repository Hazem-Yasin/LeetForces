using System.Linq;

int[] candies = [2,3,5,1,3];
int ExtraCandies = 3;
string[] result = [];


for (int i = 0; i < candies.Length; i++) {

    int CandiesPlusExtraCandiess = candies[i] + ExtraCandies;
    int[] CandiesPlusExtraCandies;
    
    CandiesPlusExtraCandies.Append(CandiesPlusExtraCandiess);
    if () { }
    else if () { }

}

for (int i = 0; i < candies.Length; i++)
{
    int CandiesEye = candies[i] + ExtraCandies;
    for (int j = 0; j < ExtraCandies; j++)
    {
        if (CandiesEye < candies[j]) {
            Console.WriteLine(CandiesEye + 
                "Candieseye is smaller than candies[j]");
        }
        else if(CandiesEye > candies[j])
        {
            Console.WriteLine(CandiesEye + 
                "Candieseye is bigger than candies[j]");
        }
    }
}
