var inputpass = document.getElementById("inputpass");
var confirmpass = document.getElementById("confirmpass");

function validatePassword() {
    if (inputpass.value != confirmpass.value) {
        confirmpass.setCustomValidity("Passwords Don't Match");
    } else {
        confirmpass.setCustomValidity('');
    }
}

inputpass.onchange = validatePassword;
confirmpass.onkeyup = validatePassword;
