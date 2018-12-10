
using UnityEngine;
//Had to call it randomizer because unityEngine has a Random function as well
using randomizer = System.Random;
using GameLogic;

public class GameHandler : MonoBehaviour {
	Player player1;
	Inventory playerInventory;
	// Use this for initialization
	public static void Start() {

		Player player1 = new Player();
		Inventory playerInventory = new Inventory();
		Debug.Log("Player Inventory:" +playerInventory.getNumberOfHouses());
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
