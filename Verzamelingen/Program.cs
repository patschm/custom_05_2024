namespace Verzamelingen;

class Program
{
    static void Main(string[] args)
    {
        int[] nummers = new int[10];
        nummers = [1,2,3,4,5,6,7,8,9,10];
        //nummers[0] = 1;
        //nummers[1] = 2;
       // nummers[2] = 3;

        //nummers[-1] = 10;
        Console.WriteLine(string.Join('_', nummers[6..^2]));

        int[,] matrix = new int[3,3] { {1,2,3}, {4,5,6}, {7,8,9} };

        Console.WriteLine(matrix[1, 1]);

        int[][] jagged = new int[2][];
        jagged[0] = [1,2,3,4,5];
        jagged[1] = [1,2];

        jagged[0] = [1,2,3];

    }
}
