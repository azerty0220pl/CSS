using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour
{
  public GameObject player;

	public float xPosition;
	public float yPosition;
	public float zPosition;

  public void Saved()
  {
    xPosition = player.transform.position.x;
    yPosition = player.transform.position.y;
    zPosition = player.transform.position.z;

    PlayerPrefs.SetFloat("xlocation", xPosition);
    PlayerPrefs.SetFloat("ylocation", yPosition);
    PlayerPrefs.SetFloat("zlocation", zPosition);
  }
}
