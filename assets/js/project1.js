/* Group Members:
*  Matthew Maxwell
*  Jordan Messano
*  Dominick Napoli
*  Peter Ocean
*/

/*
On button click call each function
inside each function prompt for input
parse the input and store it in a variable
afterwards do the operation of the button
that called it.

This way when the page loads it doesn't ask the user for input
and makes the web page functionable.
}*/

function addition(){
   //To make sure no strings are input follow the example below
   //it will keep repeating until the user enters a number --MM
   do{
      var num1 = parseFloat(prompt("Please enter a number."));
      
    }while(isNaN(num1) == true||num1==null);
    if(num1!=null){
    do{
        var num2 = parseFloat(prompt("Please a second number."));
    }while(isNaN(num2) == true);
    
    var result1 = num1 + num2;
    alert(num1 + "+" + num2 + "=" + result1);
    }
}

function subtraction(){
    do{
      var num1 = parseFloat(prompt("Please enter a number."));
    }while(isNaN(num1) == true);
    
    do{
        var num2 = parseFloat(prompt("Please a second number."));
    }while(isNaN(num2) == true);
    
    var result2 = num1 - num2;
    
    alert(num1 + "-" + num2 + "=" + result2);
}

function multiply(){
    do{
      var num1 = parseFloat(prompt("Please enter a number."));
    }while(isNaN(num1) == true);
    
    do{
        var num2 = parseFloat(prompt("Please a second number.."));
    }while(isNaN(num2) == true);

    var result3 = num1 * num2;
    
    alert(num1 + "*" + num2 + "=" + result3);
}

function division(){
    do{
      var num1 = parseFloat(prompt("Please enter a number."));
    }while(isNaN(num1) == true);
    
    do{
        var num2 = parseFloat(prompt("Please a second number."));
    }while(isNaN(num2) == true);
    
    var result4 = num1 / num2;
    
    alert(num1 + "/" + num2 + "=" + result4);
}
