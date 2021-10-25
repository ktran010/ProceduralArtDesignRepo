using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGlob : MonoBehaviour
{
    public GameObject juice;
    public int amount;

    // important for every element inside glob should
    // have a single parent
    // we can use whatever object that myGlob script is attached
    // to will be the parent

    public void ReBuild(){
        for(int i=0; i< amount; i++)
        {
            GameObject thisJuice = Instantiate(juice);
            // can also do the following line, which instantly parents the object
            // GameObject thisJuice = Instantiate(juice, this.transform);
            thisJuice.transform.localPosition = Random.insideUnitSphere;
        }
    }
}
