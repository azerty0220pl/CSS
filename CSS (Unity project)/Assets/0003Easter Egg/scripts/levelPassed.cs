using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

class levelPassed : MonoBehaviour
{


	void OnTriggerStay(Collider other)
	{
		SceneManager.LoadScene(2);
	}
}
