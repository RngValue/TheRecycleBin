use std::io;

fn main() {
    let power_of_the_sun = 400;
    let mut final_power = 0;

    let mut user_input = String::new();

    let _ = io::stdin().read_line(&mut user_input);
    for character in user_input.chars() {
        final_power += character as u32;
    }
    println!("The power of 1 {user_input} is equel to {final_power}.");
    println!("The power of 1 trillion {user_input}s is equel to {final_power} trillion.");
    println!("")
}
