using randomizer = System.Random;
using UnityEngine;
using GameLogic;


public class SpinPageScript : MonoBehaviour {
	
	private int currentCurrency ;

	// Use this for initialization
	void Start () {

		Debug.Log("PlayerPrefs check spin page :" +PlayerPrefs.GetInt("playersCurrency"));
		Player player1 = new Player();

		randomizer r = new randomizer();
		int randomEvent = r.Next(1, 5); //for ints

		switch (randomEvent)
		{		
			case 1://case one is growth
					currentCurrency = player1.addToCurrency(2);
					PlayerPrefs.SetInt("playersCurrency",currentCurrency);

					Debug.Log(PlayerPrefs.GetInt("playersCurrency"));
				break;
			case 2://depression
					

					currentCurrency = player1.deductCurrency(1);
					PlayerPrefs.SetInt("playersCurrency",currentCurrency);

					Debug.Log(PlayerPrefs.GetInt("playersCurrency"));
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
	
	// Update is called once per frame
	void Update () {
		
	}
}
