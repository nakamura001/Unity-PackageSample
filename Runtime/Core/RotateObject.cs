using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PackageSample.SampleCode
{
    public class RotateObject : MonoBehaviour
    {
        Transform trans;
        void Start()
        {
            trans = gameObject.transform;
        }

        void Update()
        {
            trans.Rotate(0, 30.0f * Time.deltaTime, 0);
        }
    }
}