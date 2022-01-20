// @ts-nocheck
var images = [{
        src: "https://kenhthoitiet.vn/wp-content/uploads/2019/01/hoang-hon-ta-xua1.jpg",
        width: "800",
        height: "430"
    },
    {
        src: "https://i.khoahoc.tv/photos/image/2018/07/01/hoang-hon.jpg",
        width: "800",
        height: "430"
    },
    {
        src: "https://mb.dkn.tv/wp-content/uploads/2019/08/hoang-hon.jpg",
        width: "800",
        height: "430"
    },
    {
        src: "https://2.bp.blogspot.com/-VeAfHPn7r90/Wrtv_nIQOtI/AAAAAAAABGg/LNACFtBsKNAYry2yPE0YPYX7UqTrSpr6QCLcBGAs/s1600/hoang-hon-dep%2B%25283%2529.jpg",
        width: "800",
        height: "430"
    },
    {
        src: "https://c.wallhere.com/photos/04/0b/lake-55378.jpg!d",
        width: "800",
        height: "430"
    },
    {
        src: "https://lh5.googleusercontent.com/xES28WNiW2BioMQhYOyW3qgWM-R_Z95IP8P0hiwlTUKrzjZRg_lPwxVBi5vq-3rIELxtT7EQ",
        width: "800",
        height: "430"
    },
    {
        src: "https://hinhanhdep.net/wp-content/uploads/2017/12/hinh-nen-hoang-hon-dep-36.jpg",
        width: "800",
        height: "330"
    }

]
var btnButton = document.getElementById('select');
btnButton.addEventListener('click', function() {
    random_index1 = Math.floor(Math.random() * images.length);
    selected_images1 = images[random_index1];
    document.getElementById('img1').src = selected_images1.src;
    document.getElementById('img1').width = selected_images1.width;
    document.getElementById('img1').height = selected_images1.height;
    //2
    console.log(random_index1);
    var random_index2;
    do {
        random_index2 = Math.floor(Math.random() * images.length);
        selected_images2 = images[random_index2];
    } while (random_index2 == random_index1)
    document.getElementById('img2').src = selected_images2.src;
    document.getElementById('img2').width = selected_images2.width;
    document.getElementById('img2').height = selected_images2.height;
    //3
    console.log(random_index2);
    var random_index3;
    do {
        random_index3 = Math.floor(Math.random() * images.length);
        selected_images3 = images[random_index3];
    } while (random_index3 == random_index1 || random_index3 == random_index2)
    document.getElementById('img3').src = selected_images3.src;
    document.getElementById('img3').width = selected_images3.width;
    document.getElementById('img3').height = selected_images3.height;
    console.log(random_index3);
})


function randomImages() {
    //1
    random_index1 = Math.floor(Math.random() * images.length);
    selected_images1 = images[random_index1];
    document.getElementById('img1').src = selected_images1.src;
    document.getElementById('img1').width = selected_images1.width;
    document.getElementById('img1').height = selected_images1.height;
    //2
    console.log(random_index1);
    var random_index2;
    do {
        random_index2 = Math.floor(Math.random() * images.length);
        selected_images2 = images[random_index2];
    } while (random_index2 == random_index1)
    document.getElementById('img2').src = selected_images2.src;
    document.getElementById('img2').width = selected_images2.width;
    document.getElementById('img2').height = selected_images2.height;
    //3
    console.log(random_index2);
    var random_index3;
    do {
        random_index3 = Math.floor(Math.random() * images.length);
        selected_images3 = images[random_index3];
    } while (random_index3 == random_index1 || random_index3 == random_index2)
    document.getElementById('img3').src = selected_images3.src;
    document.getElementById('img3').width = selected_images3.width;
    document.getElementById('img3').height = selected_images3.height;
    console.log(random_index3);
}