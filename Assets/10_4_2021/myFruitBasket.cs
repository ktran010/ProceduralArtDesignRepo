using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFruitBasket : MonoBehaviour
{
    public myFruit[] fruits;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < fruits.Length; i++)
        {
          fruits[i].Eat();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
