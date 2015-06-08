// Problem 1. Reverse string
console.log('===== Problem 1. Reverse string =====');

var string = 'sample';
var reversed = string.split('').reverse().join('');
console.log(reversed);

// Problem 2. Correct brackets
console.log('===== Problem 2. Correct brackets =====');

var correctExp = '((a+b)/5-d)';
var incorrectExp = ')(a+b))'; 

function correctBrackets(exp) {
	 var bracketCount = 0;
	 exp = exp.split('');
	 var len = exp.length;
            for (var i = 0; i < len; i+=1)
            {
                if (exp[i] === '(')
                {
                    bracketCount++;
                }
                else if (exp[i] === ')')
                {
                    bracketCount--;
                }
                if (bracketCount < 0)
                {
                    return false;
                }
            }
            return true;
}

console.log( correctBrackets(correctExp) );
console.log( correctBrackets(incorrectExp) );

// Problem 3. Sub-string in text
console.log('===== Problem 3. Sub-string in text =====');

var text1 = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';

function occurence(string, target) {
	var regex = new RegExp(target, 'ig');
	var found = string.match(regex);
	var length = found.length;
	return length;
}

console.log(occurence(text1, 'in'));

// Problem 4. Parse tags         XXXXXXXXXXXXXXXX

// Problem 5. nbsp
console.log('===== Problem 5. nbsp =====');

var text2 = 'Would you like fries with that?';
var replaced = text2.replace(/  +/g, '&nbsp;');
console.log(replaced);

// Problem 6. Extract text from HTML
console.log('===== Problem 6. Extract text from HTML =====');

var html = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>';

function stripTagsRegex(text) {
	return text.replace(/<[^>]*>/g, '');
}

var stripped = stripTagsRegex(html);				
console.log(stripped);						

// Problem 7. Parse URL
console.log('===== Problem 7. Parse URL =====');

var url = 'http://telerikacademy.com/Courses/Courses/Details/239';

// protocol:
    var protocolEnd = url.indexOf(':');
    var protocol = url.substring(0, protocolEnd);
// server:
	var serverEnd = url.indexOf('com');
    var server = url.substring(protocolEnd + 3, url.indexOf('/', 8));
// host:
	var hostStart = url.indexOf('/', 8);
	var host = url.substring(hostStart);

console.log('[protocol]: ' + protocol);
console.log('[server]: ' + server);
console.log('[host]: ' + host);

// Problem 8. Replace tags
console.log('===== Problem 8. Replace tags =====');

var html2 = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

var newTags = html2.replace(/<a href="/g, '[URL=')
				   .replace(/">/g, ']')
				   .replace(/<\/a>/g, '[/URL]');
console.log(newTags);

// Problem 9. Extract e-mails
console.log('===== Problem 9. Extract e-mails =====');

var texts = 'Banica poncho56@yahoo.com kogato sam gladen paticabonbon@abv.bg 4ever.'
var emails = texts.match(/[a-zA-Z0-9.-]+@[a-zA-Z0-9.-]+\.[a-zA-Z0-9.-]+/g);
console.log(emails);

// Problem 10. Find palindromes
console.log('===== Problem 10. Find palindromes =====');

var loremCrapsum = 'Lorem ABBA adipiscing elit. Nulla lamal malesuada. Donec exe mi sed, vulputate turpis.';
var palindromes = loremCrapsum.match(/ABBA|lamal|exe/g);
console.log(palindromes);

// Problem 11. String format
console.log('===== Problem 11. String format =====');

var arr = ['hubavi', 'cialoto', 'Radost'];
var string = 'Banica s {0} kasmeti za {1} semeistvo. {2} za vsichki!';

function stringFormat(someString, arr) {
	var len = arr.length;
	for (var i = 0; i < len; i+=1) {
		someString = someString.replace(i, arr[i])
							   .replace(/\{/g, '')
							   .replace(/\}/g, '');
	}
	console.log(someString);
}

stringFormat(string, arr);

// Problem 12. Generate list 		Written in Sublime.
console.log('===== Problem 12. Generate list =====');

var people = [{name: 'Peter', age: 14}];
	
	// * -> Uncomment and test in browser console:

// var template = document.getElementById('list-item').innerHTML;	// *

function generateList(arr, templ) {
	templ = templ.replace('name', arr[0].name)
				 .replace('age', arr[0].age)
				 .replace(/-{/g, '')	
				 .replace(/\}-/g, '')
				 .replace(/^/, '<li>')
				 .replace(/$/, '</li>')
	return '<ul>'+templ+'</ul>';
}

// var peopleList = generateList(people, template);					// *
// console.log(peopleList);											// *
