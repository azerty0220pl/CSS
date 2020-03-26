using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenuController : MonoBehaviour
{
	public GameObject player;
	public GameObject sphere1;
	public GameObject sphere2;
	public GameObject sphere3;
	public GameObject sphere4;

	public float xPosition;
	public float yPosition;
	public float zPosition;

	public float xPositionSphere1;
	public float yPositionSphere1;
	public float zPositionSphere1;

	public float xPositionSphere2;
	public float yPositionSphere2;
	public float zPositionSphere2;

	public float xPositionSphere3;
	public float yPositionSphere3;
	public float zPositionSphere3;

	public float xPositionSphere4;
	public float yPositionSphere4;
	public float zPositionSphere4;

	public int scena;

	public void LoadByIndex(int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			xPosition = player.transform.position.x;
			yPosition = player.transform.position.y;
			zPosition = player.transform.position.z;

			xPositionSphere1 = sphere1.transform.position.x;
			yPositionSphere1 = sphere1.transform.position.y;
			zPositionSphere1 = sphere1.transform.position.z;

			xPositionSphere2 = sphere2.transform.position.x;
			yPositionSphere2 = sphere2.transform.position.y;
			zPositionSphere2 = sphere2.transform.position.z;

			xPositionSphere3 = sphere3.transform.position.x;
			yPositionSphere3 = sphere3.transform.position.y;
			zPositionSphere3 = sphere3.transform.position.z;

			xPositionSphere4 = sphere4.transform.position.x;
			yPositionSphere4 = sphere4.transform.position.y;
			zPositionSphere4 = sphere4.transform.position.z;

			PlayerPrefs.SetFloat("xlocation", xPosition);
			PlayerPrefs.SetFloat("ylocation", yPosition);
			PlayerPrefs.SetFloat("zlocation", zPosition);

			PlayerPrefs.SetFloat("xlocationSphere1", xPositionSphere1);
			PlayerPrefs.SetFloat("ylocationSphere1", yPositionSphere1);
			PlayerPrefs.SetFloat("zlocationSphere1", zPositionSphere1);

			PlayerPrefs.SetFloat("xlocationSphere2", xPositionSphere2);
			PlayerPrefs.SetFloat("ylocationSphere2", yPositionSphere2);
			PlayerPrefs.SetFloat("zlocationSphere2", zPositionSphere2);

			PlayerPrefs.SetFloat("xlocationSphere3", xPositionSphere3);
			PlayerPrefs.SetFloat("ylocationSphere3", yPositionSphere3);
			PlayerPrefs.SetFloat("zlocationSphere3", zPositionSphere3);

			PlayerPrefs.SetFloat("xlocationSphere4", xPositionSphere4);
			PlayerPrefs.SetFloat("ylocationSphere4", yPositionSphere4);
			PlayerPrefs.SetFloat("zlocationSphere4", zPositionSphere4);

			LoadByIndex(scena);
		}
	}
}
