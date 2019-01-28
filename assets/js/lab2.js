function denom(tk){
    var tk20 = 20;
    var tk10 = 10;
    var tk5 = 5;
    var tk2 = 2;
    var tk1 = 1;
    var remainder;

    document.getElementById("demo0").innerHTML = "20 Tokens: ";
    document.getElementById("demo1").innerHTML = "10 Tokens: ";
    document.getElementById("demo2").innerHTML = "5 Tokens: ";
    document.getElementById("demo3").innerHTML = "2 Tokens: ";
    document.getElementById("demo4").innerHTML = "1 Tokens: ";
    
    if(tk >= 20 && tk <= 100){
        var numTk20 = Math.floor(tk / tk20);
        remainder = tk % tk20;
        document.getElementById("demo0").innerHTML = "20 Tokens: " + numTk20;
        if(remainder != 0){
        var numTk10 = Math.floor(remainder/tk10);
        remainder = remainder % tk10;
        document.getElementById("demo1").innerHTML = "10 Tokens: " + numTk10;
        }
        if(remainder != 0) {
        var numTk5 = Math.floor(remainder/tk5);
        remainder = remainder % tk5;
        document.getElementById("demo2").innerHTML = "5 Tokens: " + numTk5;
        }
        if(remainder != 0){
        var numTk2 = Math.floor(remainder/tk2);
        remainder = remainder % tk2;
        document.getElementById("demo3").innerHTML = "2 Tokens: " + numTk2;
        }
        if(remainder != 0){
        var numTk1 = Math.floor(remainder/tk1);
        document.getElementById("demo4").innerHTML = "1 Tokens: " + numTk1;
        }
        
    }
    else{
        alert("Between 20 and 100 please.");
    }
    
}