function opencredit() {
    var credit_btn = document.getElementById("credit_btn");
    var credit_payment_main = document.getElementById("credit_payment_main");
    var cashincard_btn = document.getElementById("cashincard_btn");
    var cashincard_main = document.getElementById("cashincard_main");
    var depositbox_btn = document.getElementById("depositbox_btn");
    var depositbox_main = document.getElementById("depositbox_main");

    if (credit_payment_main.style.display === "none") {
        credit_payment_main.style.display = "block";
        credit_btn.style.backgroundColor="#34035D";
        cashincard_main.style.display="none"
        depositbox_main.style.display="none";
        cashincard_btn.style.backgroundColor="#9d70c0";
        depositbox_btn.style.backgroundColor="#9d70c0";
    } else {
        credit_payment_main.style.display = "block";
        cashincard_main.style.display="none"
        depositbox_main.style.display="none";

    }
}


function opencash() {
    var credit_btn = document.getElementById("credit_btn");
    var credit_payment_main = document.getElementById("credit_payment_main");
    var cashincard_btn = document.getElementById("cashincard_btn");
    var cashincard_main = document.getElementById("cashincard_main");
    var depositbox_btn = document.getElementById("depositbox_btn");
    var depositbox_main = document.getElementById("depositbox_main");

    if (cashincard_main.style.display === "none") {
        cashincard_main.style.display = "block";
        cashincard_btn.style.backgroundColor="#34035D";
        credit_payment_main.style.display="none"
        depositbox_main.style.display="none";
        credit_btn.style.backgroundColor="#9d70c0";
        depositbox_btn.style.backgroundColor="#9d70c0";

    } else {
        cashincard_main.style.display = "block";
        credit_payment_main.style.display="none"
        depositbox_main.style.display="none";

    }
}

function opendepositbox() {
    var credit_btn = document.getElementById("credit_btn");
    var credit_payment_main = document.getElementById("credit_payment_main");
    var cashincard_btn = document.getElementById("cashincard_btn");
    var cashincard_main = document.getElementById("cashincard_main");
    var depositbox_btn = document.getElementById("depositbox_btn");
    var depositbox_main = document.getElementById("depositbox_main");

    if (depositbox_main.style.display === "none") {
        depositbox_main.style.display = "block";
        depositbox_btn.style.backgroundColor="#34035D";
        cashincard_main.style.display="none"
        credit_payment_main.style.display="none";
        credit_btn.style.backgroundColor="#9d70c0";
        cashincard_btn.style.backgroundColor="#9d70c0";

    } else {
        depositbox_main.style.display = "block";
        cashincard_main.style.display="none"
        credit_payment_main.style.display="none";

    }
}