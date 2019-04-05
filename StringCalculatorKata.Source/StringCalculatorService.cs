using System.Linq;

namespace StringCalculatorKata.Source
{
    public class StringCalculatorService
    {
        public int Add(string numbers)
        {
            var splitNumbers = numbers.Split(',');

            if (splitNumbers.Count() == 2)
            {
                var first = splitNumbers.First();
                var second = splitNumbers.Last();

                return int.Parse(first) + int.Parse(second);
            }

            if (splitNumbers.Count() == 3)
            {
                var first = splitNumbers.First();
                var second = splitNumbers[1];
                var third = splitNumbers.Last();

                return int.Parse(first) + int.Parse(second) + int.Parse(third);
            }

            if (splitNumbers.Count() == 4)
            {
                var first = splitNumbers.First();
                var second = splitNumbers[1];
                var third = splitNumbers[2];
                var fourth = splitNumbers.Last();

                return int.Parse(first) + int.Parse(second) + int.Parse(third) + int.Parse(fourth);
            }

            if (numbers == string.Empty)
            {
                return 0;
            }

            return int.Parse(numbers);
        }
    }
}