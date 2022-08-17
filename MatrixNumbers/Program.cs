using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixNumbers {
    internal class Program {
        static void Main(string[] args) {

            int[,] matrix = new int[3, 4];

            for (int i = 0; i < 3; i++) {
                Console.Write($"Números da Linha {i + 1}: ");
                string[] vect = Console.ReadLine().Split(' ');
                for (int j = 0; j < 4; j++) {
                    matrix[i, j] = int.Parse(vect[j]);
                }
            }
            //Console.WriteLine(matrix.Length);
            Console.WriteLine();
            Console.Write("Número procurado: ");
            int num = int.Parse(Console.ReadLine());
            int[] row = new int[10];
            int[] col = new int[10];
            int found = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 4; j++) {
                    if (matrix[i, j] == num) {
                        found++;
                        row[found] = i;
                        col[found] = j;
                    }
                }
            }
            for (int i = 0; i < found; i++) {
                Console.WriteLine($"Posição: {row[i+1]}, {col[i+1]}");
                if (col[i+1]-1 >= 0) Console.WriteLine($"Esquerda: {matrix[row[i+1], col[i+1]-1]}");
                if (col[i+1]+1 < 4) Console.WriteLine($"Direita: {matrix[row[i+1], col[i+1]+1]}");
                if (row[i+1]-1 >= 0) Console.WriteLine($"Acima: {matrix[row[i+1]-1, col[i+1]]}");
                if (row[i+1]+1 < 3) Console.WriteLine($"Abaixo: {matrix[row[i+1]+1, col[i+1]]}");
            }
        }
    }
}
