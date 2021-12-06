using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace finalProject
{
    public class SectionManager : MonoBehaviour
    {
        public Section sections;
        List<Section> sectionsList;

        public int amountRows;

        void Start()
        {
            sectionsList = new List<Section>();

            for(int i = 0; i < amountRows; i++)
            {
                for(int j = 0; j < amountRows; j++)
                {
                  Section SectionGroup = Instantiate(sections, this.transform);
                  SectionGroup.transform.localPosition = new Vector3(i, j, 0);
                  SectionGroup.scaleOscillationOffset = (float)i+(float)j;
                  SectionGroup.Setup();
                  sectionsList.Add(SectionGroup);
                //   Debug.Log(sectionsList.Count);
                }
            }
        }

        void Update()
        {
            for (int i = 0; i < sectionsList.Count; i++)
            {
                sectionsList[i].Draw();
            }
        }
    }
}
