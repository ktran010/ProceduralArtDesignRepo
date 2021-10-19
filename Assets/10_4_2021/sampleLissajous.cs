using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleLissajous : MonoBehaviour
{
  public float counterX;
  public float counterY;
  public float speedX;
  public float speedY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      counterX += speedX;
      counterY += speedY;

      this.transform.localPosition = new Vector3(Mathf.Sin(counterX), Mathf.Cos(counterY),  0);
    }
}
