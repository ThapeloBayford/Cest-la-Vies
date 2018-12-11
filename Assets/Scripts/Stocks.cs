using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameLogic;


public class Stocks : Asset {


	public Stocks(){}

	public int stockValue = 8;



	public int getStockValue(){

		return stockValue;
	}

	public void setStockValue( int x){

		stockValue = x;
	}
}
