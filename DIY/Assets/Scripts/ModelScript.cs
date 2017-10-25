using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelScript : MonoBehaviour
{
    public float v = 2.0F;
    public float h = 2.0F;
    public float z = 2.0F;


    void Start()
    {

    }

    void Update()
    {
            transform.Rotate(v, h, z);
    }

}
