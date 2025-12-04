namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            string a = "";
            int n1 = 0;
            int n2 = 1;
            a += $"{n1} {n2} ";
            for (int i = 0; i < 8; i++) 
            {
                int next =n1+n2 ;
                a +=$"{next} ";
                n1 = n2;
                n2 = next;
            }
            Console.WriteLine("number 1, fibbonachi:");
            Console.WriteLine(a);
            //2
            a = "";
            for (int i = 2; i <= 20; i += 2)
            {
                a += i.ToString() + " ";
            }
            Console.WriteLine("number 2, even numbers:");
            Console.WriteLine(a);
            //3
            a = "";
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    a += $"{i}*{j}={i*j} ";
                }
                a += "\n";
            }
            Console.WriteLine("number 3, multiplication table:");
            Console.WriteLine(a);
            //4
            string password = "qwerty";
            string h = "";
            Console.WriteLine("Enter password:");
            do
            {
                h = Console.ReadLine();
                
            } 
            while (h != password);
            Console.WriteLine("Finally");  
        }
    }
}