
public class Temperature {
		//public fields
		private double ftemp;
		
		//constructor
		public Temperature(double temp){
			ftemp = temp;
		}
		//mutators
		public void setFahrenheit(double temp) {
			ftemp = temp;
		}
		//accessors
		public double getFahrenheit() {
			return ftemp;
		}
		public double getCelsius() {
			double cel;
					//5/9 needs to be 5.0 / 9.0 or some variaton of that for it to work correctly
			cel = ((5.0/9.0) * (ftemp - 32));
			return cel;
		}
		public double getKelvin() {
			double kel;
			
			kel = (((5.0/9.0) * (ftemp-32)) + 273);
			return kel;
		}
		
}
