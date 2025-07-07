//Sum of v0w3ls (https://edabit.com/challenge/EvnxqYiyBN7is2Qxv)
const std = @import("std");
const print = std.debug.print;

pub fn main() !void {
   var sumOfVowels:u32 = 0;

   sumOfVowels = sum_of_vowels("Let's test this function.");
   print("{}\n", .{sumOfVowels});
   sumOfVowels = sum_of_vowels("Do I get the correct output?");
   print("{}\n", .{sumOfVowels});
   sumOfVowels = sum_of_vowels("I love edabit!");
   print("{}\n", .{sumOfVowels});
}

pub fn find_in_string(value:anytype, array:[]const u8) u32 {
   for (array, 0..) |n, i| { if (n == value) return @intCast(i); }
   return 0;
}

const vowels = "OI0EA";
pub fn sum_of_vowels(text:[]const u8) u32{
   var sum:u32 = 0;
   for (text) |character| sum += find_in_string(std.ascii.toUpper(character), vowels);
   return sum;
}