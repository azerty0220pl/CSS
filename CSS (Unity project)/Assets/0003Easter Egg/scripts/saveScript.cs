using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveScript : MonoBehaviour
{
  static void SaveCharacter()
  {
    PlayerPrefs.SetFloat("xlocation", GameObject.Find("character").transform.position.x);
    PlayerPrefs.SetFloat("ylocation", GameObject.Find("character").transform.position.y);
    PlayerPrefs.SetFloat("zlocation", GameObject.Find("character").transform.position.z);
  }
}
