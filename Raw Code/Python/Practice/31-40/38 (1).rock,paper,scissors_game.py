import random,sys,time

def sprint(text, delay=.05, break_after=None, break_time=.3, end='\n', flush=True):
    for i, char in enumerate(text):
        sys.stdout.write(char)
        if flush:
            sys.stdout.flush()
        time.sleep(delay)

        if break_after and (i + 1) % break_after == 0:
            time.sleep(break_time)

    sys.stdout.write(end)
    if flush:
        sys.stdout.flush()

while True:
    choices = ["rock","paper","scissors"]

    comp = random.choice(choices)
    player = None

    while player not in choices:
        player = input("rock, paper or scissors?: ").lower()

    if player == comp:
        print(f"Computer: {comp}")
        print(f"Player: {player}")
        time.sleep(.5)
        print("")
        sprint("Its a Tie!")
        print("")
        time.sleep(1)

    elif player == "rock":
        if comp == "paper":
            print(f"Computer: {comp}")
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            sprint("You lose!",.2)
            print("")
            time.sleep(1)
        if comp == "scissors":
            print(f"Computer: {comp}")
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            sprint("You win!")
            print("")
            time.sleep(1)

    elif player == "paper":
        if comp == "scissors":
            print(f"Computer: {comp}")
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            sprint("You lose!",.5)
            print("")
            time.sleep(1)
        if comp == "rock":
            print(f"Computer: {comp}")
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            sprint("You win!")
            print("")
            time.sleep(1)

    elif player == "scissors":
        if comp == "rock":
            print(f"Computer: {comp}")
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            sprint("You lose!",.2)
            print("")
            time.sleep(1)
        if comp == "paper":
            print(f"Computer: {comp}")
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            sprint("You win!")
            print("")
            time.sleep(1)
    
    p = input("Wanna play again? (y/n): ").lower()

    if p == "n":
        time.sleep(.5)
        p = input("Are you sure? (y/n): ").lower()
        if p == "y":
            time.sleep(.5)
            sprint("Do you want to stay?", end='')
            time.sleep(.5)
            p = input(" (y/n): ")
            if p == "n":
                time.sleep(1)
                sprint("You really want to leave me?", end='')
                time.sleep(.5)
                p = input(" (y/n)... ")
                if p == "y":
                    time.sleep(1)
                    sprint("I know where you live... ",.2, end='')
                    time.sleep(1)
                    p = input(" (y/n): ")
                    if p == "n":
                        break
sprint("...",1)