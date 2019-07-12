// Function constructor
/*
var john = {
    name: 'John',
    yearOfBirth: 1990,
    job: 'teacher'
};

var Person = function(name, yearOfBirth, job) {
    this.name = name;
    this.yearOfBirth = yearOfBirth;
    this.job = job;
};

Person.prototype.calculateAge = function() {
    console.log(2019-this.yearOfBirth);
};

Person.prototype.lastName = 'Smith';


var john = new Person('John', 1990, 'teacher'); // "Instantiation"
var jane = new Person('Jane', 1969, 'designer');
var mark = new Person('Mark', 1948, 'retired' );

john.calculateAge();
jane.calculateAge();
mark.calculateAge();

console.log(john.lastName);
console.log(jane.lastName);
console.log(mark.lastName);
*/


// Object.create
/*
var personProto = {
    calculateAge: function() {
        console.log(2019-this.yearOfBirth);
    }
};

var john = Object.create(personProto);
john.name = 'John';
john.yearOfBirth = 1990;
john.job = 'teacher';

var jane = Object.create(personProto, {
    name: { value: 'Jane' },
    yearOfBirth: { value: 1969 },
    job: { value: 'designer' }
});
*/


// Primitives vs objects
/*
// Primitives
var a = 23;
var b = a;
a = 46;
console.log(a);
console.log(b);


// Objects
var obj1 = {
    name: 'John',
    age: 26
};

var obj2 = obj1;
obj1.age = 30;
console.log(obj1.age);
console.log(obj2.age);

// Functions
var age = 27;
var obj = {
    name:'Jonas',
    city: 'Lisbon'
};

function change(a,b) {
    a = 30;
    b.city = 'San Francisco'; 
};

change(age, obj); // age doesn't change, but obj changes. It's a reference that 
                  // points to the object that we pass to the function.
console.log(age);
console.log(obj.city);
*/
// Passing functions as arguments
/*
var years = [1990, 1965, 1937, 2005, 1998];


function arrayCalc(arr, fn){
    var arrRes = [];
    for (i = 0; i < arr.length; i++) {
        arrRes.push(fn(arr[i]));
    }
    return arrRes;
}

function calculateAge(el) {
    return 2019 - el;
}

function isFullAge(el) {
    return el >= 18;
}

function maxHeartRate(el){
    if (el >= 18 && el <= 81)
        return Math.round (206.9 - (0.67 * el));
    else 
        return -1;
}

var ages = arrayCalc(years, calculateAge);
var fullAges = arrayCalc(ages, isFullAge);
var rates = arrayCalc(ages, maxHeartRate);

console.log(ages);
console.log(fullAges);
console.log(rates);
*/

// Functions returning functions
/*
function interviewQuestion(job) {
    if (job === 'designer') {
        return function(name) {
            console.log(name + ', can you please explain what UX design is?');
        }
    }
    else if (job === 'teacher'){
        return function(name) {
            console.log('What subject do you teach, ' + name +'?');
        }
    }
    else {
        return function(name) {
            console.log('Hello ' + name + ', what do you do?');
        }
    }
}

var teacherQuestion = interviewQuestion('teacher');
var designerQuestion = interviewQuestion('designer');


teacherQuestion('John');
designerQuestion('Jane');

interviewQuestion('driver')('Mark');
*/


// Immediately invoked function expressions (IIFE)
/*
function game() {
    var score = Math.random() * 10;
    console.log(score >= 5);
}
game();


(function () {
    var score = Math.random() * 10;
    console.log(score >= 5);
})(); // This block is an IIFE

//console.log(score);

(function (goodLuck) {
    var score = Math.random() * 10;
    console.log(score >= 5 - goodLuck);
})(5); // <--- goodLuck-value is here 
*/

// Closures
/*
function retirement(retirementAge) {
    var a = ' years left until retirement.';
    return function(yearOfBirth) {
        var age = 2019 - yearOfBirth;
        console.log((retirementAge - age) + a);
    }
}

var retirementUS = retirement(66);
var retirementGermany = retirement(65);
var retirementIceland = retirement(67);
retirementUS(1990);
retirementGermany(1990);
retirementIceland(1990);

//retirement(66)(1990);

function interviewQuestion(job){
    return function(name) {
        if (job === 'designer')
                console.log(name + ', can you please explain what UX design is?')
        else if (job === 'teacher') 
                console.log('What subject do you teach, ' + name +'?');
        else 
                console.log('Hello ' + name + ', what do you do?');
    }
}

interviewQuestion('teacher')('John');
interviewQuestion('designer')('Jane');
interviewQuestion('driver')('Mark');
*/


//Bind, call and apply
/*
var john = {
    name: 'John',
    age: 26,
    job: 'teacher',
    presentation: function(style, timeOfDay) {
        if (style === 'formal') {
            console.log('Good ' + timeOfDay + ', ladies and gentlemen. I\'m ' +
            this.name + ', I\'m a ' +
            this.job + ' and I\'m ' + 
            this.age + ' years old.');
        } 
        else if (style === 'friendly') {
            console.log('Hey! What\'s up? I\'m ' +
            this.name + ', I\'m a ' +
            this.job + ' and I\'m ' + 
            this.age + ' years old. Have a nice ' + 
            timeOfDay + '.');
        }
    }
};

var emily = {
    name: 'Emily',
    age: 35,
    job: 'designer'
};

john.presentation('formal', 'morning');

john.presentation.call(emily, 'friendly', 'afternoon');

//john.presentation.apply(emily, ['friendly', 'afternoon']);

var johnFriendly = john.presentation.bind(john, 'friendly');

johnFriendly('morning');
johnFriendly('night');

var emilyFormal = john.presentation.bind(emily, 'formal');
emilyFormal('afternoon');



var years = [1990, 1965, 1937, 2005, 1998];


function arrayCalc(arr, fn){
    var arrRes = [];
    for (i = 0; i < arr.length; i++) {
        arrRes.push(fn(arr[i]));
    }
    return arrRes;
}

function calculateAge(el) {
    return 2019 - el;
}

function isFullAge(limit, el) {
    return el >= limit;
}

var ages = arrayCalc(years, calculateAge);

var fullJapan = arrayCalc(ages, isFullAge.bind(this, 20));
console.log(ages);
console.log(fullJapan);
*/

// Challenge 7

/*
--- Let's build a fun quiz game in the console! ---

1. Build a function constructor called Question to describe a question. A question should include:
a) question itself
b) the answers from which the player can choose the correct one (choose an adequate data structure here, array, object, etc.)
c) correct answer (I would use a number for this)

2. Create a couple of questions using the constructor

3. Store them all inside an array

4. Select one random question and log it on the console, together with the possible answers (each question should have a number) (Hint: write a method for the Question objects for this task).

5. Use the 'prompt' function to ask the user for the correct answer. The user should input the number of the correct answer such as you displayed it on Task 4.

6. Check if the answer is correct and print to the console whether the answer is correct ot nor (Hint: write another method for this).

7. Suppose this code would be a plugin for other programmers to use in their code. So make sure that all your code is private and doesn't interfere with the other programmers code (Hint: we learned a special technique to do exactly that).
*/


// (function() {
//     function Question(question, answers, correct) {
//         this.question = question;
//         this.answers = answers;
//         this.correct = correct;
//     }
    
//     Question.prototype.displayQuestion = 
//     function() {
//         console.log(this.question);
    
//         for(var i = 0; i < this.answers.length; i++) {
//             console.log(i + ': ' + this.answers[i]);
//         }
//     }
    
//     Question.prototype.checkAnswer = 
//     function(ans) {
//         if (ans === this.correct){
//             score++;
//             console.log('Correct answer! Current score: ' + score);
//         }
//         else if(answer === 'exit')
//         {
//             playQuiz = false;
//         }
//         else {
//             console.log('Wrong answer :( Current score: ' + score);
//         }
//     }
    
//     var q1 = new Question('What\'s the capital of Iceland?',
//     ['Stockholm','Copenhagen','Reykjavik'],2);
//     var q2 = new Question('Which of the following is associated with Elon Musk?',
//     ['SAS','SpaceX','Mitsubishi'],1);
//     var q3 = new Question('When is my birthday?',
//     ['27/7','28/8','29/9'],0);
    
//     var questions = [q1, q2, q3];
                        
                        
//     var n = Math.floor(Math.random() * questions.length);
    
//     questions[n].displayQuestion();
    
//     var score = 0;
    
//     var answer = parseInt(prompt('Type the correct answer (number) to the question!'));
    
//     questions[n].checkAnswer(answer);
// })();
/*
--- Expert level ---

8. After you display the result, display the next random question, so that the game never ends (Hint: write a function for this and call it right after displaying the result)

9. Be careful: after Task 8, the game literally never ends. So include the option to quit the game if the user writes 'exit' instead of the answer. In this case, DON'T call the function from task 8.

10. Track the user's score to make the game more fun! So each time an answer is correct, add 1 point to the score (Hint: I'm going to use the power of closures for this, but you don't have to, just do this with the tools you feel more comfortable at this point).

11. Display the score in the console. Use yet another method for this.
*/

(function() {
    function Question(question, answers, correct) {
        this.question = question;
        this.answers = answers;
        this.correct = correct;
    }
    
    Question.prototype.displayQuestion = 
    function() {
        console.log(this.question);
    
        for(var i = 0; i < this.answers.length; i++) {
            console.log(i + ': ' + this.answers[i]);
        }
    }
    
    Question.prototype.checkAnswer = 
    function(ans, callback) {
        var sc;

        if (ans === this.correct){
            console.log('Correct answer! Current score: ' + score);
            sc = callback(true);
        }
        else {
            console.log('Wrong answer :( Current score: ' + score);
            sc = callback(false);
        }

        this.displayScore(sc);
    }
    
    Question.prototype.displayScore = function(score) {
        console.log('Your current score is: ' + score);
        console.log('---------------------------')
    }

    var q1 = new Question('What\'s the capital of Iceland?',
    ['Stockholm','Copenhagen','Reykjavik'],2);
    var q2 = new Question('Which of the following is associated with Elon Musk?',
    ['SAS','SpaceX','Mitsubishi'],1);
    var q3 = new Question('When is my birthday?',
    ['27/7','28/8','29/9'],0);
    
    var questions = [q1, q2, q3];
    
    function score() {
        var sc = 0;
        return function(correct) {
            if (correct) {
                sc++;
            }
            return sc;
        }
    }

    var keepScore = score();

    function nextQuestion(){
                            
        var n = Math.floor(Math.random() * questions.length);
        
        questions[n].displayQuestion();
        
        var answer = prompt('Type the correct answer (number) to the question!');
        
        if(answer !== 'exit'){
            questions[n].checkAnswer(parseInt(answer), keepScore);
            nextQuestion();
        }
    }

    nextQuestion();

})();



    
