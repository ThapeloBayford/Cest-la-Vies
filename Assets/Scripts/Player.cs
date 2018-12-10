
 namespace GameLogic
 {
	public class Player {

		private int currency = 50;

		
		//add to the players currency
		public int addToCurrency(int x ){
			currency +=x;
			setCurrency(currency);
			return currency;
		}

		//subtract from the players currency
		public int deductCurrency(int x ){
			currency -=x;
			setCurrency(currency);
			return currency;
		}

		//getters and setters
		public int getCurrency(){

			return currency;
		}

		public void setCurrency(int x ){

			currency = x;
		}	  
    } 
}

