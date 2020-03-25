using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor1 : MonoBehaviour
{
    public GameObject door;
    void OnTriggerEnter(Collider other)
	{
		door.SetActive(false);
	}

  void OnTriggerStay(Collider other)
  {
    door.SetActive(false);
  }

	 void OnTriggerExit(Collider other)
	{
		door.SetActive(true);
	}
}
