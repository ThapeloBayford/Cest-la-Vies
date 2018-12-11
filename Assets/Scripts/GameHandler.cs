
using UnityEngine;
//Had to call it randomizer because unityEngine has a Random function as well
using randomizer = System.Random;
using GameLogic;

public class GameHandler : MonoBehaviour {
	public Player player1;
	Inventory playerInventory;
	// Use this for initialization
	public static void Start() {

		Player player1 = new Player();
		Inventory playerInventory = new Inventory();
		Debug.Log("Player Inventory:" +playerInventory.getNumberOfHouses());
		PlayerPrefs.SetInt("Currency", player1.getCurrency());
		PlayerPrefs.SetInt("Networth", player1.getCurrency());
		PlayerPrefs.SetInt("numberOfHouses", 0);
		PlayerPrefs.SetInt("numberOfCars", 0);
		PlayerPrefs.SetInt("numberOfBusiness", 0);
		PlayerPrefs.SetInt("numberOfStocks", 0);
		PlayerPrefs.SetInt("priceOfHouses", 15);
		PlayerPrefs.SetInt("priceOfCars", 8);
		PlayerPrefs.SetInt("priceOfBusiness", 30);
		PlayerPrefs.SetInt("priceOfStocks", 25);


	}
		public static void Saver(int Currency,int Networth,int numberOfHouses,int numberOfCars,int numberOfBusiness,int numberOfStocks,int priceOfHouses,int priceOfCars,int priceOfBusiness,int priceOfStocks) {

		PlayerPrefs.SetInt("Currency",Currency);
		PlayerPrefs.SetInt("Networth",Networth);
		PlayerPrefs.SetInt("numberOfHouses",numberOfHouses);
		PlayerPrefs.SetInt("numberOfCars",numberOfCars);
		PlayerPrefs.SetInt("numberOfBusiness",numberOfBusiness);
		PlayerPrefs.SetInt("numberOfStocks",numberOfStocks);
		PlayerPrefs.SetInt("priceOfHouses",priceOfHouses);
		PlayerPrefs.SetInt("priceOfCars",priceOfCars);
		PlayerPrefs.SetInt("priceOfBusiness",priceOfBusiness);
		PlayerPrefs.SetInt("priceOfStocks",priceOfStocks);


	}

	public void Spin(){
		Debug.Log("Player Inventory:" +playerInventory.getNumberOfHouses());

		randomizer r = new randomizer();
		int randomEvent = r.Next(1, 5); //for ints

		switch (randomEvent)
		{		
			case 1://case one is growth
					Debug.Log("currency before growth:" +player1.getCurrency());
					player1.addToCurrency(2);

					Debug.Log("currency after growth:" +player1.getCurrency());
				break;
			case 2://depression
					Debug.Log("currency before depression:" +player1.getCurrency());
					player1.deductCurrency(22);
					Debug.Log("currency after depression:" +player1.getCurrency());
			    break;
			case 3: //stagnation
					Debug.Log("stagantion:");
			     break;
			case 4: //trough
					Debug.Log("trough:");
					break;
			default: Debug.Log("switch not executed properly");
			break;
			
		}
	}	
}
