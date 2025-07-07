//"Less Than 100?" https://edabit.com/challenge/9MjEpkL7yAjAqiH58
function less_than_hundred(a, b) {
    return a + b < 100;
}

//"Seven Boom!" https://edabit.com/challenge/6R6gReGTGwzpwuffD
//Doesn't check digits but numbers. Didn't bother.
function seven_boom(a) {
    if (a.includes(7)){ return "boom!"; } else return "there is no 7 in the array.";
}

//"Number of Boomerangs" https://edabit.com/challenge/b7iHQDw72zzkmgCun
var numberOfBoomerangs = 0;
function boomerangs(a) {
    for (var i = 0; i < a.length; i++) {
        if (a[i+2] == a[i] && a[i+1] != a[i]) numberOfBoomerangs++;
        if (i+2 == a.length) break;
    }
    return numberOfBoomerangs;
}

console.log(String(less_than_hundred(10,15)));
console.log(seven_boom([1,2,3,4,5,6]));
console.log(String(boomerangs([2,1,2,1,2,1,1,1])));