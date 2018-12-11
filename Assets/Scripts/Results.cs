using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.GameObject;

public class Results : MonoBehaviour {

	public GameObject Business;
	public GameObject Stock;
	public GameObject Car;
	public GameObject House;
	public GameObject Business1;
	public GameObject Stock1;
	public GameObject Car1;
	public GameObject House1;

	// Use this for initialization
	void Start () {

				switch (PlayerPrefs.GetInt("state"))
		{		
			case 1://case one is growth
					Business1.setActive(false);
					Stock1.setActive(false);
					House1.setActive(false);
					Car.setActive(false);
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
	
	// Update is called once per frame
	void Update () {
		
	}
}
