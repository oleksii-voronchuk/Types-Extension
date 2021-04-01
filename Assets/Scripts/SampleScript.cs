using Assets.Tools.OLVOR.Scripts.Extensions;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class SampleScript : MonoBehaviour
    {
        [SerializeField] private List<Transform> transforms;
        float a = 0;
        private void Update()
        {

            if (Input.anyKey)
            {
                Debug.Log(a.Random(10, 11).ToString());
            }
        }
    }
}
