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
		Currency.text = PlayerPrefs.GetInt("Currency").ToString()+"K";
		Networth.text = PlayerPrefs.GetInt("Networth").ToString()+"K";
		numberOfHouses.text = PlayerPrefs.GetInt("numberOfHouses").ToString();
		numberOfCars.text = PlayerPrefs.GetInt("numberOfCars").ToString();
		numberOfBusiness.text = PlayerPrefs.GetInt("numberOfBusiness").ToString();
		numberOfStocks.text = PlayerPrefs.GetInt("numberOfStocks").ToString();
		priceOfHouses.text = PlayerPrefs.GetInt("priceOfHouses").ToString()+"K";
		priceOfCars.text = PlayerPrefs.GetInt("priceOfCars").ToString()+"K";
		priceOfBusiness.text = PlayerPrefs.GetInt("priceOfBusiness").ToString()+"K";
		priceOfStocks.text = PlayerPrefs.GetInt("priceOfStocks").ToString()+"K";
	}
	
	void Update () {
		 
       
	}

	public void addHouse(){
		int a = PlayerPrefs.GetInt("numberOfHouses");
		int b = PlayerPrefs.GetInt("priceOfHouses")
		if (b>a){
			a++;
			PlayerPrefs.SetInt("numberOfHouses",a);
			numberOfHouses.text = PlayerPrefs.GetInt("numberOfHouses").ToString();
		}

	}
}
