using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  public class myGlob : MonoBehaviour
  {
      public GameObject juice;
      public GameObject juiceShader;
      public int amount;

      public float scale;
      public Vector2 minPos;
      public Vector2 maxPos;
      public Color[] colors;
    //   public GameObject[] globArray;

      // important for every element inside glob should have a single parent
      // we can use whatever object that myGlob script is attached to, that will be the parent

      public void ReBuild(){
          for(int i=0; i< amount; i++)
          {
            //   // page 1
            //   GameObject thisJuice = Instantiate(juice);
            //   thisJuice.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            //   thisJuice.transform.parent = this.transform;
            //   // can also do the following line, which instantly parents the object
            //   // GameObject thisJuice = Instantiate(juice, this.transform);
            //   thisJuice.transform.localPosition = Random.insideUnitSphere*2;
            //   thisJuice.transform.localScale = new Vector3(0.3f, Random.Range(0.1f,scale),0.1f);

             // page 2
            GameObject thisJuice = Instantiate(juice);
            // GameObject thisJuice = Instantiate(globArray[Random.Range(0, globArray.Length)].gameObject, this.transform);
            thisJuice.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            thisJuice.transform.parent = this.transform;
            // can also do the following line, which instantly parents the object
            // GameObject thisJuice = Instantiate(juice, this.transform);
            // thisJuice.transform.localPosition =
            // new Vector3((float)Random.Range((int)minPos.x, (int)maxPos.x),
            // (float)Random.Range((int)minPos.y, (int)maxPos.y), 0);

            // thisJuice.transform.localPosition = new Vector3(Random.Range(-0.25f, 0.25f), Random.Range(-0.25f, 0.25f), 0);
            thisJuice.transform.localPosition = Random.insideUnitSphere;
            thisJuice.transform.localScale = new Vector3(0.3f, Random.Range(0.1f,scale),0.1f);

            GameObject thisJuiceShader = Instantiate(juiceShader);
            thisJuiceShader.GetComponent<MeshRenderer>().material.color = thisJuice.GetComponent<MeshRenderer>().material.color - new Color(0.7f, 0.7f, 0.7f);
            thisJuiceShader.transform.parent = thisJuice.transform;
            thisJuiceShader.transform.localPosition = thisJuice.transform.localPosition + new Vector3(0, 0, 3);
            thisJuiceShader.transform.localScale = thisJuice.transform.localScale + new Vector3(1, 1, 1);
          }
      }
  }
