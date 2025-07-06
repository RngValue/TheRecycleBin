// Christmas Tree (https://edabit.com/challenge/QeaCDhw3QrLwbeteD)

function tree(h) {
	let letree = []
	for (let i = 1; i <= h; i++) letree.push("#".repeat(i))
	return letree
}

console.log(tree(5))
