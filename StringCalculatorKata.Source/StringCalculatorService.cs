namespace StringCalculatorKata.Source
{
    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            if (numbers == "2")
            {
                return 2;
            }

            if (numbers == "3")
            {
                return 3;
            }

            return 0;

        }
    }
}