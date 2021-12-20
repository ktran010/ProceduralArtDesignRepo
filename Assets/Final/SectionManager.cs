// --------------------------------------------------------------------------
//                                 V1 CODE
// --------------------------------------------------------------------------
    // using System.Collections;
    // using System.Collections.Generic;
    // using UnityEngine;


    // namespace finalProject
    // {
    //     public class SectionManager : MonoBehaviour
    //     {
    //         public Section sections1;
    //         List<Section> sections1List;

    //         // public Section sections2;
    //         // List<Section> sections2List;

    //         public int amountRows;

    //         void Start()
    //         {
    //             sections1List = new List<Section>();
    //             // sections2List = new List<Section>();

    //             for(int i = 0; i < amountRows; i++)
    //             {
    //                 for(int j = 0; j < amountRows; j++)
    //                 {
    //                   Section SectionGroup1 = Instantiate(sections1, this.transform);
    //                   SectionGroup1.transform.localPosition = new Vector3(i, j, 0);
    //                   SectionGroup1.scaleOscillationOffset = (float)i+(float)j;
    //                   SectionGroup1.Setup();
    //                   sections1List.Add(SectionGroup1);
    //                 // Debug.Log(sectionsList.Count);

    //                 //   Section SectionGroup2 = Instantiate(sections2, this.transform);
    //                 //   SectionGroup2.transform.localPosition = new Vector3(i, j, 0);
    //                 //   SectionGroup2.scaleOscillationOffset = (float)i+(float)j;
    //                 //   SectionGroup2.Setup();
    //                 //   sections2List.Add(SectionGroup2);
    //                 }
    //             }
    //         }

    //         void Update()
    //         {
    //             for (int i = 0; i < sections1List.Count; i++)
    //             {
    //                 sections1List[i].Draw();
    //             }

    //             // for (int i = 0; i < sections2List.Count; i++)
    //             // {
    //             //     sections2List[i].Draw();
    //             // }
    //         }
    //     }
    // }



// --------------------------------------------------------------------------
//                                 V2 CODE
// --------------------------------------------------------------------------
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;


    namespace finalProject
    {
        public class SectionManager : MonoBehaviour
        {
            public Section sections1;
            List<Section> sections1List;

            // public Section sections2;
            // List<Section> sections2List;

            public int amountRows;

            void Start()
            {
                sections1List = new List<Section>();
                // sections2List = new List<Section>();

                for(int i = 0; i < amountRows; i++)
                {
                    // Section SectionGroup = Instantiate(sections1, this.transform);
                    // sections1List.Add(SectionGroup);
                    for(int j = 0; j < amountRows; j++)
                    {
                    Section SectionGroup1 = Instantiate(sections1, this.transform);
                    SectionGroup1.transform.localPosition = new Vector3(i, j, 0);
                    SectionGroup1.scaleOscillationOffset = (float)i;
                    SectionGroup1.positionOscillationOffset = (float)j*2;
                    SectionGroup1.Setup();
                    sections1List.Add(SectionGroup1);
                    // Debug.Log(sectionsList.Count);

                    //   Section SectionGroup2 = Instantiate(sections2, this.transform);
                    //   SectionGroup2.transform.localPosition = new Vector3(i, j, 0);
                    //   SectionGroup2.scaleOscillationOffset = (float)i+(float)j;
                    //   SectionGroup2.Setup();
                    //   sections2List.Add(SectionGroup2);
                    }
                }
            }

            void Update()
            {
                for (int i = 0; i < sections1List.Count; i++)
                {
                    sections1List[i].Draw();
                }

                // for (int i = 0; i < sections2List.Count; i++)
                // {
                //     sections2List[i].Draw();
                // }
            }
        }
    }

