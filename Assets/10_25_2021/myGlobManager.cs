using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myGlobManager : MonoBehaviour
{
    public myGlob glob;
    public int amount;
    // Start is called before the first frame update
    public void Rebuild()
    {
        for(int i=0; i< amount; i++)
        {
            // GameObject thisGlob = Instantiate(glob.gameObject, this.transform);
            myGlob thisGlob = Instantiate(glob.gameObject, this.transform).GetComponent<myGlob>();
            thisGlob.transform.localPosition = Random.insideUnitSphere*20;
            thisGlob.ReBuild();
        }
    }
}
