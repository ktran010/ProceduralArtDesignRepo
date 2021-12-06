using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace finalProject
{
    public class Section : MonoBehaviour
    {
      public GameObject item;
      public GameObject item2;
      public int amount;
      public float scale;
      public float rotateSlab;
      public float scaleOscillationOffset;
      // public float positionOscillationOffset;
      public Color[] colors;


      // Start is called before the first frame update
      public void Setup()
      {
        for(int i =0 ; i < amount; i++)
        {
            GameObject thisSection = Instantiate(item, this.transform);
            thisSection.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            thisSection.transform.localPosition = (Random.insideUnitSphere * 2);
            thisSection.transform.localScale = Vector3.one;

            GameObject thisSection2 = Instantiate(item2, thisSection.transform);
            thisSection2.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
            thisSection2.transform.localPosition = thisSection.transform.localPosition;
            thisSection2.transform.localEulerAngles =
            new Vector3(Random.Range(0, rotateSlab), Random.Range(0, rotateSlab), Random.Range(0, rotateSlab));
        }
      }


      // Update is called once per frame
      public void Draw()
      {
        float scaleMe = (Mathf.Sin(Time.time * Mathf.PI * 0.5f + scaleOscillationOffset)+1)*0.5f;
        scaleMe += 0.5f;
        scaleMe *= 0.3333f;

        // float posMe = (Mathf.Sin(Time.time * 2 + positionOscillationOffset));

        this.transform.localScale = new Vector3(scaleMe,scaleMe,scaleMe);
        // this.transform.localPosition += new Vector3(posMe,0,0);
      }
    }
}
