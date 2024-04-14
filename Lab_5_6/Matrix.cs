using System;
using System.Threading;
using System.Threading.Tasks;

public class Matrix
{
    private int[,] matrixA;
    private int[,] matrixB;
    private int[,] resultThread;
    private int[,] resultParallel;
    private int size;
    private int threads;
    private int rowNumber = -1;
    private object locker = new object();

    public Matrix(int size, int threads)
    {
        this.size = size;
        this.threads = threads;

        matrixA = CreateMatrix(size);
        matrixB = CreateMatrix(size);
        resultThread = CreateMatrix(size);
        resultParallel = CreateMatrix(size);

        FillRandom(matrixA);
        FillRandom(matrixB);
    }

    public int[,] getMatrixA() => matrixA;
    public int[,] getMatrixB() => matrixB;
    public int[,] getResultThread() => resultThread;
    public int[,] getResultParallel() => resultParallel;

    private int[,] CreateMatrix(int size) 
    {
        return new int[size, size];
    }

    private void FillRandom(int[,] matrix)
    {
        Random rnd = new Random();
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = rnd.Next(10);
            }
        }
    }

    private void MultiplyRowThread()
    {
        while (true)
        {
            int row;
            lock (locker)
            {
                rowNumber++;
                if (rowNumber >= size) return;
                row = rowNumber;
            }

            for (int k = 0; k < size; k++)
            {
                resultThread[row, k] = 0;
                for (int j = 0; j < size; j++)
                {
                    resultThread[row, k] += matrixA[row, j] * matrixB[j, k];
                }
            }
        }
    }

    private void MultiplyRowParallel(int row)
    {
        for (int k = 0; k < size; k++)
        {
            resultParallel[row, k] = 0;
            for (int j = 0; j < size; j++)
            {
                resultParallel[row, k] += matrixA[row, j] * matrixB[j, k];
            }
        }
    }
    public static string MatrixToString(int[,] matrix)
    {
        if (matrix == null) return "";

        string output = "";
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                output += matrix[i, j] + "\t";
            }
            output += Environment.NewLine;
        }
        return output;
    }

    public static string? PrintAllMatrix(int[,] matrixA, int[,] matrixB, int[,] resultMatrix)
    {
        if (matrixA == null || matrixB == null || resultMatrix == null)
        {
            return null;
        }

        string output = "";
        output += "Macierz A:" + Environment.NewLine + MatrixToString(matrixA);
        output += "Macierz B:" + Environment.NewLine + MatrixToString(matrixB);
        output += "Macierz wynikowa:" + Environment.NewLine + MatrixToString(resultMatrix);

        return output;
    }

    public void StartThread()
    {
        Thread[] threadArray = new Thread[threads];
        for (int i = 0; i < threads; i++)
        {
            threadArray[i] = new Thread(MultiplyRowThread);
            threadArray[i].Start();
        }
        foreach (var t in threadArray)
        {
            t.Join();
        }
    }

    public void StartParallel()
    {
        ParallelOptions? options = new ParallelOptions { MaxDegreeOfParallelism = threads };

        Parallel.For(0, size, options, i =>
        {
            MultiplyRowParallel(i);
        });
    }
}
