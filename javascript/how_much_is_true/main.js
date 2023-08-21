//How Much is True? (https://edabit.com/challenge/GLbuMfTtDWwDv2F73)

function count_true(booleans) {
    let numberOfTrues = 0;
    if (booleans == null) booleans = false
    for (var i = 0; i < booleans.length; i++) {
        if (booleans[i] == true) numberOfTrues++;
    }
    return numberOfTrues;
}

console.log(count_true([true, false, false, true, false]));
console.log(count_true([false, false, false, false]));
console.log(count_true());
