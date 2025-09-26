# type casting = convert the data type of a value to another data type.

x = 1       #int
y = 2.0     #float
z = "3"     #str

x = str(x)
y = int(y)
z = float(z) # changed str to float

print(x)
print(y)
print(z*3) # cant do math with a str, this is a float

# why would you want to convert a int or float into a str? Cuz there will be an error: can only concatrnate str (not "int") to str

print("x is "+str(x))
print("y is "+str(y))
print("z is "+str(z))
