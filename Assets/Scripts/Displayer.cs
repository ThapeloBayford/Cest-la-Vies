using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Displayer : MonoBehaviour {
	 public TextMeshProUGUI Money;

// Update is called once per frame
	void Start(){
		Money = gameObject.GetComponent<TextMeshProUGUI> ();
		
	}
	
	void Update () {
		
		Money.text = "HH";
       
	}
}
