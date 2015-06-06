// Problem 1. Planar coordinates
console.log('===== Problem 1. Planar coordinates =====');

function point(x, y) {
	return {
	'x': x,
	'y': y
	};
}

function distance(point1, point2) {
		var result = Math.sqrt( (point2.x - point1.x)*(point2.x - point1.x) +
						  (point2.y - point1.y)*(point2.y - point1.y) );
		return result.toFixed(2);
	}

function canTriangle() {
	if ( (line1 + line2 > line3) &&
	   	 (line1 + line3 > line2) &&
	   	 (line2 + line3 > line1) ) {
	return true;
	} else {
	return false;
	}
}

var p1 = point(3, 4);
var p2 = point(5, 2);
var p3 = point(5, 9);
var p4 = point(1, 3);
var p5 = point(6, 8);
var p6 = point(4, 2);

var line1 = distance(p1, p2); // 2.83
var line2 = distance(p3, p4); // 7.21
var line3 = distance(p5, p6); // 6.32

// var arr = [line1, line2, line3];
// console.log(arr);

console.log(p1, p2);
console.log(distance(p1, p2));
console.log(canTriangle());	// Returns false when it should be true. Go figure!

// Problem 2. Remove elements
console.log('===== Problem 2. Remove elements =====');

var arr = [1,2,1,4,1,3,4,1,111,3,2,1,'1'];

Array.prototype.remove = function(digit) {
	var length = arr.length;
	for (var i = 0; i < length; i+=1) {
		if (arr[i] === digit) {
		arr.splice(i, 1);
		}
	}
}

console.log(arr);
arr.remove(1);
console.log(arr);

// Problem 3. Deep copy
console.log('===== Problem 3. Deep copy =====');

var person1 = {
	name: 'Pesho',
	age: 24,
	greet: 'Hi! I\'m Pesho!'
};

 function deepCopy(object){
        return JSON.parse(JSON.stringify(object));
    }

console.log(person1);

var person2 = deepCopy(person1);
person2.name = 'Ivan';

console.log(person2);
console.log(person1);
	
// Problem 4. Has property
console.log('===== Problem 4. Has property =====');

function hasProperty(obj, prop) {
	if (prop in obj) {
		return console.log(obj +' has a property '+ prop);
	} else {
		return console.log(obj +' does NOT have a property '+ prop);
	}
}

console.log(person1.greet);
hasProperty(person1, 'greet');	// The property has to be written like a string!

// Problem 5. Youngest person
console.log('===== Problem 5. Youngest person =====');

var people = [
  { firstname : 'Gosho', lastname: 'Petrov', age: 32 }, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},
  { firstname : 'Pesho', lastname: 'Petkov', age: 23 },
  { firstname : 'Ivan', lastname: 'Ganchev', age: 44 },
  { firstname : 'Dragan', lastname: 'Draganov', age: 56 }
  ];

  function youngestPerson(array) {
  	var length = array.length;
  	var youngest = array[0].age;
  	for (var i = 1; i < length; i+=1) {
  		if (youngest > array[i].age) {
  			youngest = array[i].age;
  		}
  	}
  		return youngest;
  }

  console.log(youngestPerson(people));

// Problem 6. Group people by age, first or last name
console.log('===== Problem 6. Group people by age, first or last name =====');

function groupByAge(array, prop) {
  	return array.sort(function(a, b){
  		return a.age-b.age;
  	});
}

function groupByFirstName(array, prop) {
  	return array.sort(function(a, b) {
    if(a.firstname < b.firstname) return -1;
    if(a.firstname > b.firstname) return 1;
    return 0;
	})
}

function groupByLastName(array, prop) {
  	return array.sort(function(a, b) {
    if(a.lastname < b.lastname) return -1;
    if(a.lastname > b.lastname) return 1;
    return 0;
	})
}

console.log('--- Grouped by Age:');
console.log(groupByAge(people, 'age'));
console.log('--- Grouped by First Name:');
console.log(groupByFirstName(people, 'firstname'));
console.log('--- Grouped by Last Name:');
console.log(groupByLastName(people, 'lastname'));