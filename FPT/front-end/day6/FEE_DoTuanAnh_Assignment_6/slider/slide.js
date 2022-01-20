const body = document.body
const slides = document.querySelectorAll('.slide')
const leftBtn = document.getElementById('left')
const rightBtn = document.getElementById('right')
let index = 0

rightBtn.addEventListener('click', function nextSlide() {
    index++

    if (index > slides.length - 1) {
        index = 0
    }
    setActiveSlides()
})
leftBtn.addEventListener('click', function prevSlide() {
    index--

    if (index < 0) {
        index = slides.length - 1
    }
    setActiveSlides()
})

function setActiveSlides() {
    slides.forEach((slide) => slide.classList.remove('active'))
    slides[index].classList.add('active')
}