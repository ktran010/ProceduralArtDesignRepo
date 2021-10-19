using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Art;

/*
 * This script instantiates an object and randomly positions, scales and colors the clones
 * It parents the items to the root object
 * so that they will be destroyed when 'rebuild' is true
 */

public class myEvenSimplerArtMaker3 : ArtMakerTemplate
{
    //assign this in the editor
    public GameObject shape;
    // public GameObject satellite;
    public float numDupes;
    public float size;

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
                g.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
            }

            Transform top = g.transform.GetChild(0); // top group
            top.GetChild(0).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeX of top
            top.GetChild(1).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY of top
            top.GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY1 of top
            top.GetChild(1).GetChild(1).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY2 of top
            top.GetChild(1).GetChild(2).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY3 of top

            Transform right = g.transform.GetChild(1); // right group
            right.GetChild(0).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeX of right
            right.GetChild(1).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY of right
            right.GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY1 of right
            right.GetChild(1).GetChild(1).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY2 of right
            right.GetChild(1).GetChild(2).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY3 of right

            Transform left = g.transform.GetChild(2); // left group
            left.GetChild(0).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeX of left
            left.GetChild(1).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY of left
            left.GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY1 of left
            left.GetChild(1).GetChild(1).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY2 of left
            left.GetChild(1).GetChild(2).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY3 of left

            Transform bottom = g.transform.GetChild(3); // bottom group
            bottom.GetChild(0).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeX of bottom
            bottom.GetChild(1).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY of bottom
            bottom.GetChild(1).GetChild(0).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY1 of bottom
            bottom.GetChild(1).GetChild(1).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY2 of bottom
            bottom.GetChild(1).GetChild(2).GetComponent<MeshRenderer>().material.color = Random.ColorHSV(); // planeY3 of bottom



            //a vector * a float returns a vector
            g.transform.localScale = Vector3.one * Random.value;
            //insideUnitSphere returns a random point inside or on a sphere with radius 1.0 (Read Only).
            Vector3 position = Random.insideUnitSphere * size;
            g.transform.position = new Vector3(position.x, position.y, position.z);
            //if we multiply that by 360 we get a random angle for each x,y,z axis from -360 to 360
            g.transform.localEulerAngles = Random.insideUnitSphere * 360;
        }
    }
}
