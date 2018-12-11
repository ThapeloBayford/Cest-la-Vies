using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic;


public class Business : Asset {

	
	public Business(){}

	
	public int businessValue = 8;


	

	public int carMulitplierBonus(int x ){
		
		businessValue*=x;
		setBusinessValue(businessValue);
		return businessValue;

	} 

	public int getBusinessValue(){

		return businessValue;
	}

	public void setBusinessValue( int x){

		 businessValue = x;
	}
}
