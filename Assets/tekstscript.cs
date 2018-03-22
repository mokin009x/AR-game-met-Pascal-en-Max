using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tekstscript : MonoBehaviour {
	string displayTekst = "A savage crime has taken place!";
	string displayTekst2 = "The victim died by brutal force.";
	string displayTekst3 = "You need to find out who the culprit is.";
	string displayTekst4 = "The only lead we have is that the suspect is connected to cars ";
    string displayTekst5 = "maybe this information will help you?";
    string displayTekst6 = "Good luck!";
	string displayTekst7 = "Detective Ben Dover";
	public Text displayTB;
	public Text displayTB2;
	public Text displayTB3;
	public Text displayTB4;
	public Text displayTB5;
	public Text displayTB6;
    public Text displayTB7;

    float timer;
	float timerAmount;
	int amountToDisplay;
	int tempAmountToDisplay;
	int amountDisplayT1;
	int amountDisplayT2;
	int amountDisplayT3;
	int amountDisplayT4;
	int amountDisplayT5;
	int amountDisplayT6;
    int amountDisplayT7;
    public GameObject buttonStart;

	// Use this for initialization
	void Start ()
	{
        buttonStart.SetActive(false);
		timerAmount = 0.05f;
		timer = timerAmount;
		amountToDisplay = 0;
	}
	
	// Update is called once per frame
	void Update () {
		TimerCheck ();
		RPGTextDisplay ();

	}

	void RPGTextDisplay(){
			tempAmountToDisplay = amountToDisplay;
			if (tempAmountToDisplay > displayTekst.Length){
				tempAmountToDisplay = tempAmountToDisplay - displayTekst.Length;
				amountDisplayT1 = displayTekst.Length;
			}
			else {
				amountDisplayT1 = tempAmountToDisplay;
			tempAmountToDisplay = 0;
			}
			displayTB.text = displayTekst.Substring (0, amountDisplayT1);
		if (tempAmountToDisplay > displayTekst2.Length){
			tempAmountToDisplay = tempAmountToDisplay - displayTekst2.Length;
			amountDisplayT2 = displayTekst2.Length;
		}
		else {
			amountDisplayT2 = tempAmountToDisplay;
			tempAmountToDisplay = 0;
		}
		displayTB2.text = displayTekst2.Substring (0, amountDisplayT2);
		if (tempAmountToDisplay > displayTekst3.Length){
			tempAmountToDisplay = tempAmountToDisplay - displayTekst3.Length;
			amountDisplayT3 = displayTekst3.Length;
		}
		else {
			amountDisplayT3 = tempAmountToDisplay;
			tempAmountToDisplay = 0;
		}
		displayTB3.text = displayTekst3.Substring (0, amountDisplayT3);
		if (tempAmountToDisplay > displayTekst4.Length){
			tempAmountToDisplay = tempAmountToDisplay - displayTekst4.Length;
			amountDisplayT4 = displayTekst4.Length;
		}
		else {
			amountDisplayT4 = tempAmountToDisplay;
			tempAmountToDisplay = 0;
		}
		displayTB4.text = displayTekst4.Substring (0, amountDisplayT4);
		if (tempAmountToDisplay > displayTekst5.Length){
			tempAmountToDisplay = tempAmountToDisplay - displayTekst5.Length;
			amountDisplayT5 = displayTekst5.Length;
		}
		else {
			amountDisplayT5 = tempAmountToDisplay;
			tempAmountToDisplay = 0;
		}
		displayTB5.text = displayTekst5.Substring (0, amountDisplayT5);
		if (tempAmountToDisplay > displayTekst6.Length){
			tempAmountToDisplay = tempAmountToDisplay - displayTekst6.Length;
			amountDisplayT6 = displayTekst6.Length;
		}
		else {
			amountDisplayT6 = tempAmountToDisplay;
			tempAmountToDisplay = 0;
		}
		displayTB6.text = displayTekst6.Substring (0, amountDisplayT6);

	    if (tempAmountToDisplay > displayTekst7.Length)
	    {
	        tempAmountToDisplay = tempAmountToDisplay - displayTekst7.Length;
	        amountDisplayT7 = displayTekst7.Length;
	    }
	    else
	    {
	        amountDisplayT7 = tempAmountToDisplay;
	        tempAmountToDisplay = 0;
	    }
	    displayTB7.text = displayTekst7.Substring(0, amountDisplayT7);

	    if (amountToDisplay >= displayTekst.Length + displayTekst2.Length + displayTekst3.Length + displayTekst4.Length +
	        displayTekst5.Length + displayTekst6.Length + displayTekst7.Length)
	    {
            buttonStart.SetActive(true);
	    }
    }

    void TimerCheck(){
		timer = timer - Time.deltaTime;
		if (timer <= 0f) {
			timer = timerAmount;
			amountToDisplay++;
		}
	}
}
