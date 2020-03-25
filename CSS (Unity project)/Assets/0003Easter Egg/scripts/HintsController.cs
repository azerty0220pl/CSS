using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintsController : MonoBehaviour
{
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    public GameObject hitbox12;
    public GameObject hitbox23;
    public int state;

    void Start()
    {
      Load();
    }

    void Update()
    {
      if(hint1.activeInHierarchy) state = 1;
      if(hint2.activeInHierarchy) state = 2;
      if(hint3.activeInHierarchy) state = 3;
      if(Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Escape)) PlayerPrefs.SetInt("hint", state);
      if(Input.GetKeyDown(KeyCode.Mouse1)) Load();
    }

    void Load()
    {
      if(PlayerPrefs.GetInt("hint") == 1)
      {
        hint1.SetActive(true);
        hint2.SetActive(false);
        hint3.SetActive(false);
        hitbox12.SetActive(true);
        hitbox23.SetActive(true);
      }

      if(PlayerPrefs.GetInt("hint") == 2)
      {
        hint1.SetActive(false);
        hint2.SetActive(true);
        hint3.SetActive(false);
        hitbox12.SetActive(false);
        hitbox23.SetActive(true);
      }

      if(PlayerPrefs.GetInt("hint") == 3)
      {
        hint1.SetActive(false);
        hint2.SetActive(false);
        hint3.SetActive(true);
        hitbox12.SetActive(false);
        hitbox23.SetActive(false);
      }
    }
}
