using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Displayer : MonoBehaviour {
	 public TextMeshProUGUI Currency,Networth,numberOfHouses,numberOfCars,numberOfBusiness,numberOfStocks,priceOfHouses,priceOfCars,priceOfBusiness,priceOfStocks;


// Update is called once per frame
	void Start(){//initaite all game counters
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

	public void addHouse(){//method to add houses to the players inventory will also delete from credits
		int a = PlayerPrefs.GetInt("numberOfHouses");
		int b = PlayerPrefs.GetInt("priceOfHouses");
		int c = PlayerPrefs.GetInt("Currency");
		if (c>b){
			a++;
			c=c-b;
			PlayerPrefs.SetInt("numberOfHouses",a);
			numberOfHouses.text = PlayerPrefs.GetInt("numberOfHouses").ToString();
			PlayerPrefs.SetInt("Currency",c);
			Currency.text = PlayerPrefs.GetInt("Currency").ToString()+"K";

		}

	}
		public void addCar(){//method to add car to the players inventory will also delete from credits
		int a = PlayerPrefs.GetInt("numberOfCars");
		int b = PlayerPrefs.GetInt("priceOfCars");
		int c = PlayerPrefs.GetInt("Currency");
		if (c>b){
			a++;
			c=c-b;
			PlayerPrefs.SetInt("numberOfCars",a);
			numberOfCars.text = PlayerPrefs.GetInt("numberOfCars").ToString();
			PlayerPrefs.SetInt("Currency",c);
			Currency.text = PlayerPrefs.GetInt("Currency").ToString()+"K";

		}
		}
				public void addBusiness(){//method to add business to the players inventory will also delete from credits
		int a = PlayerPrefs.GetInt("numberOfBusiness");
		int b = PlayerPrefs.GetInt("priceOfBusiness");
		int c = PlayerPrefs.GetInt("Currency");
		if (c>b){
			a++;
			c=c-b;
			PlayerPrefs.SetInt("numberOfBusiness",a);
			numberOfBusiness.text = PlayerPrefs.GetInt("numberOfBusiness").ToString();
			PlayerPrefs.SetInt("Currency",c);
			Currency.text = PlayerPrefs.GetInt("Currency").ToString()+"K";

		}
				}
		public void addStock(){//method to add stock to the players inventory will also delete from credits
		int a = PlayerPrefs.GetInt("numberOfStocks");
		int b = PlayerPrefs.GetInt("priceOfStocks");
		int c = PlayerPrefs.GetInt("Currency");
		if (c>b){
			a++;
			c=c-b;
			PlayerPrefs.SetInt("numberOfStocks",a);
			numberOfStocks.text = PlayerPrefs.GetInt("numberOfStocks").ToString();
			PlayerPrefs.SetInt("Currency",c);
			Currency.text = PlayerPrefs.GetInt("Currency").ToString()+"K";

		}
		}
			public void removeHouse(){//method to remove House to the players inventory will also delete from credits
		int a = PlayerPrefs.GetInt("numberOfHouses");
		int b = PlayerPrefs.GetInt("priceOfHouses");
		int c = PlayerPrefs.GetInt("Currency");
		if (a>0){
			a--;
			c=c+b;
			PlayerPrefs.SetInt("numberOfHouses",a);
			numberOfHouses.text = PlayerPrefs.GetInt("numberOfHouses").ToString();
			PlayerPrefs.SetInt("Currency",c);
			Currency.text = PlayerPrefs.GetInt("Currency").ToString()+"K";

		}

	}
		public void removeCar(){//method to remove car to the players inventory will also delete from credits
		int a = PlayerPrefs.GetInt("numberOfCars");
		int b = PlayerPrefs.GetInt("priceOfCars");
		int c = PlayerPrefs.GetInt("Currency");
		if (a>0){
			a--;
			c=c+b;
			PlayerPrefs.SetInt("numberOfCars",a);
			numberOfCars.text = PlayerPrefs.GetInt("numberOfCars").ToString();
			PlayerPrefs.SetInt("Currency",c);
			Currency.text = PlayerPrefs.GetInt("Currency").ToString()+"K";

		}}
				public void removeBusiness(){//method to remove Business to the players inventory will also delete from credits
		int a = PlayerPrefs.GetInt("numberOfBusiness");
		int b = PlayerPrefs.GetInt("priceOfBusiness");
		int c = PlayerPrefs.GetInt("Currency");
		if (a>0){
			a--;
			c=c+b;
			PlayerPrefs.SetInt("numberOfBusiness",a);
			numberOfBusiness.text = PlayerPrefs.GetInt("numberOfBusiness").ToString();
			PlayerPrefs.SetInt("Currency",c);
			Currency.text = PlayerPrefs.GetInt("Currency").ToString()+"K";

		}
				}
		public void removeStock(){//method to remove Business to the players inventory will also delete from credits
		int a = PlayerPrefs.GetInt("numberOfStocks");
		int b = PlayerPrefs.GetInt("priceOfStocks");
		int c = PlayerPrefs.GetInt("Currency");
		if (a>0){
			a--;
			c=c+b;
			PlayerPrefs.SetInt("numberOfStocks",a);
			numberOfStocks.text = PlayerPrefs.GetInt("numberOfStocks").ToString();
			PlayerPrefs.SetInt("Currency",c);
			Currency.text = PlayerPrefs.GetInt("Currency").ToString()+"K";

		}
		}


	
}
