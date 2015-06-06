// Problem 1. Numbers
console.log('===== Problem 1. Numbers =====');

var num = 10;
for(var i=1; i<=num; i+=1) {
	console.log(i);
}

console.log('===== Problem 2. Numbers not divisible =====');
// Problem 2. Numbers not divisible

var n = 21;
for(var i=1; i<=n; i+=1) {
	if (!(i % 3 === 0 && i % 7 === 0)) {
		console.log(i);
	}
}

console.log('===== Problem 3. Min/Max of sequence =====');
// Problem 3. Min/Max of sequence

var min = Math.min(9, 82, 24, 66, 0, 36, 7, 50);
var max = Math.max(9, 82, 24, 66, 0, 36, 7, 50);

console.log('min: '+min);
console.log('max: '+max);

console.log('===== Problem 4. Lexicographically smallest =====');
// Problem 4. Lexicographically smallest

