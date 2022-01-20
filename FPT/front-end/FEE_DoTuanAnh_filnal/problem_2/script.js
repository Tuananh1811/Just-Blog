// @ts-nocheck
const table = document.querySelector('table');
const tbody = document.querySelector('tbody');
const totalPrice = table.querySelector('tfoot').querySelector('#total_price');
console.log(totalPrice);
const TotalDiscount = table.querySelector('tfoot').querySelector('#total_dis');
const Total_tax = table.querySelector('tfoot').querySelector('#total_tax');
const input = document.getElementsByTagName('input');
const btn_minuss = document.getElementsByClassName('quatity_button-prev');
const btn_pluss = document.getElementsByClassName('quatity_button-next');
const price = document.getElementsByClassName('price');
const discount = document.getElementsByClassName('discount');
const tax = document.getElementsByClassName('tax');
const totals = document.getElementsByClassName('total');
const btn_delete = document.getElementsByClassName('quatity_button-delete');
//delete
for (let i = 0; i < btn_delete.length; i++) {
    const button = btn_delete[i];
    button.addEventListener('click', function(e) {
        e.preventDefault();
        var tr = button.parentElement.parentElement;
        tbody.removeChild(tr);
        changeSumOfTotalPrice();
        changeSumOfDiscount();
        changeSumOfTax();
    })
}
//giảm
for (let i = 0; i < btn_minuss.length; i++) {
    const btn_minus = btn_minuss[i];

    btn_minus.addEventListener('click', function(e) {

            if (input[i].value == 1) {
                alert('value cannot be less than 1');
            } else {
                input[i].value = parseFloat(input[i].value) - 1;
                tax[i].innerHTML = parseFloat(price[i].innerHTML) * parseFloat(input[i].value) * parseFloat(12.5 / 100);
                totals[i].innerHTML = parseFloat(price[i].innerHTML) * parseFloat(input[i].value) - (parseFloat(discount[i].innerHTML) + parseFloat(tax[i].innerHTML));
                // totalPrice.innerHTML = parseFloat(totalPrice.innerHTML) + parseFloat(totals[i].innerHTML);
                changeSumOfTotalPrice()
                changeSumOfDiscount();
                changeSumOfTax();
            }

        }

    )
}
//tăng
for (let i = 0; i < btn_pluss.length; i++) {
    const btn_plus = btn_pluss[i];

    btn_plus.addEventListener('click', function(e) {


            input[i].value = parseFloat(input[i].value) + 1;
            console.log(input[i].value);
            tax[i].innerHTML = parseFloat(price[i].innerHTML) * parseFloat(input[i].value) * parseFloat(12.5 / 100);
            totals[i].innerHTML = parseFloat(price[i].innerHTML) * parseFloat(input[i].value) - (parseFloat(discount[i].innerHTML) + parseFloat(tax[i].innerHTML));

            changeSumOfTotalPrice();
            changeSumOfDiscount();
            changeSumOfTax();

        }

    )
}

function changeSumOfTotalPrice() {
    var trs = tbody.getElementsByTagName('tr');

    totalPrice.innerHTML = 0;
    for (let i = 0; i < trs.length; i++) {
        const tr = trs[i];
        var price = tr.children[6];
        totalPrice.innerHTML = parseFloat(price.innerHTML) + parseFloat(totalPrice.innerHTML);
        console.log(totalPrice.innerHTML)
    }
}

function changeSumOfDiscount() {
    var trs = tbody.getElementsByTagName('tr');

    TotalDiscount.innerHTML = 0;
    for (let i = 0; i < trs.length; i++) {
        const tr = trs[i];
        var discount = tr.children[4];
        TotalDiscount.innerHTML = parseFloat(discount.innerHTML) + parseFloat(TotalDiscount.innerHTML);
        // console.log(totalPrice.innerHTML)
    }
}

function changeSumOfTax() {
    var trs = tbody.getElementsByTagName('tr');

    Total_tax.innerHTML = 0;
    for (let i = 0; i < trs.length; i++) {
        const tr = trs[i];
        var tax = tr.children[5];
        Total_tax.innerHTML = parseFloat(tax.innerHTML) + parseFloat(Total_tax.innerHTML);
        // console.log(totalPrice.innerHTML)
    }
}