using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
	void Awake () {

				switch (1)
		{		
			case 1://case one is growth
					Business1.SetActive(false);
					Stock1.SetActive(false);
					House1.SetActive(false);
					Car.SetActive(false);
				break;
			case 2://depression
					Business.SetActive(false);
					Stock.SetActive(false);
					House.SetActive(false);
					Car.SetActive(false);
			    break;
			case 3: //trough
					Business1.SetActive(false);
					Stock1.SetActive(false);
					Stock.SetActive(false);
					House1.SetActive(false);
					Car.SetActive(false);
			     break;
			case 4: //peak
					Business1.SetActive(false);
					Stock1.SetActive(false);
					House1.SetActive(false);
					Car.SetActive(false);
					break;
			default: Debug.Log("switch not executed properly");
			break;
			
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
