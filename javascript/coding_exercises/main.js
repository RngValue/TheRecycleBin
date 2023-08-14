function less_than_hundret(a, b) {
    return a + b < 100;
}

function seven_boom(a) {
    if (a.includes(7)){ return "boom!"; } else return "there is no 7 in the array.";
}

//console.log(String(less_than_hundret(numberOne,numberTwo)));
console.log(seven_boom([1,2,3,4,5,6]));