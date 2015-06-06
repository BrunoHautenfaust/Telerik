// Problem 1. Increase array members
console.log('===== Problem 1. Increase array members =====')

var arr = [];
arr.length = 20;
var length = arr.length;

for (var i = 0; i < length; i+=1) {
	arr[i]=i*5;
	console.log(arr[i]);
}

// Problem 2. Lexicographically comparison
console.log('===== Problem 2. Lexicographically comparison =====')

var arr1 = ['a', 'b', 'c'];
var arr2 = ['a', 'b', 'd'];

for (var i = 0; i < 3; i+=1) {
	if (arr1[i] === arr2[i]) {
		console.log(arr1[i]+' = '+arr2[i]);
	} else {
		console.log(arr1[i]+' =/= '+arr2[i]);
	}
}

// Problem 3. Maximal sequence !x
console.log('===== Problem 3. Maximal sequence =====')

        var arr = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
var length = arr.length;

var primary = arr[0];
var pcounter = 1;
var secondary = 0;
var scounter = 0;
var fArr1 = [];
var fArr2 = [];

for (var i = 1; i < length; i+=1) {
            if (primary === arr[i]) {
			fArr1.push(arr[i]);
                pcounter++;
            }
            //  else if (Secondary < Primary && Scounter < Pcounter)
            else {						
                secondary = primary;	
                scounter = pcounter;	
                primary = arr[i];
                fArr2 = fArr1;
                fArr1 = [];
                fArr1.push(primary);				
                pcounter = 1;
            }
        }
        // (primary > secondary && pcounter > scounter)
        if (fArr1.length > fArr2.length) {
            console.log(fArr1);
        } else {
            console.log(fArr2);
        }

// Problem 4. Maximal increasing sequence
console.log('===== Problem 4. Maximal increasing sequence =====')

var arr = [3, 2, 3, 4, 2, 2, 4];
var length = arr.length;
var number = arr[0];
var text = '';
var Secondary = '';

            for (var i = 1; i < length; i+=1) {
               if (arr[i] - number === 1) {
                   text += ', ' + arr[i];
               } else {
                   if (text.length > Secondary.length) {
                       Secondary = text;
                   }
                   text = '' + arr[i];   
               }
               number = arr[i];
            }

            if (text.length > Secondary.length) {
                console.log(text);
            } else {
                console.log(Secondary);
            }

// Problem 5. Selection sort !x
console.log('===== Problem 5. Selection sort =====')

var arr = [3, 2, 5, 4, 1];
var sortedArr = [];

 for (var i = 0; i < length; i+=1) {
            var index = i;
            for (var j = i + 1; j < length; j+=1) {
                if (arr[index] > arr[j])
                    index = j;

                var smallerNumber = arr[index];
                arr[index] = arr[i];
                arr[i] = smallerNumber;
            }
             sortedArr.push(arr[i]);
        }
            console.log(sortedArr);

// Problem 6. Most frequent number !x
console.log('===== Problem 6. Most frequent number =====')

var arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

var current = 0;
        var counter = 0;
        var savedCurrent = 0;
        var SavedCounter = 0;

        for (var i = 0; i < length; i+=1) {
            current = arr[i];
            counter = 0;

            for (var j = 0; j < length; j+=1) {
                if (current === arr[j])
                {
                    counter+=1;
                }
                if ((j === length - 1) && (counter >= SavedCounter)) {
                    savedCurrent = current;
                    SavedCounter = counter;
                }
            }
        }

        if (counter > SavedCounter) {
            console.log(current+'-'+counter+' times');
        } else {
            console.log(savedCurrent+'-'+SavedCounter+' times');
        }

