// Problem 1. Exchange if greater
console.log('===== Problem 1. Exchange if greater =====');

function Greater(num1, num2) {
	if (num1 > num2) {
		return num2+' '+num1;
	} else {
		return num1+' '+num2;
	}
}

console.log( Greater(5, 2));
console.log( Greater(3, 4));
console.log( Greater(5.5, 4.5));
console.log('===== Problem 2. Multiplication Sign =====');

// Problem 2. Multiplication Sign

function MultiSign (num1, num2, num3) {
	var allPositive = (num1 > 0 && num2 > 0 && num3 > 0) ||
					  (num1 > 0 && num2 > 0 && num3 > 0) ||
					  (num1 > 0 && num2 > 0 && num3 > 0);

	var twoNegative = (num1 > 0 && num2 < 0 && num3 < 0) || 
					  (num1 < 0 && num2 > 0 && num3 < 0) || 
					  (num1 < 0 && num2 < 0 && num3 > 0);		

	var zero = num1 === 0 || num2 === 0 || num3 === 0;

	if (allPositive || twoNegative) {
		console.log('+');
	} else if ( zero ) {
		console.log('0');
	} else {
		console.log('-');
	}
}

MultiSign(5, 2, 2);
MultiSign(-2, -2, 1);
MultiSign(-2, 4, 3);
MultiSign(0, -2.5, 4);
MultiSign(-1, -0.5, -5.1);
console.log('===== Problem 3. The biggest of Three =====');

// Problem 3. The biggest of Three

function biggestOfThree (a, b, c) {
	if (a > b) {
		if (a > c) {
			return a;
		} else {
			return c;
		}
	}
	if (c > b) {
		return c;
	} else {
		return b;
	}
}

console.log( biggestOfThree(5, 2, 2) );
console.log( biggestOfThree(-2, -2, 1) );
console.log( biggestOfThree(-2, 4, 3) );
console.log( biggestOfThree(0, -2.5, 5) );
console.log( biggestOfThree(-0.1, -0.5, -1.1) );
console.log('===== Problem 4. Sort 3 numbers =====');

// Problem 4. Sort 3 numbers

function Sorted (a, b, c) {
var result;

	if (a >= b) {
		// a:
		if (a >= c) {
			result = a;
			if (b >= c) {
				result +=' '+b+' '+c;
			} else {
				result +=' '+c+' '+b;
			}
		}
	}
	// b:
	if ( b >= a) {
		if ( b >= c ) {
			result = b;
			if ( a >= c) {
				result +=' '+a+' '+c;
			} else {
				result +=' '+c+' '+a;
			}
		}
	}
	// c:
	if ( c >= a) {
		if (c >= b) {
			result = c;
			if (a >= b) {
				result +=' '+a+' '+b;
			} else {
				result +=' '+b+' '+a;
			}
		}
	}
	return result;
}

console.log( Sorted(5, 2, 1) );
console.log( Sorted(-2, -2, 1) );
console.log( Sorted(-2, 4, 3) );
console.log( Sorted(0, -2.5, 5) );
console.log( Sorted(-1.1, -0.5, -0.1) );
console.log( Sorted(10, 20, 30) );
console.log( Sorted(1, 1, 1) );
console.log('===== Problem 5. Digit as word =====');

// Problem 5. Digit as word

var number = 2;

switch (number) {
	case 0: number='zero'; break;
	case 1: number='one'; break;
	case 2: number='two'; break;
	case 3: number='three'; break;
	case 4: number='four'; break;
	case 5: number='five'; break;
	case 6: number='six'; break;
	case 7: number='seven'; break;
	case 8: number='eight'; break;
	case 9: number='nine'; break;
	default: number='not a digit'; break;
}

console.log(number);
console.log('===== Problem 6. Quadratic equation =====');

// Problem 6. Quadratic equation
 
 function Quadratic(a, b, c) {
    var d = b * b - 4 * a * c;
    var x, x1, x2;

    	if (d > 0) {
            x1 = (-b + Math.sqrt(d)) / (2 * a);
            x2 = (-b - Math.sqrt(d)) / (2 * a);
            console.log('x1='+ x1 +'; x2=' +x2);
        } else if (d === 0) {
            x = (-b + Math.sqrt(d)) / (2 * a);
            console.log('x1=x2='+ x);
        } else {
            console.log('no real roots');
            }
        }

Quadratic(2, 5, -3);
Quadratic(-1, 3, 0);
Quadratic(-0.5, 4, -8);
Quadratic(5, 2, 8);
console.log('===== Problem 7. The biggest of five numbers =====');

// Problem 7. The biggest of five numbers

function Biggest(a, b, c, d, e) {
	var biggestA = a >= b && a >= c && a >= d && a >= e;
	var biggestB = b >= a && b >= c && b >= d && b >= e;
	var biggestC = c >= a && c >= b && c >= d && c >= e;
	var biggestD = d >= a && d >= b && d >= c && d >= e;
	var biggestE = e >= a && e >= b && e >= c && e >= d;

	if (biggestA){
		return a;
	} if (biggestB) {
		return b;
	} if (biggestC) {
		return c;
	} if (biggestD) {
		return d;
	} if (biggestE) {
		return e;
	}
}

console.log( Biggest(5, 2, 2, 4, 1) );
console.log( Biggest(-2, -22, 1, 0, 0) );
console.log( Biggest(-2, 4, 3, 2, 0) );
console.log( Biggest(0, -2.5, 0, 5, 5) );
console.log( Biggest(-3, -0.5, -1.1, -2, -0.1) );
console.log('===== Problem 8. Number as words =====');

// Problem 8. Number as words  		XXXXX

var n = 55;
var units, tens, teens, hundreds;

if (n >=0 || n<=9) {
	units = n;

    // UNITS
        switch(units)
        {
            case 0:
                console.log('zero');
                break;
            case 1:
                console.log('one');
                break;
            case 2:
                console.log('two');
                break;
            case 3:
                console.log('three');
                break;
            case 4:
                console.log('four');
                break;
            case 5:
                console.log('five');
                break;
            case 6:
                console.log('six');
                break;
            case 7:
                console.log('seven');
                break;
            case 8:
                console.log('eight');
                break;
            case 9:
                console.log('nine');
                break;
        }
}

if (n >=11 || n<=19) {
	teens = n;

    // TEENS
            switch (teens)
            {
                case 11:
                    console.log('eleven');
                    break;
                case 12:
                    console.log('twelve');
                    break;
                case 13:
                    console.log('thirteen');
                    break;
                case 14:
                    console.log('fourteen');
                    break;
                case 15:
                    console.log('fifteen');
                    break;
                case 16:
                    console.log('sixteen');
                    break;
                case 17:
                    console.log('seventeen');
                    break;
                case 18:
                    console.log('eighteen');
                    break;
                case 19:
                    console.log('nineteen');
                    break;
            }
}

if (n >=10 || n<=90) {
	tens = (n / 10) * 10;
	units = (n / 10) % 10;

     // TENS
            switch (tens)
            {
                case 10:
                    console.log('ten');
                    break;
                case 20:
                    console.log('twenty ');
                    break;
                case 30:
                    console.log('thirty ');
                    break;
                case 40:
                    console.log('fourty ');
                    break;
                case 50:
                    console.log('fifty ');
                    break;
                case 60:
                    console.log('sixty ');
                    break;
                case 70:
                    console.log('seventy ');
                    break;
                case 80:
                    console.log('eighty ');
                    break;
                case 90:
                    console.log('ninety ');
                    break;
            }
}

if (n >=100 || n<=900) {
	hundreds = n;

    // HUNDREDS
            switch (hundreds)
            {
                case 100:
                    console.log('one hundred ');
                    break;
                case 200:
                    console.log('two hundred ');
                    break;
                case 300:
                    console.log('three hundred ');
                    break;
                case 400:
                    console.log('four hundred ');
                    break;
                case 500:
                    console.log('five hundred ');
                    break;
                case 600:
                    console.log('six hundred ');
                    break;
                case 700:
                    console.log('seven hundred ');
                    break;
                case 800:
                    console.log('eight hundred ');
                    break;
                case 900:
                    console.log('nine hundred ');
                    break;
            }
}

 
n;
