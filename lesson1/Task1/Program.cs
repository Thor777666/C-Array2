int[,] CraeteMatrix (int line, int column){

    int[,] table = new int[line, column];

    Random rnd = new Random();

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(0, 11);
        }
    }
    return table;
}

void PrintMatrix(int[,] table){
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CraeteMatrix(4, 5);
PrintMatrix(matrix);