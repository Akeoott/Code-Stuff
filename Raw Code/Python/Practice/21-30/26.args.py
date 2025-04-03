# *args =    parameter that will pack all arguments into a tuple
#           useful so that function can accept a varying amount of arguments

def add(*args): # You can call "args" whatever you want you just need a "*" before it
    sum = 0
    args = list(args)
    args[0] = 0

    for i in args:
        sum += i
    return sum

print(add(1,2,3,5))