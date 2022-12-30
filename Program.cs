namespace NonStaticLineComparison
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program !!");

            NonStaticLineComp nonStaticLineComp = new NonStaticLineComp();
            nonStaticLineComp.calculateLengthLine();
            
        }
    }
}