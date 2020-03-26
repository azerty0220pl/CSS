using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveLoad : MonoBehaviour
{
/*	public class CharacterData
  {
    public float xlocation = GameObject.FindWithTag("Player").transform.position.x;
    public float ylocation = GameObject.FindWithTag("Player").transform.position.y;
    public float zlocation = GameObject.FindWithTag("Player").transform.position.z;
  }

	public CharacterData characterData;
*/
	public GameObject player;

	public float xPosition;
	public float yPosition;
	public float zPosition;

	void Start()
	{
		player.GetComponent<CharacterController>().enabled = false;
		player.transform.position = new Vector3(PlayerPrefs.GetFloat("xlocation"), PlayerPrefs.GetFloat("ylocation"), PlayerPrefs.GetFloat("zlocation"));
		player.GetComponent<CharacterController>().enabled = true;
	}

	public void Update()
	{
		xPosition = player.transform.position.x;
		yPosition = player.transform.position.y;
		zPosition = player.transform.position.z;

		if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Escape))
		{
			PlayerPrefs.SetFloat("xlocation", xPosition);
			PlayerPrefs.SetFloat("ylocation", yPosition);
			PlayerPrefs.SetFloat("zlocation", zPosition);
		}

		if(Input.GetKeyDown(KeyCode.Mouse1))
		{
			player.GetComponent<CharacterController>().enabled = false;
			player.transform.position = new Vector3(PlayerPrefs.GetFloat("xlocation"), PlayerPrefs.GetFloat("ylocation"), PlayerPrefs.GetFloat("zlocation"));
			player.GetComponent<CharacterController>().enabled = true;
		}
	}
}
