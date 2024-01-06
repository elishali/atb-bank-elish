function OpenCash() {
    var cash_main = document.getElementById("cash_main");
    var deposit_main = document.getElementById("deposit_main");
    var cash = document.getElementById("cash");
    var deposit = document.getElementById("deposit");
    
    if (cash_main.style.display === "none") {
        cash_main.style.display = "block";
        deposit_main.style.display="none"
        deposit_order.style.display="none";
        cash.style.backgroundColor="#6F0BBB";
        cash.style.color="white";
        deposit.style.backgroundColor="#f3f3f3";
        deposit.style.color="black";
    } else {
        cash_main.style.display = "block";
        deposit_main.style.display = "none";
        cash.style.backgroundColor="#6F0BBB";
        cash.style.color="white";
        deposit.style.backgroundColor="#f3f3f3";
        deposit.style.color="black";
    }
}

function OpenDeposit() {
    var cash_main = document.getElementById("cash_main");
    var deposit_main = document.getElementById("deposit_main");
    var deposit = document.getElementById("deposit");
    var cash = document.getElementById("cash");
    var cash_order = document.getElementById("cash_order");
    
    if (deposit_main.style.display === "none") {
        deposit_main.style.display = "block";
        cash_main.style.display="none";
        cash_order.style.display="none";
        deposit.style.backgroundColor="#6F0BBB";
        deposit.style.color="white";
        cash.style.backgroundColor="#f3f3f3";
        cash.style.color="black";

    } else {
        deposit_main.style.display = "block";
        cash_main.style.display = "none";
        deposit.style.backgroundColor="#6F0BBB";
        deposit.style.color="white";
        cash.style.backgroundColor="#f3f3f3";
        cash.style.color="black";
    }
}
