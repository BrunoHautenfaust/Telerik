// Task 1 - Odd or Even:
console.log('====== Task 1 - Odd or Even ======');

function isOdd(num) {
	if (num % 2 === 0) {
		return 'even';
	}
	else {
		return 'odd';
	}
}

for (var i = -2; i < 3; i+=1) {
	console.log(i +' : '+ isOdd(i));
}
console.log('====== Task 2 - Divisible by 7 and 5 ======');

// Task 2 - Divisible by 7 and 5:

function divisible(num) {
	return (num % 3 === 0 && num % 5 === 0)
	 ? num+' is divisible by 3 and 5.'
	 : num+' is NOT divisible by 3 and 5.';
}

	console.log(divisible(3));
	console.log(divisible(0));
	console.log(divisible(5));
	console.log(divisible(7));
	console.log(divisible(35));
	console.log(divisible(140));
console.log('====== Task 3 - Rectangle area ======');

// Task 3 - Rectangle area:


function area(width, height) {
	
	return width * height;
}

console.log('Area = '+ area(3, 4) );
console.log('Area = '+ area(2.5, 3) );
console.log('Area = '+ area(5, 5) );
console.log('====== Task 4 - Third digit ======');

// Task 4 - Third digit:

function digit(num) {
	return (Math.floor((num / 100) % 10) === 7) ? true : false;
}

console.log(digit(5));
console.log(digit(701));
console.log(digit(1732));
console.log(digit(9703));
console.log(digit(877));
console.log(digit(777877));
console.log(digit(9999799));
console.log('====== Task 5 - Third bit ======');

// Task 5 - Third bit: 

function checkThirdBit(num) {
    return (num >> 3) & 1;
}

console.log(checkThirdBit(5));
console.log(checkThirdBit(8));
console.log(checkThirdBit(0));
console.log(checkThirdBit(15));
console.log(checkThirdBit(5343));
console.log(checkThirdBit(62241));
console.log('====== Task 6 - Point in Circle ======');

// Task 6 - Point in Circle:
// 	!!!! ^(Symbol for Power) doesn't work correctly everytime !!!!

	var radius = 5;
	var center = 0;

function inCircle(x, y) {

if ( (x - center)^2 + (y - center)^2 <= radius^2) {
	return true;
}
else {
	return false;
 }
}

console.log( inCircle(0, 1) );
console.log( inCircle(-5, 0) );
console.log( inCircle(-4, 5) );
console.log( inCircle(1.5, -3) );
console.log( inCircle(-4, -3.5) );
console.log( inCircle(100, -30) );
console.log( inCircle(0, 0) );
console.log( inCircle(0.2, -0.8) );
console.log( inCircle(0.9, -4.93) );
console.log( inCircle(2, 2.655) );
console.log('====== Task 7 - Is prime ======');

// Task 7 - Is prime:

function isPrime(num) {
    if(num < 2) {
     return false;
     }
    for (var i = 2; i < num; i++) {
        if(num % i === 0) {
            return false;
        }
    }
    return true;
}


for(var i = 0; i < 100; i++){
    if(isPrime(i)) {
    	console.log(i);
    }
}
// Task 8 - Trapezoid area:
console.log('====== Task 8 - Trapezoid area ======');

function area(a, b, h) {
	return ((a+b)/2)*h;
}

console.log( area(5, 7, 12) );
console.log( area(2, 1, 33) );
console.log( area(8.5, 4.3, 2.7) );
console.log( area(100, 200, 300) );
console.log( area(0.222, 0.333, 0.555).toFixed(7) );

// Task 9 - Point in Circle and outside Rectangle:
console.log('====== Task 9 - Point in Circle and outside Rectangle ======');

	var radius = 3;
	var center = 1;

function inCircOutRect(x, y) {

var inCircle = ((x - center)*(x - center) + (y - center)*(y - center) <= radius*radius);
var outRectangle = !((x >= -1 && x <= 5) && (y <= 1 && y >= -1));

if ( inCircle && outRectangle ) {
	return 'yes';
}
else {
	return 'no';
 }
}

console.log('1, 2 :'+ inCircOutRect(1, 2) );
console.log('2.5, 2 :'+ inCircOutRect(2.5, 2) );
console.log( '0, 1 :' +inCircOutRect(0, 1) );
console.log('2.5, 1 :' +inCircOutRect(2.5, 1) );
console.log( '2, 0 :' +inCircOutRect(2, 0) );
console.log( '4, 0 :' +inCircOutRect(4, 0) );
console.log( '2.5, 1.5 :' +inCircOutRect(2.5, 1.5) );
console.log( '2, 1.5 :' +inCircOutRect(2, 1.5) );
console.log( '1, 2.5 :' +inCircOutRect(1, 2.5) );
console.log( '-100, -100 :' +inCircOutRect(-100, -100) );