use std::io;
use std::io::Write;

fn main() {
    let power_of_the_sun = 4000;
    let mut final_power = 0;

    print!("Who's our opponent? > ");
    io::stdout().flush().unwrap();
    let mut user_input = String::new();
    io::stdin().read_line(&mut user_input).expect("couldn't read that.");
    user_input = user_input.trim().to_string();
    for character in user_input.chars() {
        final_power += character as u32;
    }
    println!("The power of 1 {user_input} is equel to {final_power}.");
    println!("The power of 1 trillion {user_input}s is equel to {final_power} trillion!");
    println!("The power of the sun (for the sake of this project) is {power_of_the_sun} trillion!");
    
    if final_power < power_of_the_sun {
        println!("The sun wins!");
    } else if final_power > power_of_the_sun {
        println!("One trillion {user_input}s win!");
    } else {
        println!("A blackhole swallowed the one trillion {user_input} with the sun!");
    }
}
