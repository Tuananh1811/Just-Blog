// @ts-nocheck
const myQuestions = [{
        question: 'Javascript is _______ language.',
        answers: {
            a: 'Programming',
            b: 'Application',
            c: 'None of These',
            d: 'Scripting'
        },
        multi: false,
        correctAnswer: 'd'
    },
    {
        question: 'Which of the following is a valid type of function javascript supports?',
        answers: {
            a: 'named function',
            b: 'anonymous function',
            c: 'both of the above',
            d: 'none of the above'
        },
        multi: false,
        correctAnswer: 'c'
    },
    {
        question: 'Which built-in method returns the index within the calling String object of the first occurrence of the specified value ? ',
        answers: {
            a: 'getIndex()',
            b: 'location()',
            c: 'indexOf()',
            d: 'getLocation()'
        },
        multi: false,
        correctAnswer: 'c'
    },
    {
        question: 'Which one of the following is valid data type of JavaScript',
        answers: {
            a: 'number',
            b: 'void',
            c: 'boolean',
            d: 'nothing'
        },
        multi: false,
        correctAnswer: 'c'
    },
    {
        question: 'Em sắp làm đồ án. Em định làm website bán hàng. Anh có thể cho em vài option được không?=))',
        answers: {
            a: 'Website mỹ phẩm',
            b: 'Website máy ảnh',
            c: 'anh có cmt ở dưới=))',
            d: 'nothing'
        },
        multi: false,
        correctAnswer: 'c'
    }
];

const quiz = document.getElementById('quiz')
const answerEls = document.querySelectorAll('.answer')
const questionEl = document.getElementById('question')
const a_text = document.getElementById('a_text')
const b_text = document.getElementById('b_text')
const c_text = document.getElementById('c_text')
const d_text = document.getElementById('d_text')
const submitBtn = document.getElementById('submit')


let currentQuiz = 0
let score = 0

loadQuiz()

function loadQuiz() {

    deselectAnswers()
    const currentQuizData = myQuestions[currentQuiz]
    questionEl.innerText = currentQuizData.question
    a_text.innerText = currentQuizData.answers.a
    b_text.innerText = currentQuizData.answers.b
    c_text.innerText = currentQuizData.answers.c
    d_text.innerText = currentQuizData.answers.d
}

function deselectAnswers() {
    answerEls.forEach(answerEl => answerEl.checked = false)
}

function getSelected() {
    let answer
    answerEls.forEach(answerEl => {
        if (answerEl.checked) {
            answer = answerEl.id
        }
    })
    return answer
}


submitBtn.addEventListener('click', () => {
    const answer = getSelected()
    if (answer) {
        if (answer === myQuestions[currentQuiz].correctAnswer) {
            score++
        }

        currentQuiz++

        if (currentQuiz < myQuestions.length) {
            loadQuiz()
        } else {
            quiz.innerHTML = `
           <h2>You answered ${score}/${myQuestions.length} questions correctly</h2>

           <button onclick="location.reload()">Reload</button>
           `
        }
    }
})