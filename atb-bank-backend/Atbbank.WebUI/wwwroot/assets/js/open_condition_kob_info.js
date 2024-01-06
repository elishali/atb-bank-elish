function OpenKobCredit() {
    var openkobbtn = document.getElementById("openkobcreditbtn");
    var kobmenu = document.getElementById("KOB_menu");
    var kobtittle = document.getElementById("kobtittle");
    var openicon = document.getElementById("openicon");

    
    if (kobmenu.style.display === "none") {
        kobmenu.style.display = "block";
        kobtittle.style.color="#6F0BBB";
        openicon.className="fa-solid fa-minus";

    } else {
        kobmenu.style.display = "block";
        kobmenu.style.display = "none";
        kobtittle.style.color="black"
        openicon.className="fa-solid fa-plus";

    }
}

function OpenConditionMenu() {
    var openconditionbtn = document.getElementById("OpenConditionMenu");
    var openkonditionmenu = document.getElementById("condition_menu");
    var contittle = document.getElementById("contittle");
    var openiconcon = document.getElementById("openiconcon");

    
    if (openkonditionmenu.style.display === "none") {
        openkonditionmenu.style.display = "block";
        contittle.style.color="#6F0BBB";
        openiconcon.className="fa-solid fa-minus";

    } else {
        openkonditionmenu.style.display = "block";
        openkonditionmenu.style.display = "none";
        contittle.style.color="black"
        openiconcon.className="fa-solid fa-plus";

    }
}

function Open_interest_rates_menu() {
    var interest_rates_menu = document.getElementById("interest_rates_menu");
    var interest_rates_tittle = document.getElementById("interest_rates_tittle");
    var openiconcon = document.getElementById("openiconcon");

    
    if (interest_rates_menu.style.display === "none") {
        interest_rates_menu.style.display = "block";
        interest_rates_tittle.style.color="#6F0BBB";
        openiconcon.className="fa-solid fa-minus";

    } else {
        interest_rates_menu.style.display = "block";
        interest_rates_menu.style.display = "none";
        interest_rates_tittle.style.color="black"
        openiconcon.className="fa-solid fa-plus";

    }
}

function OpenrequirementsMenu() {
    var requirements_menu = document.getElementById("requirements_menu");
    var requirementstittle = document.getElementById("requirementstittle");
    var openiconcon = document.getElementById("openiconcon");

    
    if (requirements_menu.style.display === "none") {
        requirements_menu.style.display = "block";
        requirementstittle.style.color="#6F0BBB";
        openiconcon.className="fa-solid fa-minus";

    } else {
        requirements_menu.style.display = "block";
        requirements_menu.style.display = "none";
        requirementstittle.style.color="black"
        openiconcon.className="fa-solid fa-plus";

    }
}