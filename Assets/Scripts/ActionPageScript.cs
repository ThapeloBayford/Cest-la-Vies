
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using GameLogic;


public class ActionPageScript : MonoBehaviour {

		//Text currencyText;
	    TextMeshProUGUI Money;
		private bool keyIsPressed;
		private int playersCurrency;
		Player player1 = new Player();
		

	// Use this for initialization
	void Start () {
		PlayerPrefs.DeleteAll();
		playersCurrency = player1.getCurrency();
		Money = gameObject.GetComponent<TextMeshProUGUI>();

		Debug.Log("PlayerPrefs check:" +PlayerPrefs.GetInt("playersCurrency"));

	}
	
	// Update is called once per frame
	void Update () {

		// press space bar to see the increment to the player currency saved in the playerRefs
	 if(Input.GetKeyDown (KeyCode.Space)){
		    //Money.text = PlayerPrefs.GetInt("playersCurrency").ToString();

			player1.addToCurrency(1);
			playersCurrency = player1.getCurrency();

			Debug.Log("PlayerPrefs check--0:" +playersCurrency);
	
			PlayerPrefs.SetInt("playersCurrency",playersCurrency);

	 }

	  if(Input.GetKeyUp (KeyCode.Space)){
			keyIsPressed = false;
	 }
   }
}
