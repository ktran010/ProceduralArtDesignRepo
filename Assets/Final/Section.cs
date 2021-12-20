// --------------------------------------------------------------------------
//                                 V1 CODE
// --------------------------------------------------------------------------
  // using System.Collections;
  // using System.Collections.Generic;
  // using UnityEngine;

  // namespace finalProject
  // {
  //     // this script attached to Section1-2 (empty game object)
  //     // this script will instantiate Cube1 and Cube2
  //     // this script is managed by SectionManager
  //     public class Section : MonoBehaviour
  //     { 
  //       public GameObject item;
  //       public GameObject item2;
  //       public GameObject item3;
  //       public GameObject item4;
  //       public int amount;
  //       public int amount2;
  //       public float scale;
  //       public float rotateSlab;
  //       public float scaleOscillationOffset;
  //       // public float positionOscillationOffset;
  //       public Color[] colors;
  //       public Color[] colors2;


  //       // Start is called before the first frame update
  //       public void Setup()
  //       {
  //         for(int i =0 ; i < amount; i++)
  //         {
  //             GameObject thisSection = Instantiate(item, this.transform);
  //             thisSection.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
  //             thisSection.transform.localPosition = (Random.insideUnitSphere * 2);
  //             thisSection.transform.localScale = new Vector3(scale, scale, scale);

  //             GameObject thisSection2 = Instantiate(item2, thisSection.transform);
  //             thisSection2.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
  //             thisSection2.transform.localPosition = thisSection.transform.localPosition;
  //             thisSection2.transform.localScale = new Vector3((float)0.5/scale, (float)1/scale, (float)0.5/scale);
  //             thisSection2.transform.localEulerAngles =
  //             new Vector3(Random.Range(0, rotateSlab), Random.Range(0, rotateSlab), Random.Range(0, rotateSlab));
  //         }
          
  //         for(int i = 0; i < amount2; i++)
  //         {
  //             GameObject thisSection3 = Instantiate(item3, this.transform);
  //             thisSection3.GetComponent<MeshRenderer>().material.color = colors2[Random.Range(0, colors.Length)];
  //             thisSection3.transform.localPosition = (Random.insideUnitSphere * 4);
  //             thisSection3.transform.localScale = new Vector3(scale/2, scale/2, scale/2);

  //             GameObject thisSection4 = Instantiate(item4, thisSection3.transform);
  //             thisSection4.GetComponent<MeshRenderer>().material.color = colors2[Random.Range(0, colors.Length)];
  //             thisSection4.transform.localPosition = thisSection3.transform.localPosition;
  //             thisSection4.transform.localScale = new Vector3((float)0.5/scale/2, (float)1/scale/2, (float)0.5/scale/2);
  //             thisSection4.transform.localEulerAngles =
  //             new Vector3(Random.Range(0, rotateSlab), Random.Range(0, rotateSlab), Random.Range(0, rotateSlab));
  //         }
  //       }


  //       // Update is called once per frame
  //       public void Draw()
  //       {
  //         float scaleMe = (Mathf.Sin(Time.time * Mathf.PI * 0.5f + scaleOscillationOffset)+1)*0.5f;
  //         scaleMe += 0.5f;
  //         scaleMe *= 0.3333f;

  //         // float posMe = (Mathf.Sin(Time.time * 2 + positionOscillationOffset));

  //         this.transform.localScale = new Vector3(scaleMe,scaleMe,scaleMe);
  //         // this.transform.localPosition += new Vector3(posMe,0,0);
  //       }
  //     }
  // }



// --------------------------------------------------------------------------
//                                 V2 CODE
// --------------------------------------------------------------------------
  // using System.Collections;
  // using System.Collections.Generic;
  // using UnityEngine;

  // namespace finalProject
  // {
  //     // this script attached to Section1-2 (empty game object)
  //     // this script will instantiate Cube1 and Cube2
  //     // this script is managed by SectionManager
  //     public class Section : MonoBehaviour
  //     { 
  //       public GameObject item;
  //       public GameObject item2;
  //       public GameObject item3;
  //       public GameObject item4;
  //       public int amount;
  //       public int amount2;
  //       public float scale;

  //       public float rotateSlab;

  //       public float scaleOscillationOffset;

  //       public float positionOscillationOffset;
  //       public float speed;
        
  //       public Color[] colors;
  //       public Color[] colorsDark;
  //       public Color[] colors2;
  //       public Color[] colors2Dark;
  //       public Color[] colors3;
  //       public Color[] colors3Dark;


  //       // Start is called before the first frame update
  //       public void Setup()
  //       {
  //         float rand;

  //         for(int i = 0 ; i < amount; i++)
  //         {
  //             GameObject thisSection = Instantiate(item, this.transform);
  //             thisSection.GetComponent<MeshRenderer>().material.color = colors3[Random.Range(0, colors.Length)];
  //             thisSection.transform.localPosition = new Vector3(scale, scale, scale)*i;
  //             thisSection.transform.localScale = new Vector3(scale, scale, scale);

  //             rand = Random.insideUnitSphere.x*i;
  //             GameObject thisSection2 = Instantiate(item2);
  //             thisSection2.GetComponent<MeshRenderer>().material.color = colors3Dark[Random.Range(0, colors.Length)];
  //             thisSection2.transform.localPosition = thisSection.transform.localPosition + new Vector3(0, 0, (float)20);
  //             thisSection2.transform.localScale = new Vector3((float)1/scale, (float)5/scale, (float)3/scale);
  //             thisSection2.transform.parent = thisSection.transform;
  //         }
          
  //         for(int i = 0; i < amount2; i++)
  //         {
  //             GameObject thisSection3 = Instantiate(item3, this.transform);
  //             thisSection3.GetComponent<MeshRenderer>().material.color = colorsDark[Random.Range(0, colors.Length)];
  //             thisSection3.transform.localPosition = new Vector3(scale, scale, scale)*i;
  //             thisSection3.transform.localScale = new Vector3(scale, scale, scale);

  //             rand = Random.insideUnitSphere.x*i;
  //             GameObject thisSection4 = Instantiate(item4);
  //             thisSection4.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
  //             thisSection4.transform.localPosition = thisSection3.transform.localPosition + new Vector3(0, 0, (float)20);
  //             thisSection4.transform.localScale = new Vector3((float)1/scale/2, (float)5/scale/2, (float)3/scale/2);
  //             thisSection4.transform.parent = thisSection3.transform;
  //         }
  //       }


  //       // Update is called once per frame
  //       public void Draw()
  //       {
  //         float scaleMe = (Mathf.Sin(Time.time * Mathf.PI * 0.5f + scaleOscillationOffset)+1)*0.5f;
  //         scaleMe += 0.5f;
  //         scaleMe *= 0.3333f;

  //         float posMe = Mathf.Sin(Time.time*speed + positionOscillationOffset);

  //         this.transform.localScale = new Vector3(scaleMe,scaleMe,scaleMe);
          
  //         for(int i = 0; i < this.transform.childCount; i++)
  //         {
  //           this.transform.GetChild(i).localPosition = new Vector3(posMe,0,0)*i;
  //           for(int j = 0; j < this.transform.GetChild(i).childCount; j++)
  //           {
  //              this.transform.GetChild(i).GetChild(j).localPosition = new Vector3(0,posMe/2,0)*i;
  //           }
  //         }

  //         // this.transform.GetChild(0).localPosition = new Vector3(posMe*2,0,0);
  //         // this.transform.GetChild(1).localPosition = new Vector3(0,posMe*3,0);
  //         // this.transform.GetChild(2).localPosition = new Vector3(posMe*2,0,0);
  //         // this.transform.GetChild(3).localPosition = new Vector3(0,posMe*3,0);
  //       }
  //     }
  // }


// --------------------------------------------------------------------------
//                                 V3 CODE
// --------------------------------------------------------------------------
  using System.Collections;
  using System.Collections.Generic;
  using UnityEngine;

  namespace finalProject
  {
      // this script attached to Section1-2 (empty game object)
      // this script will instantiate Cube1 and Cube2
      // this script is managed by SectionManager
      public class Section : MonoBehaviour
      { 
        public GameObject item;
        public GameObject item2;
        public GameObject item3;
        public GameObject item4;
        public GameObject item5;
        public int amount;
        public int amount2;
        public int amount3;
        public float scale;

        public float rotatePlane;
        public float rotateSlab;

        public float scaleOscillationOffset;

        public float positionOscillationOffset;
        public float speed;
        
        public Color[] colors;
        public Color[] colorsDark;
        public Color[] colors2;
        public Color[] colors2Dark;
        public Color[] colors3;
        public Color[] colors3Dark;


        // Start is called before the first frame update
        public void Setup()
        {
          float rand;

          for(int i = 0 ; i < amount; i++)
          {
              GameObject thisSection = Instantiate(item, this.transform);
              thisSection.GetComponent<MeshRenderer>().material.color = colors[Random.Range(0, colors.Length)];
              thisSection.transform.localPosition = new Vector3(scale, scale, scale)*i;
              thisSection.transform.localScale = new Vector3(scale, scale, scale);
          }
          
          for(int i = 0; i < amount2; i++) // planes
          {
              GameObject thisSection2 = Instantiate(item2);
              thisSection2.GetComponent<MeshRenderer>().material.color = colors2[Random.Range(0, colors.Length)];
              thisSection2.transform.localPosition = new Vector3(scale, scale, scale)*i + new Vector3((float)20, 0, (float)20);
              thisSection2.transform.localScale = new Vector3((float)5/scale, (float)5/scale, (float)0.1/scale);
              thisSection2.transform.parent = this.transform;

              rand = Random.insideUnitSphere.x*i;
              GameObject thisSection3 = Instantiate(item3);
              thisSection3.GetComponent<MeshRenderer>().material.color = colors2Dark[Random.Range(0, colors.Length)];
              thisSection3.transform.localPosition = new Vector3(scale, scale, scale)*i + new Vector3(-(float)20, 0, (float)20);
              thisSection3.transform.localScale = new Vector3((float)5/scale, (float)5/scale, (float)0.1/scale);
              thisSection3.transform.parent = thisSection2.transform;
          }

          for(int i = 0; i < amount3; i++) // slabs
          {
              GameObject thisSection4 = Instantiate(item4);
              thisSection4.GetComponent<MeshRenderer>().material.color = colors3[Random.Range(0, colors.Length)];
              thisSection4.transform.localPosition = new Vector3(scale, scale, scale)*i + new Vector3((float)20, 0, (float)20);
              thisSection4.transform.localScale = new Vector3((float)0.5/scale, (float)5/scale, (float)0.5/scale);
              thisSection4.transform.parent = this.transform;

              rand = Random.insideUnitSphere.x*i;
              GameObject thisSection5 = Instantiate(item5);
              thisSection5.GetComponent<MeshRenderer>().material.color = colorsDark[Random.Range(0, colors.Length)];
              thisSection5.transform.localPosition = new Vector3(scale, scale, scale)*i + new Vector3(-(float)20, 0, (float)20);
              thisSection5.transform.localScale = new Vector3((float)0.5/scale, (float)5/scale, (float)0.5/scale);
              thisSection5.transform.parent = thisSection4.transform;
          }
        }


        // Update is called once per frame
        public void Draw()
        {
          float scaleMe = (Mathf.Sin(Time.time * Mathf.PI * 0.5f + scaleOscillationOffset)+1)*0.5f;
          scaleMe += 0.5f;
          scaleMe *= 0.3333f;

          float posMe = Mathf.Sin(Time.time*speed + positionOscillationOffset);

          this.transform.localScale = new Vector3(scaleMe,scaleMe,scaleMe);
          
          for(int i = 0; i < this.transform.childCount; i++)
          {
            this.transform.GetChild(i).localPosition = new Vector3(posMe,0,posMe)*i;
            for(int j = 0; j < this.transform.GetChild(i).childCount; j++)
            {
               this.transform.GetChild(i).GetChild(j).localPosition = new Vector3(0,posMe/2,0)*i;
            }
          }

          // this.transform.GetChild(0).localPosition = new Vector3(posMe*2,0,0);
          // this.transform.GetChild(1).localPosition = new Vector3(0,posMe*3,0);
          // this.transform.GetChild(2).localPosition = new Vector3(posMe*2,0,0);
          // this.transform.GetChild(3).localPosition = new Vector3(0,posMe*3,0);
        }
      }
  }