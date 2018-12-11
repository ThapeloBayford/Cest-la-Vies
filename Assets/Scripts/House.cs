using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic;


public class House : Asset {

	public House(){}

	public int houseValue = 8;


	public int getHouseValue(){

		return houseValue;
	}

	public void setHouseValue( int x){

		 houseValue = x;
	}
}
