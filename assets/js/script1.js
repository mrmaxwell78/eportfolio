//Javascript stuff goes here
function validateForm(){
var fn = document.forms["contactForm"]["fname"].value;
var ln = document.forms["contactForm"]["lname"].value;
var ad = document.forms["contactForm"]["address"].value;
var cy = document.forms["contactForm"]["city"].value;
var st = document.forms["contactForm"]["state"].value;
var ph = document.forms["contactForm"]["phone"].value;
var em = document.forms["contactForm"]["email"].value;

if(fn == null || fn == ""){
alert("Please enter a First Name.");
}

if(ln == null || ln == ""){
    alert("Please enter a Last Name.");
}

if(ad == null || ad ==""){
    alert("Please enter an Address.");
}

if(cy == null || cy == ""){
    alert("Please enter a City.");
}

if(ph == null || ph == ""){
    alert("Please enter a phone number.");
}

if(em == null || em == ""){
    alert("Please enter an email address.");
}

    if(fn.search(/^[a-zA-Z]+/) === -1){
        document.getElementById("here0").innerHTML = "First Name not Valid <br>";
    } 

    if(ln.search(/^[a-zA-Z]+/) === -1){
        document.getElementById("here1").innerHTML = "Last Name not Valid <br>";
    } else {
        document.getElementById("here1").innerHTML = fn + " " + ln;
    }

    if(cy.search(/^[a-zA-Z]+/) === -1){
        document.getElementById("here2").innerHTML = "City not Valid";
    } else {
        document.getElementById("here2").innerHTML = ad + " " + cy + ", " + st;
    }

    if(ph.search(/^(\()?\d{3}(\))?(-|\s)?\d{3}(-|\s)\d{4}$/) === -1){
        document.getElementById("here3").innerHTML = "Phone Number not Valid";
        
    } else {
        document.getElementById("here3").innerHTML = ph;
    }

    if(em.search(/^\S+@\S+\.\S+/) === -1){
        document.getElementById("here4").innerHTML = "Email not Valid";
    } else {
        document.getElementById("here4").innerHTML = em;
        return false; //this is to get it to leave the information on display 
    }
}