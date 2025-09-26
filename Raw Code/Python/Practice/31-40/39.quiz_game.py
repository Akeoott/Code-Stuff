# ------------------------------

def n_game():   # Function to start a new game

    guesses = []
    c_guesses = 0
    question_num = 1

    for key in questions:
        print("-"*30)
        print(key)
        for i in options[question_num-1]:
            print(i)
        guess = input("Enter (A, B, C, or D): ")
        guess = guess.upper()
        guesses.append(guess)

        c_guesses += c_answer(questions.get(key),guess)
        question_num += 1

    d_score(c_guesses, guesses)

# ------------------------------

def c_answer(answer, guess):    # Function to compare if your guess was correct

    if answer == guess:
        print()
        print("Correct!")
        return 1
    else:
        print()
        print("Wrong!")
        return 0

# ------------------------------

def d_score(c_guesses, guesses):    # Function that displays your score aka accuracy after finishing the game
    print("-"*30)
    print("Results")
    print("-"*30)

    print("Answers: ", end=' ')
    for i in questions:
        print(questions.get(i), end=' ')
    print()

    print("Guesses: ", end=' ')
    for i in guesses:
        print(i, end=' ')
    print()

    score = int((c_guesses/len(questions))*100)
    print(f"Your score is {str(score)}%")

# ------------------------------

def p_again():  # Function that asks if you want to play again

    resp = input("Wanna play again? (y/n): ").lower()

    if resp == "y":
        return True
    else:
        return False

# ------------------------------

name = None

questions = {
    "Whats the name of hitlers best friend? ": "A",
    "In what year did germany fall in the second world war? ": "C",
    "Is the earth flat? ": "D",
    "Who are you? ": "B"
}

options = [["A: August Kubizek","B: Josef Goebbels","C: Heinrich Himmler","D: Rudolf Hess"],
           ["A: May 8, 1945","B: March 7, 1945","C: May 7, 1945","D: May 7, 1944"],
           ["A: True","B: Sometimes","C: This is blasphemy","D: False"],
           ["A: Human","B: A biological life form","C: You are you","D: I dont know..."]]

n_game()

while p_again():
    n_game()

print("Bye bye!")
