// Christmas Tree (https://edabit.com/challenge/QeaCDhw3QrLwbeteD)

function tree(h) {
	let letree = []
	for (let i = 1; i <= h; i++) letree.push("#".repeat(i) + "#".repeat(Math.abs(i-1)))
	return letree
}

console.log(tree(5))
console.log(tree(0))
