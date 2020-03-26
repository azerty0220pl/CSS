using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger1 : MonoBehaviour
{

  public GameObject green;
  public GameObject red;
  public GameObject brick1;
  public GameObject brick2;

  void OnTriggerEnter(Collider other)
  {
    if(green.activeInHierarchy)
    {
      green.SetActive(false);
      red.SetActive(true);
      brick1.SetActive(false);
      brick2.SetActive(true);
    }
  }
}
