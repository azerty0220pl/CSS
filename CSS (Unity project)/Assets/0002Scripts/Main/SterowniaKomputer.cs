using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class SterowniaKomputer : MonoBehaviour
{

    public InputField messageField;
    string message;
    int character = 0;
    int character01 = 0;
    int character02 = 0;
    int character03 = 0;
    int character04 = 0;
    int character05 = 0;
    int character06 = 0;
    int character07 = 0;
    int character08 = 0;
    int character09 = 0;
    int character10 = 0;
    int character11 = 0;
    int character12 = 0;
    int character13 = 0;
    int character14 = 0;
    int character15 = 0;
    int character16 = 0;
    int character17 = 0;
    int character18 = 0;
    int character19 = 0;
    int character20 = 0;
    int character21 = 0;
    int character22 = 0;
    int character23 = 0;
    int character24 = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (Input.GetKey(KeyCode.Return))
        {
            message = messageField.text;
            character++;
            if (character == 1)
            {
                character01 = int.Parse(message) - 14;
            }
            else if (character == 2)
            {
                character02 = int.Parse(message) - 32;
            }
            else if (character == 3)
            {
                character03 = int.Parse(message) - 32;
            }
            else if (character == 4)
            {
                character04 = int.Parse(message) - 16;
            }
            else if (character == 5)
            {
                character05 = int.Parse(message) - 12;
            }
            else if (character == 6)
            {
                character06 = int.Parse(message) - 31;
            }
            else if (character == 7)
            {
                character07 = int.Parse(message) - 33;
            }
            else if (character == 8)
            {
                character08 = int.Parse(message) - 19;
            }
            else if (character == 9)
            {
                character09 = int.Parse(message) - 11;
            }
            else if (character == 10)
            {
                character10 = int.Parse(message) - 33;
            }
            else if (character == 11)
            {
                character11 = int.Parse(message) - 31;
            }
            else if (character == 12)
            {
                character12 = int.Parse(message) - 12;
            }
            else if (character == 13)
            {
                character13 = int.Parse(message) - 26;
            }
            else if (character == 14)
            {
                character14 = int.Parse(message) - 32;
            }
            else if (character == 15)
            {
                character15 = int.Parse(message) - 28;
            }
            else if (character == 16)
            {
                character16 = int.Parse(message) - 27;
            }
            else if (character == 17)
            {
                character17 = int.Parse(message) - 31;
            }
            else if (character == 18)
            {
                character18 = int.Parse(message) - 33;
            }
            else if (character == 19)
            {
                character19 = int.Parse(message) - 26;
            }
            else if (character == 20)
            {
                character20 = int.Parse(message) - 16;
            }
            else if (character == 21)
            {
                character21 = int.Parse(message) - 16;
            }
            else if (character == 22)
            {
                character22 = int.Parse(message) - 15;
            }
            else if (character == 23)
            {
                character23 = int.Parse(message) - 16;
            }
            else if (character == 24)
            {
                character24 = int.Parse(message) - 15;
                int[] i = {character01, character02, character03, character04, character05, character06, character07, character08, character09, character10, character11, character12, character13, character14, character15, character16, character17, character18, character19, character20, character21, character22, character23, character24};
                if (i.Distinct().Count() == 1)
                {
                    PlayerPrefs.SetInt("tranport1", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("transport1", 2);
                }
            }
        }
    }
}
