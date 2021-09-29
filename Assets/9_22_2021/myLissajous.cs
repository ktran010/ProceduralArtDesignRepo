using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myLissajous : MonoBehaviour
{
    // public int counter;
    // public float PositionY;
    public float counterX;
    public float counterY;
    public float counterZ;
    public float speedX;
    public float speedY;
    public float speedZ;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World! :)");
        print("Start using print");
    }

    // Update is called once per frame
    void Update()
    {
      //counter++;

      //ONE WAY:
      // Vector3 vector = new Vector3(); // this vector initalized 0, 0, 0
      // vector.y = PositionY;
      // this.transform.position = PositionY;

      //SECOND WAY:
      //this.transform.position = new Vector3(0, PositionY * counter, 0);

      //THIRD WAY:
      // this.transform.Translate(0, PositionY, 0);

      // print("Update: " + counter.ToString());


      counterX += speedX;
      counterY += speedY;
      counterZ += speedZ;

      this.transform.localPosition = new Vector3(Mathf.Sin(counterX), Mathf.Cos(counterY),  Mathf.PingPong(0, (Mathf.Sin(counterZ))));
      // this.transform.position = new Vector3(Mathf.Sin(counterX), Mathf.Sin(counterX*Mathf.PI)*0.2f, 0);
      // this.transform.position = new Vector3(Mathf.Sin(counterX), Mathf.cos(counterY)*spiral, 0);
    }
}

// a Method is a function in a class
// gameobjects always have transforms, transform component of gameobject can be accessed
// "this" refers to the gameobject that the script is attached to
// "new" means instantiating a class. You're creating a new Vector3 object and assigning it
