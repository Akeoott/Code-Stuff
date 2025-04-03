# str.format() =    optional method that gives users
#                   more control when displaying output

#------------------------------------------------------------------

a,b = "cow","moon"

print("The "+a+" jumped over the "+b)   # shit way to do it

print("The {} jumped over the {}".format(a,b))  # okay way to do it
print("The {1} jumped over the {0}".format(b,a))    # positional argument

if False:
    print("The {a} jumped over the {b}".format(a="cow",b="moon"))  # keyword argument

print(f"The {a} jumped over the {b}")   # best way to do it

text = "The {} jumped over the {}" # another way to do it
print(text.format(a,b))

#------------------------------------------------------------------

name = "Banana"

print("Hello, my name is {}".format(name))
print("Hello, my name is {:10}. Nice to meet you".format(name))
print("Hello, my name is {:<10}. Nice to meet you".format(name))
print("Hello, my name is {:>10}. Nice to meet you".format(name))
print("Hello, my name is {:^10}. Nice to meet you".format(name))

#------------------------------------------------------------------

pi = 3.14159
number = 1000

print("The number pi is {:.2f}".format(pi))
print("The number is {:,}".format(number))
print("The number is {:b}".format(number))
print("The number is {:o}".format(number))
print("The number is {:X}".format(number))
print("The number is {:E}".format(number))