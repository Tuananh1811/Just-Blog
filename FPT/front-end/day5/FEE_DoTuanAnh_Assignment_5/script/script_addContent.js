// @ts-nocheck
var submitAddContent = document.getElementById('submitAddContent');
const title = document.querySelector('#title');
const brief = document.querySelector('#brief');
const content = document.querySelector('#content');

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

submitAddContent.addEventListener('click', function(e) {
    e.preventDefault();
    checkLength(title, 10, 200);
    checkLength(brief, 30, 150);
    checkLength(content, 50, 1000);

});