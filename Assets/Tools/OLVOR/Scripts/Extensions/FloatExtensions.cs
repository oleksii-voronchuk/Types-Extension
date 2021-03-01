using System;

namespace Assets.Tools.OLVOR.Scripts.Extensions
{
    public static class FloatExtensions
    {
        /// <summary>
        /// Changes the value of a variable to random within [minInclusive..maxInclusive] (range is inclusive).
        /// </summary>
        public static float Random(this ref float value, float minInclusive, float maxInclusive)
        {
            var newRandom = UnityEngine.Random.Range(minInclusive, maxInclusive);
            if (Math.Abs(newRandom - value) < 0.001f)
            {
                value = value + 1 >= maxInclusive ? minInclusive : ++value;
            }
            else
            {
                value = newRandom;
            }

            return value;
        }
    }
}
