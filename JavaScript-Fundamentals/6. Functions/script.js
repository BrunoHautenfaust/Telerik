// Problem 1. English digit
console.log('===== Problem 1. English digit =====');

function lastDigit(number) {
	number %= 10;

	switch (number) {
		case 0: console.log('zero'); break;
		case 1: console.log('one'); break;
		case 2: console.log('two'); break;
		case 3: console.log('three'); break;
		case 4: console.log('four'); break;
		case 5: console.log('five'); break;
		case 6: console.log('six'); break;
		case 7: console.log('seven'); break;
		case 8: console.log('eight'); break;
		case 9: console.log('nine'); break;
		default: console.log('Unknown'); break;
	}
}

lastDigit(512);
lastDigit(1024);
lastDigit(12309);

// Problem 2. Reverse number
console.log('===== Problem 2. Reverse number =====');

function reverse(number) {
	var number = number.toString();
	var final = number.split('').reverse().join('');
	return final;
}

console.log(reverse(256));
console.log(reverse(123.45));

// Problem 3. Occurrences of word
console.log('===== Problem 3. Occurrences of word =====');

var text1 = 'I bought a pizza! It\'s a big pizza. The pizza guy delivered it on time.';
var text2 = 'I bought a PIZZA! It\'s a big pizza. The Pizza guy delivered it on time.';

// 1 - Case sensitive
function occurrences(someText, target) {
	var arr = someText.replace(/!|'|\./g,' ').split(' ');
	var found = [];
	for (word in arr) {
		if (target === arr[word]) {
			found.push(arr[word]);
		}
	}
	return found;
}

// 2 - Case insensitive		

function occurrencesRegEx(someText, target) {
	var regex = new RegExp(target, 'ig');		
	var found = someText.match(regex);
	return found;
}

console.log('Case sensitive -> '+occurrences(text1, 'pizza'));
console.log('Case insensitive -> '+occurrencesRegEx(text2, 'pizza'));

// Problem 4. Number of elements          
console.log('===== Problem 4. Number of elements =====');

function numberOfElements() {
	var count = document.getElementsByTagName('div').length;
	return count;
}
// Paste this line in browser console to test:    <<<<<<<<<
// console.log(numberOfElements());   

// Problem 5. Appearance count
console.log('===== Problem 5. Appearance count =====');

var arr = [1, 4, 5, 6, 3, 4, 3, 6, 7, 8, 3];
var num = 3;

function appearanceCount(number) {
	var length = arr.length;
	var count = 0;
	for (var i = 0; i < length; i+=1) {
		if (arr[i] === number) {
			count++;
		}
	}
	return count;
}

console.log('The number('+num+') in the array appears '+appearanceCount(num)+' time(s).');

// Problem 6. Larger than neighbours
console.log('===== Problem 6. Larger than neighbours =====');
	// 1, 4, 5, 6, 3, 4, 3, 6, 7, 8, 3

function largerThanNeighbours(position) {
var length = arr.length;
for (var i = 0; i < length; i+=1) {
		if ( position-1 >= 0 && position+1 <= length) {
			if (arr[position] > arr[position-1] && arr[position] > arr[position+1]) {
				console.log(true+': '+arr[position]+' is larger than '+arr[position-1]+' and '+arr[position+1]);
				break;
			} else {
				console.log(false+': '+arr[position]+' is NOT larger than '+arr[position-1]+' and '+arr[position+1]);
				break;
			}
		} else {
			console.log('No two neighbours exist.');
			break;
		}
	}
}

largerThanNeighbours(3);
largerThanNeighbours(2);
largerThanNeighbours(0);

	// Problem 7. First larger than neighbours
console.log('===== Problem 7. First larger than neighbours =====');
	// 1, 4, 5, 6, 3, 4, 3, 6, 7, 8, 3

function firstLargerThanNeighbours() {
var length = arr.length;
for (var i = 0; i < length; i+=1) {
		if ( i-1 >= 0 && i+1 <= length) {
			if (arr[i] > arr[i-1] && arr[i] > arr[i+1]) {
				console.log(true+': '+arr[i]+' is larger than '+arr[i-1]+' and '+arr[i+1]);
				break;
			}
		} else if (arr[i] === arr[length-1]) {
			console.log(-1);
		} 
 	}
}

firstLargerThanNeighbours();