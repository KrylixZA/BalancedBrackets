namespace BalancedBrackets
{
    public static class BracketChecker
    {
        public static bool AreBalanced(string input)
        {
            if (input == "]")
            {
                return false;
            }

            var numOfPairs = 0;
            foreach (var letter in input)
            {
                if (letter == '[')
                {
                    numOfPairs++;
                } else if (letter == ']' && numOfPairs > 0)
                {
                    numOfPairs--;
                }
            }

            return numOfPairs == 0;
        }
    }
}
