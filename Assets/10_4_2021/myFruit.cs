using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myFruit : MonoBehaviour
{
  public Color color;
  public float size;
  public float bumpiness;
  public float roughness;
  public float ripness;

  public bool isBerry;

  public virtual void Eat() {}
}
