using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
/*  public GameObject Player;
  public GameObject sphere1;
  public GameObject sphere2;
  public GameObject sphere3;
  public GameObject sphere4; */

  public float xposP = 0;
  public float yposP = 0;
  public float zposP = 0;

  public float xposS1 = 1;
  public float yposS1 = 1;
  public float zposS1 = 15;

  public float xposS2 = -1;
  public float yposS2 = 1;
  public float zposS2 = 15;

  public float xposS3 = 1;
  public float yposS3 = 1;
  public float zposS3 = 13;

  public float xposS4 = -1;
  public float yposS4 = 1;
  public float zposS4 = 13;

  public int switchRestart = 0;

  void Start()
  {
    PlayerPrefs.SetFloat("xlocation", xposP);
    PlayerPrefs.SetFloat("ylocation", yposP);
    PlayerPrefs.SetFloat("zlocation", zposP);

    PlayerPrefs.SetFloat("xlocationSphere1", xposS1);
    PlayerPrefs.SetFloat("ylocationSphere1", yposS1);
    PlayerPrefs.SetFloat("zlocationSphere1", zposS1);

    PlayerPrefs.SetFloat("xlocationSphere2", xposS2);
    PlayerPrefs.SetFloat("ylocationSphere2", yposS2);
    PlayerPrefs.SetFloat("zlocationSphere2", zposS2);

    PlayerPrefs.SetFloat("xlocationSphere3", xposS3);
    PlayerPrefs.SetFloat("ylocationSphere3", yposS3);
    PlayerPrefs.SetFloat("zlocationSphere3", zposS3);

    PlayerPrefs.SetFloat("xlocationSphere4", xposS4);
    PlayerPrefs.SetFloat("ylocationSphere4", yposS4);
    PlayerPrefs.SetFloat("zlocationSphere4", zposS4);

    PlayerPrefs.SetInt("state1", switchRestart);
    PlayerPrefs.SetInt("state2", switchRestart);
    PlayerPrefs.SetInt("state", switchRestart);

    PlayerPrefs.SetInt("hint", 1);
  }
}
