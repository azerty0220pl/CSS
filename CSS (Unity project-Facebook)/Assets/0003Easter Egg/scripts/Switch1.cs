using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch1 : MonoBehaviour
{
  public GameObject green;
  public GameObject red;
  public GameObject brick1;
  public GameObject brick2;

  public int state;

  void Start()
  {
    Load();
  }

  void Update()
  {
    if(green.activeInHierarchy) state = 0;
    if(red.activeInHierarchy) state = 1;
    if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Escape)) PlayerPrefs.SetInt("state1", state);
    if(Input.GetKeyDown(KeyCode.Mouse1)) Load();
  }

void Load()
{
  if(PlayerPrefs.GetInt("state1") == 0)
  {
    green.SetActive(true);
    red.SetActive(false);
    brick1.SetActive(true);
    brick2.SetActive(false);
  }else
  {
    green.SetActive(false);
    red.SetActive(true);
    brick1.SetActive(false);
    brick2.SetActive(true);
  }
}

  /*void OnTriggerEnter(Collider other)
  {
    if(green.activeInHierarchy)
    {
      green.SetActive(false);
      red.SetActive(true);
      brick1.SetActive(false);
      brick2.SetActive(true);
      state1 = 1;
    }else
    {
      green.SetActive(true);
      red.SetActive(false);
      brick1.SetActive(true);
      brick2.SetActive(false);
      state1 = 0;
    }
  }*/
}
