//Censored Strings (https://edabit.com/challenge/5S5HBQW6zZp8eH3eL)
fn uncensor(text: &str, vowels: &str) -> String {
    let mut vowel = 0;
    let mut text_len = 0;
    let mut bytes = text.to_string().clone().into_bytes();
    let vows_bytes = vowels.to_string().into_bytes();

    for i in text.chars() {
        if i == '*' {
            bytes[text_len] = vows_bytes[vowel] as u8;
            vowel+=1;
        }
        text_len+=1
    }
    unsafe { return String::from_utf8_unchecked(bytes); }
}

fn main() {
    println!("{}", uncensor("Wh*r* d*d my v*w*ls g*?", "eeioeo"));
    println!("{}", uncensor("abcd", ""));
    println!("{}", uncensor("*PP*RC*S*", "UEAE"));
}
