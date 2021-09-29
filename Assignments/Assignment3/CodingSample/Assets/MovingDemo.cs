using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDemo : MonoBehaviour
{
    public bool worldSpace; // false by default
    public bool moving;
    public bool useMethods;
    public bool localAxis;

    // public bool useSin;

    public Vector3 position;
    public Vector3 eulerAngles;
    public Vector3 scale;

    public Vector3 move;
    public Vector3 rotate;
    public Vector3 size;

    public Vector3 frequency; // sin waves
    public Vector3 amplitude;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(!moving)
      {
        if(worldSpace)
        {
          this.transform.position = position; // position
          this.transform.eulerAngles = eulerAngles; // rotation
          // this.transform.rotation doesn't actually work.....
          // this.transform.lossyScale; // world scale, can't really change scale
        }
        else // local space
        {
          // WILL BE USING THESE THREE LINES THE MOST FOR TRANSFORMATIONS!!!!
          this.transform.localPosition = position;
          this.transform.localEulerAngles = eulerAngles;
          this.transform.localScale = scale;
        }
      }
      else // is moving
      {
        if(useMethods)
        {
          if(localAxis)
          {
            this.transform.Translate(move);
            this.transform.Rotate(rotate);
          }
          else
          {
            this.transform.Translate(this.transform.forward * move.z);
            this.transform.Rotate(rotate);
          }
        }
        else
        {
          float x = Mathf.Sin(frequency.x * Time.time) * amplitude.x;
          float y = Mathf.Sin(frequency.y * Time.time) * amplitude.y;
          float z = Mathf.Sin(frequency.z * Time.time) * amplitude.z;

          Vector3 sinVector = new Vector3(x, y, z);

          // this.transform.localPosition += move;
          // this.transform.localEulerAngles += rotate;
          // this.transform.localScale += size;

          this.transform.localPosition += move + sinVector;
          this.transform.localEulerAngles += rotate + sinVector;
          this.transform.localScale += size;
        }
      }
    }
}
