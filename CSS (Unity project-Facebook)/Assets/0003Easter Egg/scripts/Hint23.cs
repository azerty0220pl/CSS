using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint23 : MonoBehaviour
{
  public GameObject hint2;
  public GameObject hint3;
  public GameObject hitbox;

  void OnTriggerEnter(Collider other)
  {
    hint2.SetActive(false);
    hint3.SetActive(true);
    hitbox.SetActive(false);
  }
}
