// @ts-nocheck
var submit = document.getElementById('submit');

const form = document.getElementById('form');
const email = document.getElementById('email');
const password = form.querySelector('#password');
const checkBox = form.querySelector('#checkbox');
// show error when input field is in correct
function showError(input, message) {
    var div = input.parentElement;
    div.classList.add('error');
    div.classList.remove('success');
    var small = input.nextElementSibling;
    small.innerHTML = message;
}

// change border-color to green if input field is correct.
function showSuccess(input) {
    var div = input.parentElement;
    div.classList.add('success');
    div.classList.remove('error');
}



function checkLength(input, minLength, maxLength) {
    if (input.value.trim() == '') {
        showError(input, `${input.attributes.name.value} is required!`);
    } else {
        showSuccess(input);
        if (input.value.trim().length > maxLength) {
            showError(input, `${input.attributes.name.value} must be less than ${maxLength}`);
        }
        if (input.value.trim().length < minLength && input.value.trim().length > 0) {

            showError(input, `${input.attributes.name.value} must be greater than ${minLength}`);
        }
    }



}

form.addEventListener('submit', function(e) {
    e.preventDefault();
    checkLength(email, 5, 50);
    checkLength(password, 8, 30);
    if (email.value.length >= 5 && email.value.length < 50 && password.value.length >= 8 &&
        password.value.length < 30) {

        window.location.assign('./EditProfile.html');
    }

});
// validate-addcontent