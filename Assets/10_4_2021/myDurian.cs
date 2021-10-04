using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myDurian : myFruit
{
    // Start is called before the first frame update
    void Start()
    {
        color = new Color(0.6f,0.5f,0.2f);
    }

    public override void Eat()
    {
      base.Eat();

      print("I LOVE to eat durian.");
    }
}
