# nested functions calls =  function calls inside other function calls
#                           innermost function calls are resolved first
#                           returned value is used as argument for the next outer function

if False: # The extended version.
    num = input("Enter a whole positive number: ") # Get input like -3.12
    num = float(num)    # Convert from str to float
    num = abs(num)  # Will find the absolute value
    num = round(num)    # Will round it
    print(num)  # Will print it! (3)

print(round(abs(float(input("Enter a whole positive number: "))))) # Get all the above in one line of code!

if False:
    while True:
        try:
            a = (round(abs(float(input("Enter a whole positive number: ")))))
            print(f"Your have chosen {a}")
            break
        except ValueError:
            print("Only numbers! ", end='', flush=True)