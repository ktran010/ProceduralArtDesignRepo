using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myParametricModeling : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh m = Grid.Generate(100, 100, Plane);
        GetComponent<MeshFilter>().mesh = m;
    }

    Vector3 Plane(float u, float v)
    {
        return new Vector3(u, v, Mathf.Cos(u*v*Mathf.PI)+(u*v));
    }
}
