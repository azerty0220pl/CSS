using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint12 : MonoBehaviour
{
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hitbox;

    void OnTriggerEnter(Collider other)
    {
      hint1.SetActive(false);
      hint2.SetActive(true);
      hitbox.SetActive(false);
    }
}
