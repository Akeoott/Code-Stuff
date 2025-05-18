# return statement =    Funktions send Python values/objects back to the caller.
#                       These values/objects are known as the funktion's return value.

def multiply(num1: int, num2: int):
    return num1 * num2  # Returns the restult back to the caller

x = multiply(6,8)   # Stored result in variable if needed

print(x)    # Caller gets result and prints