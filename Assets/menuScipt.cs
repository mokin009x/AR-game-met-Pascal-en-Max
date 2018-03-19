using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuScipt : MonoBehaviour
{
    public GameObject Menu;
    public GameObject GF;
    public InputField GuessField;

    private bool ja;
	// Use this for initialization
	void Start ()
	{
	    ja = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (GuessField.text =="Jermery Clarkson")
	    {
	        Application.Quit();
            Debug.Log("ehi\\kjdskjfjklf");
             
	    }

	  
	}

    public void MenuButton()
    {
        if (ja == false)
        {
            Menu.SetActive(true);
            ja = true;
        }
        else
        {
            Menu.SetActive(false);
            ja = false;
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
}
