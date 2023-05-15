int[] ArrayF6 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int total = ArrayF6.Length;

for (int j = 0; j < total; j++)
{
    for (int k = 0; k < total; k++)
    {
        for (int l = 0; l < total; l++)
        {
            if (j > 0)
            {
                Console.Write(ArrayF6[j]);
            }
            Console.Write(ArrayF6[k]);
            Console.Write(ArrayF6[l] + " ");
        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}
