using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace szetelaArt
{
    public class pixelManager : MonoBehaviour
    {
        public pixels pixel;
        List<pixels> pixelCellList;

        public int amountRows;

        void Start()
        {
            pixelCellList = new List<pixels>();

            for(int i = 0; i < amountRows; i++)
            {
                for(int j = 0; j < ((amountRows*2)-2); j++)
                {
                  pixels pixelCell = Instantiate(pixel, this.transform);
                  pixelCell.transform.localPosition = new Vector3(i, j, 0);
                  pixelCell.scaleOscillationOffset = (float)i+(float)j;
                  pixelCell.Setup();
                  pixelCellList.Add(pixelCell);
                //   Debug.Log(pixelCellList.Count);
                }
            }

            for(int i = 0; i < amountRows; i++)
            {
                for(int j = 0; j < ((amountRows*2)-2); j++)
                {
                    pixels pixelCell = Instantiate(pixel, this.transform);
                    pixelCell.transform.localPosition = new Vector3(i, j, 0);
                    pixelCell.scaleOscillationOffset = (float)j-(float)i;
                    pixelCell.Setup();
                    pixelCellList.Add(pixelCell);
                    //   Debug.Log(pixelCellList.Count);
                }
            }
        }

        void Update()
        {
            for (int i = 0; i < pixelCellList.Count; i++)
            {
                pixelCellList[i].Draw();
            }
        }
    }
}