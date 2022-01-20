// @ts-nocheck

const Products = [{
        ID: '1',
        Name: 'SP1',
        Img: '',
        Price: '100$',
        Promo: '10%',
        SumToTal: '195'
    },
    {
        ID: '2',
        Name: 'SP2',
        Img: '',
        Price: '100$',
        Promo: '5%',
        SumToTal: '195'
    },
    {
        ID: '3',
        Name: 'SP3',
        Img: '',
        Price: '100$',
        Promo: '5%',
        SumToTal: '195'
    },
    {
        ID: '4',
        Name: 'SP4',
        Img: '',
        Price: '100$',
        Promo: '5%',
        SumToTal: '195'
    }
]

let table = document.querySelector('table');
let tbody = table.querySelector('tbody');
let sumOfTotalPrice = table.querySelector('tfoot').querySelector('span');
let buttons = tbody.getElementsByTagName('button');
let inputs = tbody.getElementsByTagName('input');

loadDaTa();

function loadDaTa() {

    var tds = tbody.querySelectorAll('tr');
    console.log(tds);
    for (let i = 0; i < tds.length; i++) {
        const element = tds[i];
        const dataProduct = Products[i];
        const ID = element.children[0];
        const Name = element.children[1];
        const Price = element.children[3];
        const Promo = element.children[4];
        const sumTotal = element.children[6];
        ID.innerHTML = dataProduct.ID;
        Name.innerHTML = dataProduct.Name;
        Price.innerHTML = dataProduct.Price;
        Promo.innerHTML = dataProduct.Promo;
        sumTotal.innerHTML = dataProduct.SumToTal;

        console.log(element);

    }


}
var totalprice = tbody.querySelector('tr').children[3];

for (let i = 0; i < buttons.length; i++) {
    const button = buttons[i];
    button.addEventListener('click', function(e) {
        e.preventDefault();
        var tr = button.parentElement.parentElement;
        tbody.removeChild(tr);
        changeSumOfTotalPrice();
    })
}
for (let i = 0; i < inputs.length; i++) {
    const input = inputs[i];

    input.addEventListener('input', function(e) {
        e.preventDefault();
        var promotion = input.parentElement.previousElementSibling;
        var totalPrice = input.parentElement.nextElementSibling;
        totalPrice.innerHTML = parseFloat(input.value) * parseFloat(totalprice.innerHTML) -
            (parseFloat(totalprice.innerHTML) * parseFloat(promotion.innerHTML) * 0.01 * (parseFloat(input.value)));
        changeSumOfTotalPrice();
    })
}

function changeSumOfTotalPrice() {
    var trs = tbody.getElementsByTagName('tr');

    sumOfTotalPrice.innerHTML = 0;
    for (let i = 0; i < trs.length; i++) {
        const tr = trs[i];
        var totalPrice = tr.children[6];
        sumOfTotalPrice.innerHTML = parseFloat(totalPrice.innerHTML) + parseFloat(sumOfTotalPrice.innerHTML);

    }
}
changeSumOfTotalPrice();