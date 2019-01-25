import java.util.Scanner;

public class testTemperature {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner scnr = new Scanner(System.in);
		Temperature temp1 = new Temperature(100.0);
		double temp;
		
		System.out.println("What is the temperature in fahrenheit?");
		temp = scnr.nextDouble();
		temp1.setFahrenheit(temp);
		
		System.out.println(temp1.getFahrenheit() + " degrees F");
		System.out.println(temp1.getCelsius() + " degrees C");
		System.out.println(temp1.getKelvin() + " degrees K");
		scnr.close();
	}

}
