using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KompBiblia : MonoBehaviour
{
    public GameObject Kowalski;
    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            gameObject.SetActive(false);
            Kowalski.SetActive(true);
        }
    }
}
