using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomChess : MonoBehaviour
{
  public Color[] colorsK;
  public Color[] colorsH;
  public Color[] colorsQ;
  public Color[] colorsB;

  public Transform knight;
  public Transform king;
  public Transform queen;
  public Transform bishop;

  public bool randomize;

  // public float minScaleWidth;
  // public float maxScaleWidth;
  // public float minScaleHeight;
  // public float maxScaleHeight;
  //
  // public float minScaleHeight;
  // public float maxScaleHeight;
  //
  // public float minMouthHeight = .1f;
  // public float maxMouthHeight = .2f;

  [Tooltip("X:min, Y:max")]
  public Vector2 eyebrowRotation;

  [Tooltip("X:min, Y:max")]
  public Vector2 mouthRotation;

  void Start(){}

  // Update is called once per frame
  void Update()
  {
      if (Input.GetKey(KeyCode.R))
      {
          randomize = true;
      }
      if (randomize)
      {
          Randomize();
          RandomizeColor();
          randomize = false;
      }
  }

  void Randomize()
  {
      // Piece Scaling
      float valueScale = Random.Range(0.5f, 0.7f);
      knight.localScale = MakeRandomVector(
          new Vector3(valueScale, valueScale, valueScale),
          new Vector3(valueScale, valueScale, valueScale));

      king.localScale = MakeRandomVector(
          new Vector3(valueScale, 2*valueScale, valueScale),
          new Vector3(valueScale, 2*valueScale, valueScale));

      queen.localScale = MakeRandomVector(
          new Vector3(valueScale, valueScale, valueScale),
          new Vector3(valueScale, valueScale, valueScale));

      bishop.localScale = MakeRandomVector(
          new Vector3(valueScale, valueScale, valueScale),
          new Vector3(valueScale, valueScale, valueScale));


      //Cardinal Rotation
      int valueRotationCardinal = Random.Range(0, 3); // same code for Cardinal and Intercardinal Array Indices
      var rotationalCardinalArray = new float[4] {90.0f, 180.0f, 270.0f, 360.0f};

      //Intercardinal Rotation
      var rotationalIntercardinalArray = new float[4] {45.0f, 135.0f, 225.0f, 315.0f};

      //All Cardinal Rotation
      int valueRotationAll = Random.Range(0, 7);
      var rotationAllArray = new float[8] {45.0f, 90.0f, 135.0f, 180.0f, 225.0f, 270.0f, 315.0f, 360.0f};


      // Piece Rotation
      knight.localEulerAngles = MakeRandomVector(
          new Vector3(0, rotationalCardinalArray[valueRotationCardinal], 0),
          new Vector3(0, rotationalCardinalArray[valueRotationCardinal], 0));

      bishop.localEulerAngles = MakeRandomVector(
          new Vector3(0, rotationalIntercardinalArray[valueRotationCardinal], 0),
          new Vector3(0, rotationalIntercardinalArray[valueRotationCardinal], 0));

      queen.localEulerAngles = MakeRandomVector(
          new Vector3(0, rotationAllArray[valueRotationAll], 0),
          new Vector3(0, rotationAllArray[valueRotationAll], 0));

      king.localEulerAngles = MakeRandomVector(
          new Vector3(0, rotationAllArray[valueRotationAll], 0),
          new Vector3(0, rotationAllArray[valueRotationAll], 0));


      // 7 Unit Translation
      int valueTranslation7_LR = Random.Range(0, 11);
      int valueTranslation7_D = Random.Range(0, 11);
      var Translation7Array = new float[11]
      {-1.0f, -2.0f, -3.0f, -4.0f, -5.0f, 0.0f, 1.0f, 2.0f, 3.0f, 4.0f, 5.0f};

      // 1 Unit Translation
      int valueTranslation1_LR = Random.Range(0, 3);
      int valueTranslation1_D = Random.Range(0, 3);
      var Translation1Array = new float[3]
      {-1.0f, 0.0f, 1.0f};

      // Piece Translation

      int OneOrOther1 = Random.Range(0, 2);
      int OneOrOther2 = Random.Range(0, 2);

      if(OneOrOther1 == 0)
      {
        knight.localPosition = MakeRandomVector( // left/right
            new Vector3(Translation7Array[valueTranslation7_LR], 0.75f, 0),
            new Vector3(Translation7Array[valueTranslation7_LR], 0.75f, 0));
      }
      else
      {
        knight.localPosition = MakeRandomVector( //up/down
            new Vector3(0, 0.75f, Translation7Array[valueTranslation7_LR]),
            new Vector3(0, 0.75f, Translation7Array[valueTranslation7_LR]));
      }

      if(OneOrOther2 == 0)
      {
        bishop.localPosition = MakeRandomVector( // diagonal right
            new Vector3(Translation7Array[valueTranslation7_LR], 0.75f, Translation7Array[valueTranslation7_LR]),
            new Vector3(Translation7Array[valueTranslation7_LR], 0.75f, Translation7Array[valueTranslation7_LR]));
      }
      else
      {
        bishop.localPosition = MakeRandomVector( // diagonal left
            new Vector3(Translation7Array[valueTranslation7_LR], 0.75f, -Translation7Array[valueTranslation7_LR]),
            new Vector3(Translation7Array[valueTranslation7_LR], 0.75f, -Translation7Array[valueTranslation7_LR]));
      }

      queen.localPosition = MakeRandomVector( // all squares on board
          new Vector3(Translation7Array[valueTranslation7_LR], 1.0f, Translation7Array[valueTranslation7_D]),
          new Vector3(Translation7Array[valueTranslation7_LR], 1.0f, Translation7Array[valueTranslation7_D]));

      king.localPosition = MakeRandomVector( // all squares on board
          new Vector3(Translation1Array[valueTranslation1_LR], 1.0f, Translation1Array[valueTranslation1_D]),
          new Vector3(Translation1Array[valueTranslation1_LR], 1.0f, Translation1Array[valueTranslation1_D]));
  }


  void RandomizeColor()
  {
      MeshRenderer meshRenderer = knight.GetComponent<MeshRenderer>();
      meshRenderer.material.color = colorsK[Random.Range(0, colorsK.Length)];

      meshRenderer = king.GetComponent<MeshRenderer>();
      king.GetComponent<MeshRenderer>().material.color = colorsH[Random.Range(0, colorsH.Length)];

      meshRenderer = queen.GetComponent<MeshRenderer>();
      queen.GetComponent<MeshRenderer>().material.color = colorsQ[Random.Range(0, colorsQ.Length)];

      meshRenderer = bishop.GetComponent<MeshRenderer>();
      bishop.GetComponent<MeshRenderer>().material.color = colorsB[Random.Range(0, colorsB.Length)];
  }

  Vector3 MakeRandomVector(Vector3 min, Vector3 max)
  {
      return new Vector3(
          Random.Range(min.x, max.x),
          Random.Range(min.y, max.y),
          Random.Range(min.z, max.z));
  }
}
