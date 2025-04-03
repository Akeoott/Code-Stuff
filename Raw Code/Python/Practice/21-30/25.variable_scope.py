# scope =   The region that a variable is recognized
#           A variable is only available from inside the region it is created
#           A global and locally scoped versions of a variable can be created

name = "Banana" # global scope (availavle inside & outside functions)

def display_name():
    name = "Man"    # local scope (available only inside this function)

    global another_name # if you want to make a local variable global, declare it as global and then create it!
    another_name = "Leonard!"

    print(name)     # if variable name doesnt exist inside function then the next available variable will be used (the global "name")

print(f"{name} ", end='')   # end='' makes the end blank aka it wont create a new line.
display_name()

print(f"i turned this global! {another_name}")

# Rule:
# L = Local
# E = Enclosing
# G = Global
# B = Built-in