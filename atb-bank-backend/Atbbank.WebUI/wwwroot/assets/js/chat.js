function openchat() {
    var chatmain = document.getElementById("chat_main");
    var chatbtn = document.getElementById("chatbtn");
    
    if (chatmain.style.display === "none") {
        chatmain.style.display = "block";
        chatbtn.style.display = "none";
    } else {
        chatmain.style.display = "none";
        chatbtn.style.display = "block";
    }
}

function closechat() {
    var chatmain = document.getElementById("chat_main");
    var closechat = document.getElementById("closechat");
    
    if (chatmain.style.display === "none") {
        chatmain.style.display = "block";
        chatbtn.style.display = "none";
    } else {
        chatmain.style.display = "none";
        chatbtn.style.display = "block";
    }
}