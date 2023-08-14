function less_than_hundret(a, b) {
    return a + b < 100;
}

function seven_boom(a) {
    if (a.includes(7)){ return "boom!"; } else return "there is no 7 in the array.";
}

var numberOfBoomerangs = 0;
function boomerangs(a) {
    for (var i = 0; i < a.length; i++) {
        if (a[i+2] === a[i]) numberOfBoomerangs++;
        if (i+2 === a.length) break;
    }
    return numberOfBoomerangs;
}

console.log(String(less_than_hundret(10,15)));
console.log(seven_boom([1,2,3,4,5,6]));
console.log(String(boomerangs([2,1,2,1,2,1,2,1])));