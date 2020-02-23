using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsController : MonoBehaviour
{
    public GameObject light1;
    public GameObject light2;

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("LightTutorial") == 0)
        {
            light1.SetActive(false);
            light2.SetActive(false);
        }
        else
        {
            light1.SetActive(true);
            light2.SetActive(true);
        }
    }
}
