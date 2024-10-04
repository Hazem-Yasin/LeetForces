int[] flowerbed = [1, 0, 0, 0, 1];
int n = 2;

Console.WriteLine(flowerbed.Length);



//for (int z = 0; z <= flowerbed.Length; z++)
//{
//    for (int x = -1; x <= flowerbed.Length; x++)
//    {
//        for (int y = 1; y <= flowerbed.Length; y++)
//        {
//            Console.WriteLine(flowerbed[x]);
//            Console.WriteLine(flowerbed[y]);
//            Console.WriteLine(flowerbed[z]);
//        }
//    }

//}


for (int z = 0; z <= flowerbed.Length; z++)
{
    Console.WriteLine(flowerbed[z]);
    Console.WriteLine(flowerbed[z + 1]);

}