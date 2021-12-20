using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Art;

/*
 * This script instantiates an object and randomly positions, scales and colors the clones
 * It parents the items to the root object
 * so that they will be destroyed when 'rebuild' is true
 */

public class MakeSection : ArtMakerTemplate
{
    //assign this in the editor
    public GameObject shape;
    // public GameObject satellite;
    public float numDupes;
    public float size;
    public Color[] colors;
    public Color[] colorsDark;

    public override void MakeArt()
    {
        for (int i = 0; i < numDupes; i++)
        {
            //Create a new gameObject variable and assign a clone of our shape
            GameObject g = Instantiate(shape);
            //parent to the 'root' object so that everytime you tap 'r' it will properly destroy and refresh
            g.transform.parent = root.transform;
            //Your 'shape' must have a meshrenderer or this script will give an error
            if (g.GetComponent<MeshRenderer>() != null)
            {
                g.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            }

            Transform ob1 = g.transform.GetChild(0);
            ob1.GetComponent<MeshRenderer>().material.color = colorsDark[Random.Range(0, colors.Length)];
            ob1.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            ob1.GetChild(0).GetChild(1).GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            ob1.GetChild(0).GetChild(2).GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];

            Transform ob2 = g.transform.GetChild(1);
            ob2.GetComponent<MeshRenderer>().material.color = colorsDark[Random.Range(0, colors.Length)];
            ob2.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            ob2.GetChild(0).GetChild(1).GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            ob2.GetChild(0).GetChild(2).GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];

            Transform ob3 = g.transform.GetChild(2);
            ob3.GetComponent<MeshRenderer>().material.color = colorsDark[Random.Range(0, colors.Length)];
            ob3.GetChild(0).GetChild(0).GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            ob3.GetChild(0).GetChild(1).GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            ob3.GetChild(0).GetChild(2).GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];

            //a vector * a float returns a vector
            g.transform.localScale = Vector3.one * Random.value;
            //insideUnitSphere returns a random point inside or on a sphere with radius 1.0 (Read Only).
            Vector3 position = Vector3.one * Random.value;
            g.transform.position = new Vector3(position.x, position.y, 0);
            //if we multiply that by 360 we get a random angle for each x,y,z axis from -360 to 360
            g.transform.localEulerAngles = new Vector3(Random.insideUnitSphere.x*360, Random.insideUnitSphere.y*360, 0);
        }
    }
}
