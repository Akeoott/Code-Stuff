# Its time to put what ive learned to the test... I will make everything wrong i tell you!
print("-" * 32)
print("A basic calculator made by MEEEE")
print("-" * 32)

while True:
    try:
        calc = int(input("How do you want to calculate? Use + (1), - (2), * (3), or / (4): "))
        x = float(input("First number: "))
        y = float(input("Second number: "))
        print("-" * 20)

        if calc == 1:
            print(f"Result: {x + y}")
        elif calc == 2:
            print(f"Result: {x - y}")
        elif calc == 3:
            print(f"Result: {x * y}")
        elif calc == 4:
            print(f"Result: {x / y}")
        else:
            print("Invalid calculation number, you idiot!")
        print("-"*20)

        again = input("Wanna make another calculation? (y/n): ").lower()

        if again != "y":
            break
        print("-" * 30)

    except ValueError:
        print("-" * 20)
        print("Invalid input! Please enter numbers only or are you dyslexic...")
        print("-" * 20)
    except ZeroDivisionError:
        print("-" * 20)
        print("You cant divide by zero!")
        print("-" * 20)
    except Exception as e:
        print("Something went wrong :/")
        print("-"*30)
        print(e)
        print("-"*30)

print("-" * 30)
print("Bye bye!")
