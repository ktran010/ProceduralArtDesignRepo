using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myOrange : myFruit
{
    // Start is called before the first frame update
    void Start()
    {
        color = new Color(1,0.5f,0);
    }

    public override void Eat()
    {
      base.Eat();

      print("I like to eat oranges.");
    }
}
