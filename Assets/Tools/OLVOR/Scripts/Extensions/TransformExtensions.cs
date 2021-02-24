using UnityEngine;

namespace Assets.Tools.OLVOR.Scripts.Extensions
{
    /// <summary>
    /// Set of extensions for the Transform type.
    /// </summary>
    public static class TransformExtensions
    {
        /// <summary>
        /// Destroys all child objects of the transform.
        /// </summary>
        public static void DestroyChildren(this Transform transform)
        {
            for (var i = 0; i < transform.childCount; i++)
            {
                Object.Destroy(transform.GetChild(i).gameObject);
            }
        }

        /// <summary>
        ///Set the values of position and rotation of the transform as in the instance.
        /// </summary>
        public static void SetValuesAs(this Transform transform, Transform instance)
        {
            transform.position = instance.position;
            transform.rotation = instance.rotation;
        }

        /// <summary>
        /// Set the values of local position, local scale and local rotation of the transform as in the instance.
        /// </summary>
        public static void SetLocalValuesAs(this Transform transform, Transform instance)
        {
            transform.localPosition = instance.localPosition;
            transform.localScale = instance.localScale;
            transform.localRotation = instance.localRotation;
        }

        /// <summary>
        /// Set the values of local position, local scale and local rotation of the transform to the default values.
        /// </summary>
        public static void Reset(this Transform transform)
        {
            transform.localPosition = Vector3.zero;
            transform.localScale = Vector3.one;
            transform.localRotation = Quaternion.identity;
        }

        /// <summary>
        /// Set the parent of the transform. Then reset the values of local position, local scale and local rotation of the transform to the default values.
        /// </summary>
        public static void SetParentAndReset(this Transform transform, Transform parent)
        {
            transform.SetParent(parent);
            transform.Reset();
        }
    }
}
