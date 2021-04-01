using System;
using System.Collections.Generic;
using System.Linq;

namespace Assets.Tools.OLVOR.Scripts.Extensions
{
    /// <summary>
    /// Set of extensions for the List type.
    /// </summary>
    public static class ListExtensions
    {
        /// <summary>
        /// Creates a deep copy of the list.
        /// </summary>
        public static List<T> Clone<T>(this List<T> list) where T : ICloneable
        {
            return list.Select(item => (T)item.Clone()).ToList();
        }

        /// <summary>
        /// Creates a shallow copy of the list.
        /// </summary>
        public static List<T> ShallowCopy<T>(this List<T> list)
        {
            return list.ToList();
        }

        /// <summary>
        /// Shuffles items in the list.
        /// </summary>
        public static void Shuffle<T>(this List<T> list)
        {
            var sorted = list.OrderBy(a => Guid.NewGuid()).ToList();
            list.Clear();
            list.AddRange(sorted);
        }

        /// <summary>
        /// Removes last elements of the list
        /// </summary>
        public static void RemoveLast<T>(this List<T> list, int count)
        {
            if (count > list.Count) throw new ArgumentOutOfRangeException(nameof(count));
            list.RemoveRange(list.Count - count, count);
        }

        /// <summary>
        /// Removes last element in the list
        /// </summary>
        public static void RemoveLast<T>(this List<T> list)
        {
            RemoveLast(list, 1);
        }
    }
}
