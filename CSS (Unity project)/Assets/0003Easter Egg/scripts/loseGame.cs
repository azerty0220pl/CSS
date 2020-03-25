using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

class loseGame : MonoBehaviour
{

public int scena;

	void OnTriggerStay(Collider other)
	{
		SceneManager.LoadScene(0);
	}
}
