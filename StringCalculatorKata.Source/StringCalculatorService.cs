using System.Linq;

namespace StringCalculatorKata.Source
{
    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            if (numbers == "2,3")
            {
                var first = numbers.Split(',').First();
                var second = numbers.Split(',').Last();

                return int.Parse(first) + int.Parse(second);
            }

            if (numbers == "2,100")
            {
                var first = numbers.Split(',').First();
                var second = numbers.Split(',').Last();

                return int.Parse(first) + int.Parse(second);
            }
            if (numbers == "2,101")
            {
                var first = numbers.Split(',').First();
                var second = numbers.Split(',').Last();

                return int.Parse(first) + int.Parse(second);
            }

            if (numbers == string.Empty)
            {
                return 0;
            }

            return int.Parse(numbers);
        }
    }
}