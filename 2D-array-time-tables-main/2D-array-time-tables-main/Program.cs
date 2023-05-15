static int FuncFive(int[] input)
{

    int my = 0;

    int total = input.Length;

    int index = 0;

    int[,] ar1 = new int[1, total];

    int[,] ar2 = new int[total, total];

    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < total; j++)
        {

            ar1[i, j] = input[index++];

            for (int z = 0; z < total; z++)
            {

                ar2[i, j] = ar1[i, j] * input[z];

                Console.Write(ar2[i, j] + " ");

            }
            Console.WriteLine();


        }

    }


    return my;
}

int[] ArrayF5 = { 1, 2, 3, 4, 5 };
FuncFive(ArrayF5);
