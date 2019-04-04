using System.Linq;

namespace StringCalculatorKata.Source
{
    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            if (numbers.Split(',').Count() == 2)
            {
                var first = numbers.Split(',').First();
                var second = numbers.Split(',').Last();

                return int.Parse(first) + int.Parse(second);
            }

            if (numbers.Split(',').Count() == 3)
            {
                var first = numbers.Split(',').First();
                var second = numbers.Split(',')[1];
                var third = numbers.Split(',').Last();

                return int.Parse(first) + int.Parse(second) + int.Parse(third);
            }

            if (numbers == string.Empty)
            {
                return 0;
            }

            return int.Parse(numbers);
        }
    }
}