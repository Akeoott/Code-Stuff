from password_strength import PasswordPolicy, PasswordStats
import random
import string

def start():
    print("=========================\nPassword Tester and Maker\n=========================")
    commands: list[str] = ["make", "test", "help", "quit"]
    while True:
        command = ""
        command = input("\nEnter a Operation: ")

        if command not in commands:
            print("You must enter a operation.\n(Enter 'help' to get available commands)\n")
        else:
            if command == "quit":
                break

            elif command == "make":
                while True:
                    length = input("Password length (min 12): ")
                    try:
                        length = int(length) if length else 12
                        new_pass = makePassword(length)
                        print(f"Generated password: {new_pass}")

                        testResult = passwordTest(new_pass)
                        testResultPrint(testResult)
                    except ValueError:
                        print("Invalid length.")
                    break

            elif command == "test":
                testPasswd = ""
                while len(testPasswd) == 0:
                    testPasswd = input("Enter a password: ")

                testResult = passwordTest(testPasswd)
                testResultPrint(testResult)
            else:
                help()

    print("\nByebye :3")

def help():
    print("\nOperations:")
    print("\tmake\t: Make a new password.")
    print("\ttest\t: Test a password.")
    print("\thelp\t: Display available commands.")
    print("\tquit\t: Quit program.")
    print("(warning, case sensitive)")

def makePassword(length=12):
    if length < 12:
        length = 12

    lower = string.ascii_lowercase
    upper = string.ascii_uppercase
    digits = string.digits
    special = "!@#$%^&*()_+-=[]{}|;:,.<>?"

    password = [
        random.choice(lower),
        random.choice(upper),
        random.choice(digits),
        random.choice(special)
    ]

    all_chars = lower + upper + digits + special
    password += random.choices(all_chars, k=length-4)

    random.shuffle(password)
    return ''.join(password)


def passwordTest(testPasswd):
    testPasswdTest = testPolicy.test(testPasswd)
    testPasswdStrength = PasswordStats(testPasswd)

    testResult = [testPasswdTest, testPasswdStrength.strength()]
    return testResult

def testResultPrint(testResult):
    def get_strength_label(score):
        if score < 0.3:
            return "WEAK"
        elif score < 0.5:
            return "GOOD"
        elif score < 0.7:
            return "STRONG"
        elif score < 0.9:
            return "SUPER STRONG"
        else:
            return "IMPOSSIBLY STRONG"

    # Returns true if a specific item is in the list (if its in the list, it means its missing in the password)
    has_length = any("Length" in str(item) for item in testResult)
    has_uppercase = any("Uppercase" in str(item) for item in testResult)
    has_numbers = any("Numbers" in str(item) for item in testResult)
    has_special = any("Special" in str(item) for item in testResult)
    has_nonLetters = any("NonLetters" in str(item) for item in testResult)

    print("\nPassword Analysis:")
    # If its true that its missing in the password, it says it here. I tested this shit. Dont question it.
    print(f"\t{no_has if has_length else yes_has} Length: 8 characters")
    print(f"\t{no_has if has_uppercase else yes_has} min 2 uppercase letters")
    print(f"\t{no_has if has_numbers else yes_has} min 2 numbers")
    print(f"\t{no_has if has_special else yes_has} min 2 special characters")
    print(f"\t{no_has if has_nonLetters else yes_has} min 2 non letters")

    print(f"Complexity score: {round(testResult[1], 2)}")
    print(f"Strength: {get_strength_label(round(testResult[1], 2))}")

if __name__ == "__main__":
    testPolicy = PasswordPolicy.from_names(
        length=8,       # min length: 8
        uppercase=2,    # need min. 2 uppercase letters
        numbers=2,      # need min. 2 digits
        special=2,      # need min. 2 special characters
        nonletters=2,   # need min. 2 non-letter characters (digits, specials, anything)
    )

    yes_has = "✓ Contains"
    no_has = "✗ Missing"

    try:
        start()
    except KeyboardInterrupt:
        print("\nKeyboard interrupt detected :0")
        print("Byebye :3")
    except Exception as e:
        print("\nSomething went wrong :0")
        print(f"Error: {e}")
        print("I'm sorry ;-;")
        input("press enter to exit... ")
