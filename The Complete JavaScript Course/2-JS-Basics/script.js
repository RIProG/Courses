/*var firstName = 'Rikard';
var age = 32;

console.log(firstName + ' ' + age);

var job, isMarried;
console.log(job, isMarried)

job = 'Teacher';
isMarried = false;
console.log(job, isMarried)

console.log(firstName + ' is a ' + age + ' year old ' + job + 
            '. Is he married? ' + isMarried);

age = 'thirty two';
console.log(age);
job = 'Driver';
alert(job);

var lastName = prompt('What is his last name?');
console.log(firstName + ' ' + lastName)

var year, yearRikard, yearMartin;
now = 2019;
ageRikard = 33;
ageMartin = 34;

yearRikard = now - ageRikard;
yearMartin = now - ageMartin;

console.log(yearRikard + ' ' + yearMartin);

console.log(now + 2);
console.log(now * 2);
console.log(now / 2);


var rikardOlder = ageRikard > ageMartin;
console.log(rikardOlder);


console.log(typeof rikardOlder);
console.log(typeof ageRikard);
console.log(typeof 'Kalaskul');
var x;
console.log(typeof x); 

var now = 2019;
var yearRikard = 1986;
var fullAge = 18;

var isFullAge = now - yearRikard >= fullAge;
console.log(isFullAge);

var ageRikard = now - yearRikard;
var ageMartin = 34;
var average = (ageMartin + ageRikard) / 2;
console.log(average);

var x, y;
x = y = (3 +5) * 4 -6; // 8 * 4 - 6 // 32 - 6 (Funkar pga = jobbar från höger till vänster)
console.log(x, y);

x *= 2;
console.log(x);
x += 10;
console.log(x);
x++;
console.log(x); 

//Coding Challenge 1- BMI
var massMark, massJohn, heightMark, heightJohn, bmiMark, bmiJohn;
massMark = 70;
heightMark = 1,75;
massJohn = 85;
heightJohn = 1,99;
bmiMark = massMark / (heightMark*heightMark);
bmiJohn = massJohn / (heightJohn*heightJohn);
var markHigherBMI = bmiMark > bmiJohn;
console.log(bmiMark, bmiJohn);
console.log("Is Mark's BMI higher than John's? " + markHigherBMI);


var firstName = 'John';
var civilStatus = 'single';

if (civilStatus === 'married') {
    console.log(firstName + ' is married!');
} 
else {
    console.log(firstName + ' is not married!')
}

var isMarried = true;
if (isMarried) {
    console.log(firstName + ' is married!');
}
else {
    console.log(firstName + ' is not married!')
}

var massMark, massJohn, heightMark, heightJohn, bmiMark, bmiJohn;
massMark = 70;
heightMark = 1,75;
massJohn = 85;
heightJohn = 1,99;
bmiMark = massMark / (heightMark*heightMark);
bmiJohn = massJohn / (heightJohn*heightJohn);
if (bmiMark > bmiJohn) {
    console.log('Mark\'s BMI is higher than John\'s.')
}
else {
    console.log('John\'s BMI is higher than Mark\'s.')
}


var firstName = 'John';
var age = 16;

if (age < 13) {
    console.log(firstName + ' is a boy.');
}
else if (age >= 13 && age <= 19){
    console.log(firstName + ' is a teenager.');
}
else if (age >= 20 && age <= 29){
        console.log(firstName + ' is a young man.');
}
else {
    console.log(firstName + ' is a man.');
}


var firstName = 'John';
var age = 22;

var drink = age >= 18 ? 'beer' : 'juice';
console.log(firstName + ' drinks ' + drink) 


var job = 'instructor';
switch (job){
    case 'teacher':
    case 'instructor':
        console.log(firstName + ' teaches kids how to code.');
        break;
    case 'driver':
        console.log(firstName + ' drives an uber in Lisbon.');
        break;
    case 'designer':
        console.log(firstName + ' designs beautiful websites.');
        break;
    default: 
        console.log(firstName + ' does something else.');
}

switch (true) {
    case age < 13:
        console.log(firstName + ' is a boy.');
        break;
    case age >= 13 && age <= 19:
        console.log(firstName + ' is a teenager.');
        break;
    case age >= 20 && age <= 29:
        console.log(firstName + ' is a young man.');
        break;
    default:
        console.log(firstName + ' is a man.');
}


// falsy values: undefined, null, 0, '', NaN
// truthy values: all values that are not falsy

var height;

height = 199;

if (height || height === 0) {
    console.log('Variable is defined');
}
else {
    console.log('Variable has NOT been defined.')
}


var johnScore = 89 + 120 + 103;
var markScore = 116 + 94 + 123;
var maryScore = 97 + 134 + 105;
var johnAverage = johnScore / 3;
var markAverage = markScore / 3;
var maryAverage = maryScore / 3;
console.log(johnAverage, markAverage, maryAverage);
if (johnAverage > markAverage && johnAverage > maryAverage) {
    console.log('John wins with an average score of ' + johnAverage + ' points!');
}
else if (markAverage > johnAverage && markAverage > maryAverage){
    console.log('Mark wins with an average score of ' + markAverage + ' points!');
}
else if (maryAverage > johnAverage && maryAverage > markAverage) {
    console.log('Mary wins with an average score of ' + maryAverage + ' points!');
}
else {
    console.log('There is a draw!')
}


function calculateAge(birthYear) {
    return 2019-birthYear;
}

var ageJohn = calculateAge(1990);
var ageMike = calculateAge(1948);
var ageJane = calculateAge(1969);
console.log(ageJohn, ageMike, ageJane);


function yearsUntilRetirement(year, firstName) {
    var age = calculateAge(year);
    var retirement = 65 - age;

    if (retirement > 0) {
        console.log(firstName + ' retires in ' + retirement + ' years!');
    }
    else {
        console.log(firstName + ' is already retired!')
    }
}

yearsUntilRetirement(1990, 'John');
yearsUntilRetirement(1948, 'Mike');
yearsUntilRetirement(1969, 'Jane');


// Function declaration
//function whatDoYouDo(job,firstName){}

// Function expression
var whatDoYouDo = function (job, firstName) {
    switch(job){
        case 'teacher':
            return firstName + ' teaches kids how to code.';
        case 'driver':
            return firstName + ' drives an uber in Lisbon.'
        case 'designer':
            return firstName + ' designs beautiful websites.'
        default: 
            return firstName + ' does something else.'
    }
}

console.log(whatDoYouDo('teacher', 'John'));
console.log(whatDoYouDo('driver', 'Jane'));
console.log(whatDoYouDo('designer', 'Mike'));
console.log(whatDoYouDo('retired', 'Leffe'));


var names = ['John', 'Mark', 'Jane'];
var years = new Array(1990, 1969, 1948);

console.log(names[0]);
console.log(years[2]);
console.log(names.length);

names[1] = 'Ben';
names[5] = 'Mary';
names[names.length] = 'Kyle';
console.log(names);


var john = ['John', 'Smith', 1990, 'designer', false];

john.push('blue');
console.log(john);
john.pop();
john.pop();
console.log(john);
john.unshift('Mr.');
console.log(john);
john.shift();
console.log(john);
console.log(john.indexOf(1990));
console.log(john.indexOf(199));

var isDesigner = john.indexOf('designer') === -1 ? 
'John is NOT a designer' : 'John IS a designer';
console.log(isDesigner);

// Challenge 3

function tipCalculator(bill) {
    var percentage;
    if (bill < 50) {
        percentage = 0.2;
    }
    else if (bill >= 50 && bill <= 200) {
        percentage = 0.15;
    }
    else {
        percentage = 0.1;
    }
    return percentage * bill;
}

var bills = [124, 48, 268];
var tips = [tipCalculator(bills[0]), tipCalculator(bills[1]),
     tipCalculator(bills[2])];
var paidAmounts = [bills[0]+tips[0], bills[1]+tips[1], bills[2]+tips[2]];

console.log(bills);
console.log(tips);
console.log(paidAmounts);


// Object literal
var john = {
    firstName: 'John',
    lastName: 'Smith',
    birthYear: 1990,
    family: ['Jane', 'Mark', 'Bob', 'Emily'],
    job: 'teacher', 
    isMarried: false
};

console.log(john);
console.log(john.firstName);
var x = 'birthYear';
console.log(john[x]);
console.log(john['lastName']);

john.job = 'driver';
console.log(john.job);
john['isMarried'] = true;
console.log(john);

// new Object syntax
var jane = new Object();
jane.firstname = 'Jane';
jane.birthYear = 1969;
jane['lastName'] = 'Smith';
console.log(jane);


// Objects and methods

var john = {
    firstName: 'John',
    lastName: 'Smith',
    birthYear: 1992,
    family: ['Jane', 'Mark', 'Bob', 'Emily'],
    job: 'teacher', 
    isMarried: false,
    calculateAge: function() {
        this.age = 2019 - this.birthYear;
    }
};

john.calculateAge();
console.log(john);


// Coding Challenge 4

var john = {
    name: 'John Smith',
    mass: 85,
    height: 1.99,
    calculateBMI: function() {
        this.bmi = this.mass / (this.height*this.height);
        return this.bmi;
    }
}

var mark = {
    name: 'Mark Polo',
    mass: 70,
    height: 1.70,
    calculateBMI: function() {
        this.bmi = this.mass / (this.height*this.height);
        return this.bmi;
    }
}

if (john.calculateBMI() > mark.calculateBMI()) {
    console.log(john.name + ' has the highest bmi with a value of ' 
    + john.bmi);
}
else if (mark.calculateBMI() > john.calculateBMI()) {
    console.log(mark.name + ' has the highest bmi with a value of ' 
    + mark.bmi);
}
else {
    console.log('It\'s a draw!');
}

// Loops

for(i = 1; i <= 20; i+= 2) {
    console.log(i);
}

var john = ['John', 'Smith', 1990, 'designer', false, 'blue'];

for (i = 0; i < john.length; i++) {
    console.log(john[i]);
}

var i = 0;
while (i < john.length) {
    console.log(john[i]);
    i++;
}


// Continue and break statements

var john = ['John', 'Smith', 1990, 'designer', false, 'blue'];

for (i = 0; i < john.length; i++) {
    if (typeof john[i] !== 'string') continue;
        console.log(john[i]);
}

for (i = 0; i < john.length; i++) {
    if (typeof john[i] !== 'string') break;
        console.log(john[i]);
}

for (i = john.length-1; i >= 0; i--) {
    if (typeof john[i] !== 'string') continue;
        console.log(john[i]);
}


// Challenge 5

var john = {
    fullName: 'John Smith',
    bills: [124, 48, 268, 180, 42],
    calculateTips: function() {
        this.tips = [];
        this.payments = [];

        for (i = 0; i < this.bills.length; i++) {
            var percentage;
            var bill = this.bills[i];

            if (bill < 50) {
                percentage = 0.2;
            }
            else if (bill >= 50 && bill <= 200) {
                percentage = 0.15;
            }
            else {
                percentage = 0.1;
            }
            this.tips[i] = bill * percentage;
            this.payments[i] =  bill + this.tips[i]; 
        }
    }
}

john.calculateTips();
console.log(john);

var mark = {
    fullName: 'Mark Polo',
    bills: [77, 375, 110, 45],
    calculateTips: function() {
        this.tips = [];
        this.payments = [];

        for (i = 0; i < this.bills.length; i++) {
            var percentage;
            var bill = this.bills[i];

            if (bill < 100) {
                percentage = 0.2;
            }
            else if (bill >= 100 && bill <= 300) {
                percentage = 0.10;
            }
            else {
                percentage = 0.25;
            }
            this.tips[i] = bill * percentage;
            this.payments[i] =  bill + this.tips[i]; 
        }
    }
}

mark.calculateTips();
console.log(mark);

function calculateAverageTip(tips) {
    var sum = 0;
    for (i = 0; i < tips.length; i++) {
        sum += tips[i];
    }
    return sum/tips.length;
}

john.average = calculateAverageTip(john.tips);
mark.average = calculateAverageTip(mark.tips);
console.log(john,mark);

if (john.average > mark.average) {
    console.log(john.fullName + 
        '\'s family pays higher tips, with an average of $' 
        + john.average);
}
else if (mark.average > john.average) {
    console.log(mark.fullName + 
        '\'s family pays higher tips, with an average of $' 
        + mark.average);
}
else {
    console.log('The families has the same average of tips.');
}
*/