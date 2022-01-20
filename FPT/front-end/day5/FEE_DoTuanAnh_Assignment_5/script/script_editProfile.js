// @ts-nocheck
const submitButton = document.getElementById('submitButton');
const resetButton = document.getElementById('resetButton');
const firstName = document.getElementById('firstName');
const lastName = document.getElementById('lastName');
const email = document.getElementById('email');
const phone = document.getElementById('phone');
const discript = document.getElementById('discription');

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

    // checkRequired([email, password]);

}
submitButton.addEventListener('click', function(e) {
    e.preventDefault();
    checkLength(firstName, 3, 30);
    checkLength(lastName, 3, 30);
    checkLength(email, 9, 30);
    checkLength(phone, 9, 13);
    checkLength(discript, 1, 200);
})
resetButton.addEventListener('click', function(input) {
    const form = document.getElementById('formProfile').reset();

})