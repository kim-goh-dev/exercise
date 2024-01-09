namespace CodingForFun
{
    public class PrintTriangle
    {
        public void PrintTriangleResult()
        {
            int star = 7;
            int length = 4;
            for (int i = 0; i < length; i++)
            {
                var numberOfSpaces = 2 * i;
                for (int j = 0; j < numberOfSpaces; j++)
                {
                    Console.Write(" ");
                }

                // print *
                for (int j = 0; j < star; j++)
                {
                    Console.Write("* ");
                }

                star -= 2;
                Console.WriteLine("");
            }
        }
    }
}
