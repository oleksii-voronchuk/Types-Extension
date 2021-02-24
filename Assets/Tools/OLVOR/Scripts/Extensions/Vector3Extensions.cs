using UnityEngine;

namespace Assets.Tools.OLVOR.Scripts.Extensions
{
    /// <summary>
    /// Set of extensions for the Vector3 type.
    /// </summary>
    public static class Vector3Extensions
    {
        /// <summary>
        /// Set x value of an existing Vector3.
        /// </summary>
        public static void ChangeX(this ref Vector3 vector, float value)
        {
            vector.Set(value, vector.y, vector.z);
        }

        /// <summary>
        /// Set y value of an existing Vector3.
        /// </summary>
        public static void ChangeY(this ref Vector3 vector, float value)
        {
            vector.Set(vector.x, value, vector.z);
        }

        /// <summary>
        /// Set z value of an existing Vector3.
        /// </summary>
        public static void ChangeZ(this ref Vector3 vector, float value)
        {
            vector.Set(vector.x, vector.y, value);
        }

        /// <summary>
        /// Set random values of x, y, z within [minInclusive..maxInclusive] (range is inclusive). Then returns the vector.
        /// </summary>
        public static Vector3 Random(this ref Vector3 vector, float minInclusive, float maxInclusive)
        {
            vector.Set(UnityEngine.Random.Range(minInclusive, maxInclusive), UnityEngine.Random.Range(minInclusive, maxInclusive), UnityEngine.Random.Range(minInclusive, maxInclusive));
            return vector;
        }
    }
}
