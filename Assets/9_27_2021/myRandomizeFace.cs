using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myRandomizeFace : MonoBehaviour
{
  public Transform mouth;
  public Transform eye;
  public Transform eyebrow;
  public Transform nose;

  public bool randomize;

  public float minMouthRotation = -10f;
  public float maxMouthRotation = 10f;

  public float minMouthWidth = 0.2f;
  public float maxMouthWidth = 0.5f;

  public float minMouthHeight = 0.1f;
  public float maxMouthHeight = 0.2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.P))
      {
        randomize = true;
      }

      if(randomize)
      {
        Randomize();
        randomize = false;
      }
    }

    void Randomize()
    {
        mouth.localEulerAngles = MakeRandomVector(
        new Vector3(0,0,minMouthRotation),
        new Vector3(0,0,maxMouthRotation));

        mouth.localScale = MakeRandomVector(
        new Vector3(minMouthWidth,minMouthHeight,0.2f),
        new Vector3(minMouthWidth,minMouthHeight,0.2f));
    }

    Vector3 MakeRandomVector(Vector3 min, Vector3 max)
    {
      return new Vector3(
        Random.Range(min.x, max.x),
        Random.Range(min.y, max.y),
        Random.Range(min.z, max.z));
    }
}
