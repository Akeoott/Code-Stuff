# len = length of string (How many characters)

name = "banana"
print(len(name))

# find = finds where specified character is located in string starting with 0 as the first character

print(name.find("b"))

# capitalize = capitalizes the string (only the first letter)

print(name.capitalize())

# upper = will make string all uppercase

print(name.upper())

# lower = will make string all lowercase

name2 = "BANANA"
print(name2.lower())

# isdigit = will return true or false depending on if the string is ONLY a digit

print(name.isdigit())

# isalpha = will return true or false if the string only contains alphabetical characters (Space is not alphabetical)

print(name.isalpha())

# count = counts how many characters there are in a string (a character must be specefied)

print(name.count("a"))

# replace = replace a specefied character in the string with another specefied character
#example = print(name.replace("selected character","replace with"))
print(name.replace("n","k"))

# * = print string multiple times with selected number

print(name*3)