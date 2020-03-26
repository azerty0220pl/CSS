using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public GameObject plUI;
    public GameObject enUI;
    public GameObject choose;
  //  public GameObject chooseLenguage;
    public int lenguage = PlayerPrefs.GetInt("lenguagei");

    void Update()
    {
      StartCoroutine(setting());
    }

    IEnumerator setting()
    {
      lenguage = PlayerPrefs.GetInt("lenguagei");
      //lenguage = 0;

      if(lenguage == 0)
      {
        choose.SetActive(true);
        plUI.SetActive(false);
        enUI.SetActive(false);
        PlayerPrefs.SetInt("lenguagei", 0);
      }else if(lenguage == 1)
      {
        choose.SetActive(false);
        plUI.SetActive(true);
        enUI.SetActive(false);
        PlayerPrefs.SetInt("lenguagei", 1);
      }else if(lenguage == 2)
      {
        choose.SetActive(false);
        plUI.SetActive(false);
        enUI.SetActive(true);
        PlayerPrefs.SetInt("lenguagei", 2);
      }

      yield return new WaitForSeconds(0.2f);
    }
}
