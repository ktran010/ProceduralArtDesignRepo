using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace szetelaArt
{
    public class pixels : MonoBehaviour
    {
        public GameObject front;
        public GameObject back;
        public int amountPixels;

        public float scale;
        public float scaleOscillationOffset;
        // public float positionOscillationOffset;
        // public Vector2 minPos;
        // public Vector2 maxPos;
        public Color[] colors;

        public void Setup(){
            for(int i=0; i < amountPixels; i++)
            {
                GameObject thisPixelFront = Instantiate(front, this.transform);
                thisPixelFront.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
                thisPixelFront.transform.localPosition = (Random.insideUnitSphere * 0.5f);
                // thisPixelFront.transform.localEulerAngles = new Vector3(0, 0, ((float)i / (float)amountPixels)*360);
                thisPixelFront.transform.localScale = Vector3.one;

                GameObject thisPixelBack = Instantiate(back, thisPixelFront.transform);
                thisPixelBack.GetComponent<MeshRenderer>().material.color = thisPixelFront.GetComponent<MeshRenderer>().material.color - new Color(0.7f, 0.7f, 0.7f);
                thisPixelBack.transform.localPosition = thisPixelFront.transform.localPosition + new Vector3(0, 0, 3);
                thisPixelBack.transform.localScale = thisPixelFront.transform.localScale + new Vector3(1, 1, 1);
                thisPixelBack.transform.localEulerAngles = thisPixelFront.transform.localEulerAngles + new Vector3(1, 1, 1);
            }
        }

        public void Draw(){
            float scaleMe = (Mathf.Sin(Time.time * Mathf.PI * 0.5f + scaleOscillationOffset)+1)*0.5f;
            scaleMe += 0.5f;
            scaleMe *= 0.3333f;

            // float posMe = (Mathf.Sin(Time.time * 2 + positionOscillationOffset));

            this.transform.localScale = new Vector3(scaleMe,scaleMe,scaleMe);
            // this.transform.localPosition += new Vector3(posMe,0,0);
        }
    }
}

