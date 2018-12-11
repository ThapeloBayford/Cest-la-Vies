using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic;

public class Car : Asset{

	public Car(){}

	public int carValue = 8;

	public int subtractDepreciation(int x){
	 	carValue-= x;
		setCarValue(carValue);
		return carValue;
	}

	public int getCarValue(){

		return carValue;
	}

	public void setCarValue( int x){

		 carValue = x;
	}
}
