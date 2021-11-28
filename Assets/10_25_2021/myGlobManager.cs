using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ------------------------------------   PAGE 1   -------------------------------------

// public class myGlobManager : MonoBehaviour
// {
//     public myGlob glob;
//     public int amount;
//     public float noiseFreq;
//     public float maxScale;
//     // myGlob[] globArray;
//     // suggest addiing more public variables to control in manager instead of inside code

//     public void ReBuild()
//     {
//         // for(int i = 0; i < amount; i+=(Random.Range(0,3)))
//         for(int i = 0; i < amount; i++)
//         {
//           // for(int j = 0; j< amount; j+=(Random.Range(0,3)))
//           for(int j = 0; j< Random.Range(1, amount); j++)
//           {
//             //   // page 1
//             //   // GameObject thisGlob = Instantiate(glob.gameObject, this.transform);
//             //   myGlob thisGlob = Instantiate(glob.gameObject, this.transform).GetComponent<myGlob>();
//             //   thisGlob.transform.localPosition = new Vector3(i, j, 0);
//             //   thisGlob.ReBuild();

//             // page 2
//             // GameObject thisGlob = Instantiate(glob.gameObject, this.transform);
//             myGlob thisGlob = Instantiate(glob.gameObject, this.transform).GetComponent<myGlob>();
//             // myGlob thisGlob = Instantiate(globArray[Random.Range(0, globArray.Length)].gameObject, this.transform).GetComponent<myGlob>();

//             thisGlob.amount = i * 2;
//             // thisGlob.scale = i * 0.3f;
//             float noiseScale = Mathf.PerlinNoise(i * noiseFreq, j*noiseFreq)* maxScale;
//             thisGlob.scale = noiseScale;

//             thisGlob.transform.localPosition = new Vector3(i, j, 0);
//             // thisGlob.scale = (float)Random.Range((int)ScaleY.x, (int)ScaleY.y);

//             // myGlob thisGlobChild1 = Instantiate(thisGlob.transform.GetChild(0).gameObject, thisGlob.transform).GetComponent<myGlob>();
//             // // thisGlobChild1.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();

//             // thisGlobChild1.transform.localPosition = new Vector3(i, j, 0);
//             // thisGlobChild1.scale = (float)Random.Range((int)ScaleY.x, (int)ScaleY.y);
//             // thisGlobChild1.rotation = new Vector3(90, 125, 0);
//             // // (float)Random.Range((int)rotateY.x, (int)rotateY.y);

//             thisGlob.ReBuild();
//             // thisGlobChild1.ReBuild();
//           }
//         }
//     }
// }

// ------------------------------------   PAGE 2   -------------------------------------

// public class myGlobManager : MonoBehaviour
// {
//     public myGlob glob;
//     public int amount;
//     public float radius;
//     public float maxAngle;
//     public float noiseFreq;
//     public float maxScale;

//     // float angle, radius = 50;
//     // float angleSpeed = 10;
//     // float radialSpeed = 0.5f;
 
//     // myGlob[] globArray;
//     // suggest addiing more public variables to control in manager instead of inside code

//     public void ReBuild()
//     {
//         myGlob rotateAroundMe = Instantiate(glob.gameObject, this.transform).GetComponent<myGlob>();

//         for(int h = 1; h < amount; h++)
//         {
//           myGlob outGlob = Instantiate(glob.gameObject, this.transform).GetComponent<myGlob>();
//           outGlob.transform.localEulerAngles = new Vector3(0,0, h * 100);

//           for(int i = 1; i < amount*1.5; i++)
//           {
//             myGlob thisGlob = Instantiate(glob.gameObject, outGlob.transform).GetComponent<myGlob>();
//             thisGlob.amount = i * 2;
//             thisGlob.transform.localPosition = new Vector3(i,Mathf.Sin(i * Random.Range(0,maxAngle))*radius,0);
//             // thisGlob.transform.RotateAround(rotateAroundMe.transform.position, Vector3.up, 40 * Time.deltaTime);
//             float noiseScale = Mathf.PerlinNoise(i * noiseFreq, (i*2)*noiseFreq)* maxScale;
//             thisGlob.scale = noiseScale;

//             // angle += Time.deltaTime * angleSpeed;
//             // radius -= Time.deltaTime * radialSpeed;
        
//             // float x = radius * Mathf.Cos(Mathf.Deg2Rad*angle);
//             // float z = radius * Mathf.Sin(Mathf.Deg2Rad*angle);
//             // float y = transform.position.y;

//             // thisGlob.transform.localPosition = new Vector3(x, y, z);

//             // thisGlob.transform.RotateAround(rotateAroundMe.transform.position, Vector3.up, 40 * Time.deltaTime);


//             thisGlob.ReBuild();
//           }

//         }
//     }
// }

// ------------------------------------   PAGE 3   -------------------------------------

public class myGlobManager : MonoBehaviour
{
    public myGlob glob;
    public int amount;
    public float noiseFreq;
    public float maxScale;
    public int radiusMin;
    public int radiusMax;

    // public LayerMask m_LayerMask;

    public void ReBuild()
    {
        int rad = Random.Range(radiusMin, radiusMax);
        int rad2 = rad * 2;
        int rad3 = rad * 3;
        
        for(int h = 1; h < amount; h++)
        {
          myGlob outGlob = Instantiate(glob.gameObject, this.transform).GetComponent<myGlob>();
          outGlob.transform.localPosition = new Vector3(0, 0,0);
        
          for(int i = 0; i < amount; i++)
          {
            for(int j = 0; j< amount; j++)
            {
              myGlob thisGlob = Instantiate(glob.gameObject, outGlob.transform).GetComponent<myGlob>();
          
              thisGlob.amount = i * 2;
              // thisGlob.scale = i * 0.3f;
              // float noiseScale = Mathf.PerlinNoise(i * noiseFreq, j*noiseFreq)* maxScale;
              // thisGlob.scale = noiseScale;

              // thisGlob.transform.localPosition = Random.insideUnitSphere*randomSphere;

              // //Use the OverlapBox to detect if there are any other colliders within this box area.
              // //Use the GameObject's centre, half the size (as a radius) and rotation. This creates an invisible box around your GameObject.
              // Collider[] hitColliders = Physics.OverlapBox(thisGlob.transform.localPosition, transform.localScale / 2, Quaternion.identity, m_LayerMask);
              // int k = 0;
              // //Check when there is a new collider coming into contact with the box
              // while (k < hitColliders.Length)
              // {
              //     //Output all of the collider names
              //     thisGlob.ReBuild();
              //     //Increase the number of Colliders in the array
              //     k++;
              // }

              float angle = j * Mathf.PI*2.0f / amount;
              Vector3 newPos = new Vector3(Mathf.Cos(angle)*rad, Mathf.Sin(angle)*rad, 0);
              thisGlob.transform.localPosition = newPos;

              thisGlob.ReBuild();
            }

            for(int k = 0; k< amount; k++)
            {
              myGlob thisGlob = Instantiate(glob.gameObject, outGlob.transform).GetComponent<myGlob>();
          
              thisGlob.amount = i * 2;

              float angle = k * Mathf.PI*2.0f / amount;
              Vector3 newPos = new Vector3(Mathf.Cos(angle)*rad2, Mathf.Sin(angle)*rad2, 0);
              thisGlob.transform.localPosition = newPos;

              thisGlob.ReBuild();
            }

            for(int l = 0; l< amount; l++)
            {
              myGlob thisGlob = Instantiate(glob.gameObject, outGlob.transform).GetComponent<myGlob>();
          
              thisGlob.amount = i * 2;
              
              float angle = l * Mathf.PI*2.0f / amount;
              Vector3 newPos = new Vector3(Mathf.Cos(angle)*rad3, Mathf.Sin(angle)*rad3, 0);
              thisGlob.transform.localPosition = newPos;

              thisGlob.ReBuild();
            }
          }
        }
    }
}