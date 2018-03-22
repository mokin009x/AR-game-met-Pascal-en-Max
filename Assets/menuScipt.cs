using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuScipt : MonoBehaviour
{
    public GameObject Menu;
    public GameObject GF;
    public Button Random;
    public InputField GuessField;
    public GameObject MenuKnop;
    public GameObject TheWon;
    public GameObject quitButton;

    private bool ja;
	// Use this for initialization
	void Start ()
	{
	   
	    ja = false;
	}
	
	// Update is called once per frame
	

    public void MenuButton()
    {
        if (ja == false)
        {
            MenuKnop.SetActive(false);
            Menu.SetActive(true);
            ja = true;
        }
        else
        {
            MenuKnop.SetActive(true);
            Menu.SetActive(false);
            ja = false;
        }
    }

    public void Confirm()
    {
        GuessField = GameObject.Find("Canvas/InputField").GetComponent<InputField>();
        if (GuessField.text == "Jeremy Clarkson" || GuessField.text == "jeremy clarkson")
        {
            TheWon.SetActive(true);
            quitButton.SetActive(true);
            Debug.Log("ehi\\kjdskjfjklf");

        }
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Guess()
    {
        Menu.SetActive(false);
        ja = false;
        GF.SetActive(true);

    }

    public void Back()
    {
        Menu.SetActive(true);
        ja = true;
        GF.SetActive(false);

    }
}
