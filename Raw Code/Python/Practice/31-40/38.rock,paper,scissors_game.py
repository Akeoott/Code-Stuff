import random

choices = ["rock","paper","scissors"]

while True:
    comp = random.choice(choices)   # Assigns a random item from "choices" to comp wich then will be the decision that the computer makes
    pl = None

    while pl not in choices:
        pl = input("Rock, paper or scissors?: ").lower()    # The start of the game

    if pl == comp:
        print(f"Computer: {comp}")
        print(f"You: {pl}")
        print("Its a Tie!")

    elif pl == "rock":  # The item you selected
        if comp == "scissors":  # gets specifically compared if you win or lose
            print(f"Computer: {comp}")
            print(f"You: {pl}")
            print("You Loose!")
        if comp == "paper":
            print(f"Computer: {comp}")
            print(f"You: {pl}")
            print("You Win!")

    elif pl == "paper": # Second check
        if comp == "scissors":
            print(f"Computer: {comp}")
            print(f"You: {pl}")
            print("You Loose!")
        if comp == "rock":
            print(f"Computer: {comp}")
            print(f"You: {pl}")
            print("You Win!")

    elif pl == "scissors":  # Third check
        if comp == "rock":
            print(f"Computer: {comp}")
            print(f"You: {pl}")
            print("You Loose!")
        if comp == "paper":
            print(f"Computer: {comp}")
            print(f"You: {pl}")
            print("You Win!")

    p_again = input("Wanna play again? (y/n): ").lower()    # Ask if you want to play again

    if p_again != "y":
        break
print("Bye bye!")