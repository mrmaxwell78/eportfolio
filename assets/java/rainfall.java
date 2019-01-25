import java.util.Scanner;
public class rainfall {

	public static void main(String[] args) {
		final int months = 12;
		double[] rainy = new double[months];
		String[] Month = {"January", "February", "March", "April", "May", "June", 
				"July", "August", "September", "October", "November", "December"};
		Scanner scnr = new Scanner(System.in);
		
		for(int i = 0; i < months; i++) {
		System.out.println("Please enter data for month " + (i+1) + ": ");
		rainy[i] = scnr.nextDouble();
		}
		totalrain(rainy);
		minmaxrain(rainy, Month);
		scnr.close();
	}

	private static void minmaxrain(double[] rainy, String[] Month) {
		double min = 100;
		double max = 0;
		
		for(int i = 0; i < rainy.length; i++) {
			if(rainy[i] > max) 
				max = rainy[i];
			
			if(rainy[i] < min) 
				min = rainy[i];
		}
		
		for(int i = 0; i < rainy.length; i++) {
			if(rainy[i] == min) {
			System.out.println("The least rain was " + min + "." + " In the month of " + Month[i] + ".");
			}
			if(rainy[i] == max) {
				System.out.println("The most rain was " + max + "." + " In the month of " + Month[i] + ".");
			}
		}
			
			
			
		}
		
	

	private static void totalrain(double[] rainy) {
		double total = 0;
		
		for(int i = 0; i < rainy.length; i++) {
			total += rainy[i];
		}
		System.out.println("The total rainfall is " + total + ".");
		
		avgrain(total);
	}

	private static void avgrain(double total) {
		double average = 0;
		
		average = total / 12;
		System.out.println("The average rainfall is " + average + ".");
		
	}

}
