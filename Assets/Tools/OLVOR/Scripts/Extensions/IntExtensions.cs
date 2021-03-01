namespace Assets.Tools.OLVOR.Scripts.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// Changes the value of a variable to random within [minInclusive..maxInclusive] (range is inclusive).
        /// </summary>
        public static int Random(this ref int value, int minInclusive, int maxInclusive)
        {
            var newRandom = UnityEngine.Random.Range(minInclusive, maxInclusive);
            if (newRandom == value)
            {
                value = value == maxInclusive ? minInclusive : ++value;
            }
            else
            {
                value = newRandom;
            }

            return value;
        }
    }
}
