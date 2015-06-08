// Problem 1. Make person
console.log('===== Problem 1. Make person =====');

function createPerson(fname, lname, ag, gen) {
	return {
	firstname: fname,
	lastname: lname,
	age: ag,
	gender: gen
	}
}

function createPeople() {
    var i,
    firstNames = ['Asen', 'Angel', 'Boris', 'Georgi', 'Marin', 'Ana', 'Eli', 'Elena', 'Gergana', 'Mariika'],
    lastNames = ['Ivanov', 'Dimitrov', 'Petrov', 'Georgiev', 'Nikolov', 'Borisova', 'Gigova', 'Atanasova', 'Ivanova', 'Georgieva'],
    age = [10, 34, 56, 18, 20, 33, 45, 86, 15, 27],
    arr = [];

    for (i = 0; i < 10; i += 1) {
        arr[i] = createPerson(firstNames[i], lastNames[i], age[i], (i > 4));
    }
    return arr;
}

var people = createPeople();
console.log(people);

// Problem 2. People of age
console.log('===== Problem 2. People of age =====');

function age18orGreater(element, index, array) {
	return element.age >= 18;
}

console.log( people.every(age18orGreater) );

// Problem 3. Underage people
console.log('===== Problem 3. Underage people =====');

function underaged(element, index, array) {
	return element.age < 18;
}

function iterate(element, index, array) {
	console.log(element);
}

var underagedPeople = people.filter(underaged);
underagedPeople.forEach(iterate);

// Problem 4. Average age of females   ????
console.log('===== Problem 4. Average age of females =====');

function filterFemales(element, index, array) {
	return element.gender === true;
}

function sumAge(pv, cv) {	// pv = previous value, cv = current value
	var summedAge = pv + cv.age;
	return summedAge;
}

var filteredFemales = people.filter(filterFemales);
// console.log( filteredFemales );

var summedAge = filteredFemales.reduce(sumAge, 0);
var average = summedAge / filteredFemales.length;
console.log('Average age of females is '+average);

// Problem 5. Youngest male person 		XXXX
console.log('===== Problem 5. Youngest male person =====');

function filterMales(element, index, array) {
	return element.gender === false;
}

function sortMalePerson(a, b) {
	  var aaa = a.age - b.age;
	  return aaa;
}

function findYoungestMale(element) {
	return element;
}


var filteredMales = people.filter(filterMales);
// console.log(filteredMales);

var sortedMales = filteredMales.sort(sortMalePerson);
/*
var youngestMale = sortedMales.find(findYoungestMale); // XXX

console.log(youngestMale);   // XX
*/

// Problem 6. Group people
console.log('===== Problem 6. Group people =====');

function compareFirstName(a, b) {
	if (a.firstnme < b.firstname) {
		return -1;
	}
	if (a.firstname > b.firstname) {
		return 1;
	}
	return 0;
}

var sortedByFirstName = people.sort(compareFirstName);

console.log(sortedByFirstName);