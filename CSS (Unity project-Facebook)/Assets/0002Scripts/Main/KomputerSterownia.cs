using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class KomputerSterownia : MonoBehaviour
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
        character = 0;
        character01 = 0;
        character02 = 0;
        character03 = 0;
        character04 = 0;
        character05 = 0;
        character06 = 0;
        character07 = 0;
        character08 = 0;
        character09 = 0;
        character10 = 0;
        character11 = 0;
        character12 = 0;
        character13 = 0;
        character14 = 0;
        character15 = 0;
        character16 = 0;
        character17 = 0;
        character18 = 0;
        character19 = 0;
        character20 = 0;
        character21 = 0;
        character22 = 0;
        character23 = 0;
        character24 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            message = messageField.text;
            messageField.text = "";
            character++;
            messageField.enabled = true;
            messageField.ActivateInputField();

            Debug.Log(message);

            PlayerPrefs.SetInt("transport1", 2);

            Debug.Log(PlayerPrefs.GetInt("transport1"));

            if (message == "azerty0220pl")
            {
                PlayerPrefs.SetInt("transport1", 220);
            }

            if (character == 1)
            {
                character01 = int.Parse(message) - 14;
                Debug.Log(character01);
            }
            else if (character == 2)
            {
                character02 = int.Parse(message) - 32;
                Debug.Log(character02);
            }
            else if (character == 3)
            {
                character03 = int.Parse(message) - 32;
                Debug.Log(character03);

            }
            else if (character == 4)
            {
                character04 = int.Parse(message) - 16;
                Debug.Log(character04);

            }
            else if (character == 5)
            {
                character05 = int.Parse(message) - 12;
                Debug.Log(character05);

            }
            else if (character == 6)
            {
                character06 = int.Parse(message) - 31;
                Debug.Log(character06);

            }
            else if (character == 7)
            {
                character07 = int.Parse(message) - 33;
                Debug.Log(character07);

            }
            else if (character == 8)
            {
                character08 = int.Parse(message) - 19;
                Debug.Log(character08);

            }
            else if (character == 9)
            {
                character09 = int.Parse(message) - 11;
                Debug.Log(character09);

            }
            else if (character == 10)
            {
                character10 = int.Parse(message) - 33;
                Debug.Log(character10);

            }
            else if (character == 11)
            {
                character11 = int.Parse(message) - 31;
                Debug.Log(character11);

            }
            else if (character == 12)
            {
                character12 = int.Parse(message) - 12;
                Debug.Log(character12);

            }
            else if (character == 13)
            {
                character13 = int.Parse(message) - 26;
                Debug.Log(character13);

            }
            else if (character == 14)
            {
                character14 = int.Parse(message) - 32;
                Debug.Log(character14);

            }
            else if (character == 15)
            {
                character15 = int.Parse(message) - 28;
                Debug.Log(character15);

            }
            else if (character == 16)
            {
                character16 = int.Parse(message) - 27;
                Debug.Log(character16);

            }
            else if (character == 17)
            {
                character17 = int.Parse(message) - 31;
                Debug.Log(character17);

            }
            else if (character == 18)
            {
                character18 = int.Parse(message) - 33;
                Debug.Log(character18);

            }
            else if (character == 19)
            {
                character19 = int.Parse(message) - 26;
                Debug.Log(character19);

            }
            else if (character == 20)
            {
                character20 = int.Parse(message) - 16;
                Debug.Log(character20);

            }
            else if (character == 21)
            {
                character21 = int.Parse(message) - 16;
                Debug.Log(character21);

            }
            else if (character == 22)
            {
                character22 = int.Parse(message) - 15;
                Debug.Log(character22);

            }
            else if (character == 23)
            {
                character23 = int.Parse(message) - 16;
                Debug.Log(character23);

            }
            else if (character == 24)
            {
                character24 = int.Parse(message) - 15;
                Debug.Log(character24);

                int[] i = {character01, character02, character03, character04, character05, character06, character07, character08, character09, character10, character11, character12, character13, character14, character15, character16, character17, character18, character19, character20, character21, character22, character23, character24};
                if (i.Distinct().Count() == 1)
                {
                    PlayerPrefs.SetInt("transport1", 1);
                }
                else
                {
                    PlayerPrefs.SetInt("transport1", 2);
                }
                Debug.Log(PlayerPrefs.GetInt("transport1"));
            }
        }
    }
}
