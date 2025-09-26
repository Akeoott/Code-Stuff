# exception =   events detected durring execution that interrupt the flow of a program


try:    # this code block might be dangerous thats why we try and we handle the exception aka error
    numenator = int(input("Enter a number to divide: "))
    denominator = int(input("Enter a number to divide by: "))
    result = numenator / denominator
except ZeroDivisionError as e:
    print(f"error: {e}")
    print("You can't devide by zero! idiot!")
except ValueError as e:
    print(f"error: {e}")
    print("Enter only numbers plz")
except Exception as e:
    print(f"error: {e}")
    print("Something went wrong :(")
else:
    print(result)
finally:
    print("This will always execute")
