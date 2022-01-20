// @ts-nocheck
let RegisterButton = document.getElementById('register');
const form = document.getElementById('form');
const userName = document.querySelector('#username');
const email = document.getElementById('email');
const password = document.getElementById('password');
const rePassword = document.getElementById('repassword');

function showError(input, message) {
    var div = input.parentElement;
    div.classList.add('error');
    div.classList.remove('success');
    var small = input.nextElementSibling;
    small.innerHTML = message;
}

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

function checkPassword(minLength) {
    if (password.value.length != 0 && password.value.trim().length > minLength || rePassword.value.trim().length > minLength) {

        if (password.value == rePassword.value) {

            var div = password.parentElement;
            div.classList.add('success');
            div.classList.remove('error');
            var div1 = rePassword.parentElement;
            div1.classList.add('success');
            div1.classList.remove('error');
        } else {

            var div = rePassword.parentElement;
            div.classList.add('error');
            div.classList.remove('success');
            var small = rePassword.nextElementSibling;
            small.innerHTML = "mật khẩu không khớp";
        }
    } else {
        return 0;
    }

}
form.addEventListener('submit', function(e) {
    e.preventDefault();
    checkLength(userName, 3, 30);
    checkLength(email, 5, 30);
    checkLength(password, 8, 30);
    checkLength(rePassword, 8, 30);
    checkPassword(8);
    var nInput = userName.parentElement;
    var eInput = email.parentElement;
    var pInput = password.parentElement;
    var reInput = rePassword.parentElement;
    if (!eInput.classList.contains('error') && !pInput.classList.contains('error') &&
        !nInput.classList.contains('error') && !reInput.classList.contains('error')) {
        window.location.assign('./Login.html');
    }




});