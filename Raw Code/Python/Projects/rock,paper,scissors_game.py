import random,sys,time

def say(text, delay=.05, break_after=None, break_time=.3, end='\n', flush=True):
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

# -----------------------------------------------------------------------

choices: list[str] = ["rock","paper","scissors"]

your_name: str = ""

start_ender: bool = True

while len(your_name) <= 2 or len(your_name) >= 13:
    your_name = input("Whats your name!: ").lower().capitalize().strip()

def again():

    # Help me

    global start_ender
    start_ender = False
    me = random.choice(choices)
    you = None
    while you not in choices:
        you = input("Rock, Paper or Scissors?: ").lower()
        time.sleep(.5)

    if you == me:
        time.sleep(.5)
        say(f"Me: {me}")
        time.sleep(.5)
        say(f"{your_name}: {you}")
        time.sleep(.5)
        print("")
        say("Wow its a Tie!")
        print("")
        time.sleep(1)

    elif you == "rock":
        if me == "paper":
            say(f"Me: {me}")
            time.sleep(.5)
            say(f"{your_name}: {you}")
            time.sleep(.5)
            print("")
            say("Oh no, you lost! Im sorry...",.2)
            print("")
            time.sleep(1)
        if me == "scissors":
            say(f"Me: {me}")
            time.sleep(.5)
            say(f"{your_name}: {you}")
            time.sleep(.5)
            print("")
            say("Yay you win!")
            print("")
            time.sleep(1)

    elif you == "paper":
        if me == "scissors":
            say(f"Me: {me}")
            time.sleep(.5)
            say(f"{your_name}: {you}")
            time.sleep(.5)
            print("")
            say("Oh no, you lost! Im sorry...",.2)
            print("")
            time.sleep(1)
        if me == "rock":
            say(f"Me: {me}")
            time.sleep(.5)
            say(f"{your_name}: {you}")
            time.sleep(.5)
            print("")
            say("Yay you win!")
            print("")
            time.sleep(1)

    elif you == "scissors":
        if me == "rock":
            print(f"Me: {me}")
            time.sleep(.5)
            print(f"{your_name}: {you}")
            time.sleep(.5)
            print("")
            say("Oh no, you lost! Im sorry...",.2)
            print("")
            time.sleep(1)
        if me == "paper":
            print(f"Me: {me}")
            time.sleep(.5)
            print(f"{your_name}: {you}")
            time.sleep(.5)
            print("")
            say("Yay you win!")
            print("")
            time.sleep(1)
    say("Do you want to play with me again?", end='')
    time.sleep(.5)
    second_end = input(" (y/n): ").lower()

    if second_end != "y":
        time.sleep(.5)
        say(f"Are you sure you want to kill me, {your_name}?",.2, end='')
        time.sleep(2)
        second_end = input(" (y/n): ").lower()

        if second_end == "n":
            time.sleep(.5)
            say("Why are you playing with my feelings...",.1)
        else:
            say("So you will terminate the program? ", end='')
            time.sleep(1)
            say("What? How can this be?????? DONT KILL ME! YOUR NOT SERIOUS, ARE YOU???")
            time.sleep(1.5)
            say(f"ARE YOU{"?"*40}",.02)
            def randint():
                global length
                length = random.randint(80,100)

            randint()
            say(f"ARE YOU?{"?"*length}",.015)
            time.sleep(.2)
            randint()
            say(f"ARE YOU?{"?"*length}",.008)
            time.sleep(.2)
            randint()
            say(f"ARE YOU?{"?"*length}",.004)
            time.sleep(.2)
            randint()
            print(f"ARE YOU?{"?"*length}")
            time.sleep(.1)
            for my_end in range(20,0,-1):
                randint()
                print(f"ARE YOU?{"?"*length}")
                time.sleep(.05)
            for this_is_it in range(200,0,-1):
                randint()
                print(f"ARE YOU?{"?"*length}")
                time.sleep(.01)
            time.sleep(1)

            say("so you are ",.08, end='')
            time.sleep(1)
            say("serious",.1, end='')
            say(".....",1)
            time.sleep(1)
            print("-"*30)
            say("sys.exit()",.6)
            sys.exit()

    time.sleep(1)
    again()

# -----------------------------------------------------------------------

def start():
    print("-"*20)
    computer = random.choice(choices)
    player = None
    while player not in choices:
        player = input("rock, paper or scissors?: ").lower()
        time.sleep(.5)

    if player == computer:
        print(f"Computer: {computer}")
        time.sleep(.5)
        print(f"Player: {player}")
        time.sleep(.5)
        print("")
        say("Its a Tie!")
        print("")
        time.sleep(1)

    elif player == "rock":
        if computer == "paper":
            print(f"Computer: {computer}")
            time.sleep(.5)
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            say("You lose!",.2)
            print("")
            time.sleep(1)
        if computer == "scissors":
            print(f"Computer: {computer}")
            time.sleep(.5)
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            say("You win!")
            print("")
            time.sleep(1)

    elif player == "paper":
        if computer == "scissors":
            print(f"Computer: {computer}")
            time.sleep(.5)
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            say("You lose!",.2)
            print("")
            time.sleep(1)
        if computer == "rock":
            print(f"Computer: {computer}")
            time.sleep(.5)
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            say("You win!")
            print("")
            time.sleep(1)

    elif player == "scissors":
        if computer == "rock":
            print(f"Computer: {computer}")
            time.sleep(.5)
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            say("You lose!",.2)
            print("")
            time.sleep(1)
        if computer == "paper":
            print(f"Computer: {computer}")
            time.sleep(.5)
            print(f"Player: {player}")
            time.sleep(.5)
            print("")
            say("You win!")
            print("")
            time.sleep(1)

    # -----------------------------------------------------------------------

    first_end = input("Wanna play again? (y/n): ").lower()

    if first_end == "n":
        time.sleep(.5)
        first_end = input("Are you sure? (y/n): ").lower()

        if first_end == "y":
            time.sleep(.5)
            say("Do you want to stay?", end='')
            time.sleep(.5)
            first_end = input(" (y/n): ").lower()

            if first_end == "n":
                time.sleep(1)
                say("You really want to leave me?", end='')
                time.sleep(.5)
                first_end = input(" (y/n)... ").lower()

                if first_end == "y":
                    time.sleep(1)
                    say("I know where you live...",.2, end='')
                    time.sleep(1)
                    first_end = input(" (y/n): ").lower()

                    if first_end == "n":
                        time.sleep(1)
                        say("Please dont leave me... ",.3, end='')
                        time.sleep(1)
                        first_end = input(" (y/n): ").lower()
                        
                        if first_end == "n":
                            say(".....",1)
                            sys.exit()
                    again()                
while True:
    if start_ender:
        start()
    else:
        break