using System.Collections.Generic;
using UnityEngine;

namespace Assets.Tools.OLVOR.Scripts.Extensions
{
    public static class RandomExtensions
    {
        /// <summary>
        /// Return the array of unique random integers within [minInclusive..maxInclusive] (range is inclusive).
        /// </summary>
        public static int[] RandomIntArray(int count, int minInclusive, int maxInclusive)
        {
            var array = new int[count];
            var availableInts = new List<int>();

            for (var i = minInclusive; i <= maxInclusive; i++)
            {
                availableInts.Add(i);
            }

            if (count > availableInts.Count) return array;
            for (var i = 0; i < count; i++)
            {
                var value = Random.Range(0, availableInts.Count);
                array[i] = value;
                availableInts.Remove(value);
            }

            return array;
        }
    }
}
