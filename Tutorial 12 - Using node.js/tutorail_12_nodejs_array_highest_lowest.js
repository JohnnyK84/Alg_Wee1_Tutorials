var array1 = [1,7,8,9,99,1029,111];
console.log(array1);

var largest = array1[0];
var smallest = array1[0];

for (var i = 1; i < array1.length; i++) {
    if (array1[i] > largest){
        largest = array1[i];
    }
    else if (array1[i] > largest) {
        smallest = array1[i];
    }
}
console.log(largest);
console.log(smallest)


