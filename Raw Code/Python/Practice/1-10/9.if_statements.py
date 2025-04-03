# if statement = a block of code that will execute if it's condition is true

# lets start with a prompt
age = int(input("How old are you?: "))

# if the statement is true it will print, if not, it will skip over it and go to elif if elif exists

if age == 100:                              # make sure to use dubble = cuz python will think your trying to assign age to 100 and not compare it
    print("You are a century old!")
elif age >= 18:                             # greater is > equal to is = lower is <
    print("you are an adult!")              # the indent of the code is the code block of the if statement
elif age < 0:                               # third if check if, if/elif is false
    print("You haven't been born yet!")
else:                                       # if all is false else will perform as a last resort
    print("Your are a child!")

# If the if is false and the elif, it will perfome else below the if and elif block

# REMEMBER THAT THE ORDER OF THE CODE IS IMPORTANT!