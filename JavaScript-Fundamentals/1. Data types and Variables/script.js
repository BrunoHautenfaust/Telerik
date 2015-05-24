// Task 1 - JavaScript literals:
var integer = 5;
var float = 2.5;
var string = 'Hello';
var bool = true;
var x = NaN;
var y = undefined;

console.log('***Task 1 - JavaScript literals***'+'\n');
console.log(integer+'\n'+float+'\n'+string+'\n'+
			bool+'\n'+x+'\n'+y);
console.log('======');

// Task 2 - Quoted text:
var someText = 'How you doin\'?\', Joey said';
console.log('***Task 2 - Quoted text***'+'\n');
console.log(someText);
console.log('======');

// Task 3 - Typeof variables:
console.log('***Task 3 - Typeof variables***'+'\n');
console.log( integer+' - '+typeof(integer)+'\n'+
			float+' - '+typeof(float)+'\n'+
			string+' - '+typeof(string)+'\n'+
			bool+' - '+typeof(bool)+'\n'+
			x+' - '+typeof(x)+'\n'+
			y+' - '+typeof(y) );
console.log('======');

// Task 4 - Typeof null:
var nullValue = null;
var someVar;

console.log('***Task 4 - Typeof null***'+'\n');
console.log( nullValue+' - '+typeof(nullValue)+'\n'+
			someVar+' - '+typeof(someVar) );