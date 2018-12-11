using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Displayer : MonoBehaviour {
	 public TextMeshProUGUI Currency,Networth,numberOfHouses,numberOfCars,numberOfBusiness,numberOfStocks,priceOfHouses,priceOfCars,priceOfBusiness,priceOfStocks;


// Update is called once per frame
	void Start(){
	//	Money = gameObject.GetComponent<TextMeshProUGUI> ();
		Currency.text =  PlayerPrefs.GetInt("Currency").ToString();
	}
	
	void Update () {
		
       
	}
}
