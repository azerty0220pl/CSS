using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelSilnia : MonoBehaviour
{
    bool move = false;

    public GameObject l11;
    public GameObject l12;
    public GameObject l13;
    public GameObject l14;
    public GameObject l21;
    public GameObject l22;
    public GameObject l23;
    public GameObject l24;
    public GameObject l31;
    public GameObject l32;
    public GameObject l33;
    public GameObject l34;

    public GameObject l11o;
    public GameObject l12o;
    public GameObject l13o;
    public GameObject l14o;
    public GameObject l21o;
    public GameObject l22o;
    public GameObject l23o;
    public GameObject l24o;
    public GameObject l31o;
    public GameObject l32o;
    public GameObject l33o;
    public GameObject l34o;

    public GameObject b11;
    public GameObject b12;
    public GameObject b13;
    public GameObject b14;
    public GameObject b21;
    public GameObject b22;
    public GameObject b23;
    public GameObject b24;

    public GameObject b11o;
    public GameObject b12o;
    public GameObject b13o;
    public GameObject b14o;
    public GameObject b21o;
    public GameObject b22o;
    public GameObject b23o;
    public GameObject b24o;

    public GameObject pb11;
    public GameObject pb12;
    public GameObject pb13;
    public GameObject pb14;
    public GameObject pb21;
    public GameObject pb22;
    public GameObject pb23;
    public GameObject pb24;

    public GameObject pb11o;
    public GameObject pb12o;
    public GameObject pb13o;
    public GameObject pb14o;
    public GameObject pb21o;
    public GameObject pb22o;
    public GameObject pb23o;
    public GameObject pb24o;

    public GameObject Kowalski;
    public GameObject PanelSilniaObejct;
    public GameObject lights;

    public void Start()
    {
        l11.SetActive(PlayerPrefs.GetInt("l11") != 0);
        l12.SetActive(PlayerPrefs.GetInt("l12") != 0);
        l13.SetActive(PlayerPrefs.GetInt("l13") != 0);
        l14.SetActive(PlayerPrefs.GetInt("l14") != 0);
        l11o.SetActive(PlayerPrefs.GetInt("l11o") != 0);
        l12o.SetActive(PlayerPrefs.GetInt("l12o") != 0);
        l13o.SetActive(PlayerPrefs.GetInt("l13o") != 0);
        l14o.SetActive(PlayerPrefs.GetInt("l14o") != 0);
        l21.SetActive(PlayerPrefs.GetInt("l21") != 0);
        l22.SetActive(PlayerPrefs.GetInt("l22") != 0);
        l23.SetActive(PlayerPrefs.GetInt("l23") != 0);
        l24.SetActive(PlayerPrefs.GetInt("l24") != 0);
        l21o.SetActive(PlayerPrefs.GetInt("l21o") != 0);
        l22o.SetActive(PlayerPrefs.GetInt("l22o") != 0);
        l23o.SetActive(PlayerPrefs.GetInt("l23o") != 0);
        l24o.SetActive(PlayerPrefs.GetInt("l24o") != 0);
        l31.SetActive(PlayerPrefs.GetInt("l31") != 0);
        l32.SetActive(PlayerPrefs.GetInt("l32") != 0);
        l33.SetActive(PlayerPrefs.GetInt("l33") != 0);
        l34.SetActive(PlayerPrefs.GetInt("l34") != 0);
        l31o.SetActive(PlayerPrefs.GetInt("l31o") != 0);
        l32o.SetActive(PlayerPrefs.GetInt("l32o") != 0);
        l33o.SetActive(PlayerPrefs.GetInt("l33o") != 0);
        l34o.SetActive(PlayerPrefs.GetInt("l34o") != 0);
        b11.SetActive(PlayerPrefs.GetInt("b11") != 0);
        b12.SetActive(PlayerPrefs.GetInt("b12") != 0);
        b13.SetActive(PlayerPrefs.GetInt("b13") != 0);
        b14.SetActive(PlayerPrefs.GetInt("b14") != 0);
        b11o.SetActive(PlayerPrefs.GetInt("b11o") != 0);
        b12o.SetActive(PlayerPrefs.GetInt("b12o") != 0);
        b13o.SetActive(PlayerPrefs.GetInt("b13o") != 0);
        b14o.SetActive(PlayerPrefs.GetInt("b14o") != 0);
        b21.SetActive(PlayerPrefs.GetInt("b21") != 0);
        b22.SetActive(PlayerPrefs.GetInt("b22") != 0);
        b23.SetActive(PlayerPrefs.GetInt("b23") != 0);
        b24.SetActive(PlayerPrefs.GetInt("b24") != 0);
        b21o.SetActive(PlayerPrefs.GetInt("b21o") != 0);
        b22o.SetActive(PlayerPrefs.GetInt("b22o") != 0);
        b23o.SetActive(PlayerPrefs.GetInt("b23o") != 0);
        b24o.SetActive(PlayerPrefs.GetInt("b24o") != 0);

        if (l31.activeInHierarchy && l32.activeInHierarchy && l33.activeInHierarchy && l34.activeInHierarchy)
        {
            PlayerPrefs.SetInt("lightsMain", 1);
            lights.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("lightsMain", 0);
            lights.SetActive(false);
        }
    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        PlayerPrefs.SetInt("l11", l11.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l12", l12.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l13", l13.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l14", l14.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l11o", l11o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l12o", l12o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l13o", l13o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l14o", l14o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l21", l21.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l22", l22.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l23", l23.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l24", l24.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l21o", l21o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l22o", l22o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l23o", l23o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l24o", l24o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l31", l31.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l32", l32.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l33", l33.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l34", l34.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l31o", l31o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l32o", l32o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l33o", l33o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("l34o", l34o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b11", b11.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b12", b12.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b13", b13.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b14", b14.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b11o", b11o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b12o", b12o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b13o", b13o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b14o", b14o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b21", b21.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b22", b22.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b23", b23.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b24", b24.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b21o", b21o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b22o", b22o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b23o", b23o.activeInHierarchy ? 1 : 0);
        PlayerPrefs.SetInt("b24o", b24o.activeInHierarchy ? 1 : 0);

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            Kowalski.SetActive(true);
            PanelSilniaObejct.SetActive(false);
        }

        if (l31.activeInHierarchy && l32.activeInHierarchy && l33.activeInHierarchy && l34.activeInHierarchy)
        {
            PlayerPrefs.SetInt("lightsMain", 1);
            lights.SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("lightsMain", 0);
            lights.SetActive(false);
        }
    }

    public void button11()
    {
        if (l11.activeInHierarchy != l21.activeInHierarchy)
        {
            l11.SetActive(!l11.activeInHierarchy);
            l21.SetActive(!l21.activeInHierarchy);
            l11o.SetActive(!l11o.activeInHierarchy);
            l21o.SetActive(!l21o.activeInHierarchy);
            b11.SetActive(!b11.activeInHierarchy);
            b11o.SetActive(!b11o.activeInHierarchy);
        }
    }

    public void button12()
    {
        if (l12.activeInHierarchy != l22.activeInHierarchy)
        {
            if (l12.activeInHierarchy == !l11.activeInHierarchy || l22.activeInHierarchy == !l21.activeInHierarchy)
            {
                l12.SetActive(!l12.activeInHierarchy);
                l22.SetActive(!l22.activeInHierarchy);
                l12o.SetActive(!l12o.activeInHierarchy);
                l22o.SetActive(!l22o.activeInHierarchy);
                b12o.SetActive(!b12o.activeInHierarchy);
                b12.SetActive(!b12.activeInHierarchy);
                move = true;
            }
        }

        if (l12.activeInHierarchy && l11.activeInHierarchy && move == true)
            restart();
        if (l22.activeInHierarchy && l21.activeInHierarchy && move == true)
            restart();
        move = false;
    }

    public void button13()
    {
        if (l13.activeInHierarchy != l23.activeInHierarchy)
        {
            if (l13.activeInHierarchy == !l12.activeInHierarchy || l23.activeInHierarchy == !l22.activeInHierarchy)
            {
                if (l13.activeInHierarchy == !l11.activeInHierarchy || l23.activeInHierarchy == !l21.activeInHierarchy)
                {
                    l13.SetActive(!l13.activeInHierarchy);
                    l23.SetActive(!l23.activeInHierarchy);
                    l13o.SetActive(!l13o.activeInHierarchy);
                    l23o.SetActive(!l23o.activeInHierarchy);
                    b13o.SetActive(!b13o.activeInHierarchy);
                    b13.SetActive(!b13.activeInHierarchy);
                    move = true;
                }
            }
        }

        if (l13.activeInHierarchy && move == true)
        {
            if (l11.activeInHierarchy || l12.activeInHierarchy)
                restart();
        }

        if (l23.activeInHierarchy && move == true)
        {
            if (l21.activeInHierarchy || l22.activeInHierarchy)
                restart();
        }

        move = false;
    }

    public void button14()
    {
        if (l14.activeInHierarchy == l24o.activeInHierarchy)
        {
            if (l14.activeInHierarchy == !l13.activeInHierarchy || l24.activeInHierarchy == !l23.activeInHierarchy)
            {
                if (l14.activeInHierarchy == !l12.activeInHierarchy || l24.activeInHierarchy == !l22.activeInHierarchy)
                {
                    if (l14.activeInHierarchy == !l11.activeInHierarchy || l24.activeInHierarchy == !l21.activeInHierarchy)
                    {
                        l14.SetActive(!l14.activeInHierarchy);
                        l24.SetActive(!l24.activeInHierarchy);
                        l14o.SetActive(!l14o.activeInHierarchy);
                        l24o.SetActive(!l24o.activeInHierarchy);
                        b14o.SetActive(!b14o.activeInHierarchy);
                        b14.SetActive(!b14.activeInHierarchy);
                        move = true;
                    }
                }
            }
        }

        if (l14.activeInHierarchy && move == true)
        {
            if (l11.activeInHierarchy || l12.activeInHierarchy || l13.activeInHierarchy)
                restart();
        }

        if (l24.activeInHierarchy && move == true)
        {
            if (l21.activeInHierarchy || l22.activeInHierarchy || l23.activeInHierarchy)
                restart();
        }

        move = false;
    }

    public void button21()
    {
        if (l21.activeInHierarchy != l31.activeInHierarchy)
        {
            l21.SetActive(!l21.activeInHierarchy);
            l31.SetActive(!l31.activeInHierarchy);
            l21o.SetActive(!l21o.activeInHierarchy);
            l31o.SetActive(!l31o.activeInHierarchy);
            b21o.SetActive(!b21o.activeInHierarchy);
            b21.SetActive(!b21.activeInHierarchy);
        }
    }

    public void button22()
    {
        if (l22.activeInHierarchy != l32.activeInHierarchy)
        {
            if (l22.activeInHierarchy == !l21.activeInHierarchy || l32.activeInHierarchy == !l31.activeInHierarchy)
            {
                l22.SetActive(!l22.activeInHierarchy);
                l32.SetActive(!l32.activeInHierarchy);
                l22o.SetActive(!l22o.activeInHierarchy);
                l32o.SetActive(!l32o.activeInHierarchy);
                b22o.SetActive(!b22o.activeInHierarchy);
                b22.SetActive(!b22.activeInHierarchy);
                move = true;
            }
        }

        if (l22.activeInHierarchy && l21.activeInHierarchy && move == true)
            restart();
        if (l32.activeInHierarchy && l31.activeInHierarchy && move == true)
            restart();

        move = false;
    }

    public void button23()
    {
        if (l23.activeInHierarchy != l33.activeInHierarchy)
        {
            if (l23.activeInHierarchy == !l22.activeInHierarchy || l33.activeInHierarchy == !l32.activeInHierarchy)
            {
                if (l23.activeInHierarchy == !l21.activeInHierarchy || l33.activeInHierarchy == !l31.activeInHierarchy)
                {
                    l23.SetActive(!l23.activeInHierarchy);
                    l33.SetActive(!l33.activeInHierarchy);
                    l23o.SetActive(!l23o.activeInHierarchy);
                    l33o.SetActive(!l33o.activeInHierarchy);
                    b23o.SetActive(!b23o.activeInHierarchy);
                    b23.SetActive(!b23.activeInHierarchy);
                    move = true;
                }
            }
        }

        if (l23.activeInHierarchy && move == true)
        {
            if (l21.activeInHierarchy || l22.activeInHierarchy)
                restart();
        }

        if (l33.activeInHierarchy && move == true)
        {
            if (l31.activeInHierarchy || l32.activeInHierarchy)
                restart();
        }

        move = false;
    }

    public void button24()
    {
        if (l24.activeInHierarchy != l34.activeInHierarchy)
        {
            if (l24.activeInHierarchy == !l23.activeInHierarchy || l34.activeInHierarchy == !l33.activeInHierarchy)
            {
                if(l24.activeInHierarchy == !l22.activeInHierarchy || l34.activeInHierarchy == !l32.activeInHierarchy)
                    if(l24.activeInHierarchy == !l21.activeInHierarchy || l34.activeInHierarchy == !l31.activeInHierarchy)
                l24.SetActive(!l24.activeInHierarchy);
                l34.SetActive(!l34.activeInHierarchy);
                l24o.SetActive(!l24o.activeInHierarchy);
                l34o.SetActive(!l34o.activeInHierarchy);
                b24.SetActive(!b24.activeInHierarchy);
                b24o.SetActive(!b24o.activeInHierarchy);
                move = true;
            }
        }

        if (l24.activeInHierarchy && move == true)
        {
            if (l21.activeInHierarchy || l22.activeInHierarchy || l23.activeInHierarchy)
                restart();
        }

        if (l34.activeInHierarchy && move == true)
        {
            if (l31.activeInHierarchy || l32.activeInHierarchy || l33.activeInHierarchy)
                restart();
        }

        move = false;
    }

    public void restart()
    {
        PlayerPrefs.SetInt("l11", 1);
        PlayerPrefs.SetInt("l12", 1);
        PlayerPrefs.SetInt("l13", 1);
        PlayerPrefs.SetInt("l14", 1);
        PlayerPrefs.SetInt("l11o", 0);
        PlayerPrefs.SetInt("l12o", 0);
        PlayerPrefs.SetInt("l13o", 0);
        PlayerPrefs.SetInt("l14o", 0);
        PlayerPrefs.SetInt("l21", 0);
        PlayerPrefs.SetInt("l22", 0);
        PlayerPrefs.SetInt("l23", 0);
        PlayerPrefs.SetInt("l24", 0);
        PlayerPrefs.SetInt("l21o", 1);
        PlayerPrefs.SetInt("l22o", 1);
        PlayerPrefs.SetInt("l23o", 1);
        PlayerPrefs.SetInt("l24o", 1);
        PlayerPrefs.SetInt("l31", 0);
        PlayerPrefs.SetInt("l32", 0);
        PlayerPrefs.SetInt("l33", 0);
        PlayerPrefs.SetInt("l34", 0);
        PlayerPrefs.SetInt("l31o", 1);
        PlayerPrefs.SetInt("l32o", 1);
        PlayerPrefs.SetInt("l33o", 1);
        PlayerPrefs.SetInt("l34o", 1);
        PlayerPrefs.SetInt("b11", 1);
        PlayerPrefs.SetInt("b12", 1);
        PlayerPrefs.SetInt("b13", 1);
        PlayerPrefs.SetInt("b14", 1);
        PlayerPrefs.SetInt("b11o", 0);
        PlayerPrefs.SetInt("b12o", 0);
        PlayerPrefs.SetInt("b13o", 0);
        PlayerPrefs.SetInt("b14o", 0);
        PlayerPrefs.SetInt("b21", 1);
        PlayerPrefs.SetInt("b22", 1);
        PlayerPrefs.SetInt("b23", 1);
        PlayerPrefs.SetInt("b24", 1);
        PlayerPrefs.SetInt("b21o", 0);
        PlayerPrefs.SetInt("b22o", 0);
        PlayerPrefs.SetInt("b23o", 0);
        PlayerPrefs.SetInt("b24o", 0);

        Start();
    }
}
