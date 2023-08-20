//Oddish vs. Evenish (https://edabit.com/challenge/r6TSNwkLZ2DgsoKiH)
fn oddish_or_evenish(mut number: i32) -> String {
    let mut o_or_e:i32=0;
	while number > 0 {
		o_or_e += number % 10;
		number = number / 10;
	}
    if o_or_e%2==0 {
	    return "Evenish".to_string();
    } else {
        return "Oddish".to_string();
    }
}

fn main() {
    println!("{}", oddish_or_evenish(43));
    println!("{}", oddish_or_evenish(373));
    println!("{}", oddish_or_evenish(4433));
}
