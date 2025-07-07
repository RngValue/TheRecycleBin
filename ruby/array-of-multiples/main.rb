# Array of Multiples (https://edabit.com/challenge/X4nWvwWCqWYyGz6Ci)

def array_of_multiples (num, length)
	number = num
    arrayOfNumbers = Array.new()
    for i in 1..length do
        number = i * num
        arrayOfNumbers << number
        i+=1
    end
    return arrayOfNumbers
end

print array_of_multiples(7, 5)
puts " "
print array_of_multiples(12, 10)
puts " "
print array_of_multiples(17, 6)
puts " "