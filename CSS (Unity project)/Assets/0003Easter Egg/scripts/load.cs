using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class load : MonoBehaviour
{
  public GameObject player;

	public float xPosition;
	public float yPosition;
	public float zPosition;

  public void loaded()
  {
    xPosition = player.transform.position.x;
		yPosition = player.transform.position.y;
		zPosition = player.transform.position.z;

    player.GetComponent<CharacterController>().enabled = false;
    player.transform.position = new Vector3(PlayerPrefs.GetFloat("xlocation"), PlayerPrefs.GetFloat("ylocation"), PlayerPrefs.GetFloat("zlocation"));
    player.GetComponent<CharacterController>().enabled = true;
  }
}
