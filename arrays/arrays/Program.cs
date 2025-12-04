namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("number 1:");
            Console.WriteLine("Fibbonachi array");
            int[] fibbonachi = [0, 1, 1, 2, 3, 5, 8, 13];
            Array.ForEach(fibbonachi, Console.WriteLine);
            //2
            Console.WriteLine("");
            Console.WriteLine("number 2:");
            Console.WriteLine("Months");
            string[] months = ["january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december"];
            Array.ForEach(months, Console.WriteLine);
            //3
            Console.WriteLine("");
            Console.WriteLine("number 3:");
            Console.WriteLine("Matrix");
            int[][] matrix = [[2,3,4], [4,9,16], [8,27,64]];
            foreach (int[] inner in matrix)
            {
                string a = "";
                foreach(int value in inner)
                {
                    a += value.ToString()+" ";
                }
                Console.WriteLine(a);
            }
            //4
            Console.WriteLine("");
            Console.WriteLine("number 4:");
            Console.WriteLine("Jagged");
            double[][] jagged = [[1, 2, 3, 4, 5], [Math.E, Math.PI],[Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000)]];
            foreach (double[] inner in jagged)
            {
                string a = "";
                foreach (double value in inner)
                {
                    a += value.ToString() + " ";
                }
                Console.WriteLine(a);
            }

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };

            //5
            Array.Copy(array, array2, 3);
            Console.WriteLine("number 5:");
            Console.WriteLine("1st array");
            Array.ForEach(array, Console.WriteLine);
            Console.WriteLine("");
            Console.WriteLine("2nd array");
            Array.ForEach(array2, Console.WriteLine);
            Console.WriteLine("");
            Console.WriteLine("");

            //6
            Array.Resize(ref array, array.Length*2);
            Console.WriteLine("number 6:");
            Console.WriteLine("1st array");
            Array.ForEach(array, Console.WriteLine);
            Console.WriteLine("");
            Console.WriteLine("2nd array");
            Array.ForEach(array2, Console.WriteLine);
        }
    }
}