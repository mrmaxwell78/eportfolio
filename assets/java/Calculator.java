import java.util.Scanner;

public class Calculator {
	
	public static void main(String[] args) {
		Scanner scnrInt = new Scanner(System.in);
		int userInput = 100;
		
		System.out.println("\r\n" + 
				"   ______      __           __      __              \r\n" + 
				"  / ____/___ _/ /______  __/ /___ _/ /_____  _____  \r\n" + 
				" / /   / __ `/ / ___/ / / / / __ `/ __/ __ \\/ ___/ \r\n" + 
				"/ /___/ /_/ / / /__/ /_/ / / /_/ / /_/ /_/ / /      \r\n" + 
				"\\____/\\__,_/_/\\___/\\__,_/_/\\__,_/\\__/\\____/_/\r\n" + 
				"                                by Matthew Maxwell  \r\n" + 
				"");

		System.out.println("Welcome to the Calculator program!");
		
		
		while (userInput != 0) {
			System.out.println("To use the calculator press 1, 2, 3, 4, or 5.");
			System.out.println("1 = Addition\n2 = Subtraction\n3 = Multiplication\n4 = Division\n5 = Modulo");
			System.out.println("Enter 0 to exit the calculator.");
			
			
			userInput = scnrInt.nextInt();
			
			if(userInput == 0) {
				System.out.println("Goodbye!");
				System.out.println(
						"   ______      __           __      __              \r\n" + 
						"  / ____/___ _/ /______  __/ /___ _/ /_____  _____  \r\n" + 
						" / /   / __ `/ / ___/ / / / / __ `/ __/ __ \\/ ___/ \r\n" + 
						"/ /___/ /_/ / / /__/ /_/ / / /_/ / /_/ /_/ / /      \r\n" + 
						"\\____/\\__,_/_/\\___/\\__,_/_/\\__,_/\\__/\\____/_/\r\n");

			}
		
			else {
				switch (userInput) {
					case 1: Addition();
						break;
					case 2: Subtraction();
						break;
					case 3: Multiplication();
						break;
					case 4: Division();
						break;
					case 5: Modulo();
						break;
					default: System.out.println("Please enter 1-5 or 0 to quit.");
				}
			}
			scnrInt.reset();
			
		}
		scnrInt.close();
	}

	public static void Modulo() {
		Scanner scnrDouble = new Scanner(System.in);
		double variable1 = 0;
		double variable2 = 0;
		
		double remainder = 0;
		
		System.out.println("Welcome to modulo!");
		System.out.println("Please enter two numbers to find the remainder.");
		variable1 = scnrDouble.nextDouble();
		variable2 = scnrDouble.nextDouble();
		
		remainder = variable1 % variable2;
		
		System.out.println("The remainder is " + remainder + ".\n");
	}

	public static void Division() {
		Scanner scnrDouble = new Scanner(System.in);
		double variable1 = 0;
		double variable2 = 0;
		
		double sum = 0;
		
		System.out.println("Welcome to division!");
		System.out.println("Please enter two numbers to divide.");
		variable1 = scnrDouble.nextDouble();
		variable2 = scnrDouble.nextDouble();
		
		sum = variable1 / variable2;
		
		System.out.println("The quotient is " + sum + ".\n");
	}

	public static void Multiplication() {
		Scanner scnr = new Scanner(System.in);
		int input;
		
		double sum = 1;
		
		System.out.println("Welcome to multiplication!");
		System.out.println("How many numbers would you like to multiply?");
		input = scnr.nextInt();
		
		double[] myArray = new double[input];
		
		for(int i = 0; i < input; i++) {
			System.out.println("Please enter number " + (i+1) + ".");
			myArray[i] = scnr.nextDouble();
			sum *= myArray[i];
		}
		System.out.println("The product is " + sum + ".\n");
	}

	public static void Subtraction() {
		Scanner scnr = new Scanner(System.in);
		int input;
		double sum = 0;
		
		System.out.println("Welcome to subtraction!");
		System.out.println("How many numbers would you like to subtract?");
		input = scnr.nextInt();
		
		double[] myArray = new double[input];
		
		
		for(int i = 0; i < input; i++) {
			System.out.println("Please enter number " + (i+1) + ".");
			myArray[i] = scnr.nextDouble();
			if(i == 0) {
			sum = myArray[i];
			}
			else {
				sum -= myArray[i];
			}
			
		}
	
		System.out.println("The difference of values entered is " + sum + ".\n");
	}

	public static void Addition() {
		Scanner scnr = new Scanner(System.in);
		int input;
		double sum = 0;
		
		System.out.println("Welcome to addition!");
		System.out.println("How many numbers would you like to add?");
		input = scnr.nextInt();
		
		double[] myArray = new double[input];
		
		
		for(int i = 0; i < input; i++) {
			System.out.println("Please enter number " + (i+1) + ".");
			myArray[i] = scnr.nextDouble();
			sum += myArray[i];
			
		}
	
		System.out.println("The sum of values entered is " + sum + ".\n");
	}

}
