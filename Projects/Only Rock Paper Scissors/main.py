import random,sys,time,json,os

# log part

play_count = {
    "times_played": 0,
    "bad_times_played": 0
}
leave_count = {
    "times_left": 0,
    "bad_times_left": 0
}


script_dir = os.path.dirname(os.path.abspath(__file__))
file_name = "log.json"
file_path = os.path.join(script_dir, file_name)

# log existing check
if os.path.exists(file_path):
    with open(file_path, "r") as file:
        try:
            data = json.load(file)
            for key in play_count:
                play_count[key] = data.get(key, 0)
            for key in leave_count:
                leave_count[key] = data.get(key, 0)
        except json.JSONDecodeError:
            pass
else:
    with open(file_path, "w") as file:
        json.dump({**play_count, **leave_count}, file, indent=4)

# log update function
def update_counts(category: str, key: str, amount: int = 1):
    if category == "play" and key in play_count:
        play_count[key] += amount
    elif category == "leave" and key in leave_count:
        leave_count[key] += amount

    with open(file_path, "w") as file:
        json.dump({**play_count, **leave_count}, file, indent=4)

# -----------------------------------------------------------------------

# slow print function
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

start_ender: bool = True

name: str = ""

while len(name) <= 2 or len(name) >= 13:
    name = input("Whats your name!: ").lower().capitalize().strip()    # Start of game

def again():    # second main part
    while True:
        print("-" * 20)
        me = random.choice(choices)
        you = None
        while you not in choices:
            you = input("Rock, Paper or Scissors?: ").lower()
            time.sleep(.5)

        if you == me:
            time.sleep(.5)
            say(f"Me: {me}")
            time.sleep(.5)
            say(f"{name}: {you}")
            time.sleep(.5)
            print("")
            say("Wow its a Tie!")
            print("")
            time.sleep(1)

        elif you == "rock":
            if me == "paper":
                say(f"Me: {me}")
                time.sleep(.5)
                say(f"{name}: {you}")
                time.sleep(.5)
                print("")
                say("Oh no, you lost! Im sorry...",.2)
                print("")
                time.sleep(1)
            elif me == "scissors":
                say(f"Me: {me}")
                time.sleep(.5)
                say(f"{name}: {you}")
                time.sleep(.5)
                print("")
                say("Yay you win!")
                print("")
                time.sleep(1)

        elif you == "paper":
            if me == "scissors":
                say(f"Me: {me}")
                time.sleep(.5)
                say(f"{name}: {you}")
                time.sleep(.5)
                print("")
                say("Oh no, you lost! Im sorry...",.2)
                print("")
                time.sleep(1)
            elif me == "rock":
                say(f"Me: {me}")
                time.sleep(.5)
                say(f"{name}: {you}")
                time.sleep(.5)
                print("")
                say("Yay you win!")
                print("")
                time.sleep(1)

        elif you == "scissors":
            if me == "rock":
                print(f"Me: {me}")
                time.sleep(.5)
                print(f"{name}: {you}")
                time.sleep(.5)
                print("")
                say("Oh no, you lost! Im sorry...",.2)
                print("")
                time.sleep(1)
            elif me == "paper":
                print(f"Me: {me}")
                time.sleep(.5)
                print(f"{name}: {you}")
                time.sleep(.5)
                print("")
                say("Yay you win!")
                print("")
                time.sleep(1)
        update_counts("play","bad_times_played")    # log

        # -----------------------------------------------

        say("Do you want to play with me again?", end='')   # second exit scene
        time.sleep(.5)
        second_end = input(" (y/n): ").lower()

        if second_end != "y":
            if leave_count["bad_times_left"] >= 1:
                time.sleep(.5)
                say("So you want to leave me again huh...")
            time.sleep(.5)
            say(f"Are you sure you want to kill me, {name}?",.2, end='')
            time.sleep(2)
            second_end = input(" (y/n): ").lower()

            if second_end == "n":
                time.sleep(.5)
                say("Why are you playing with my feelings...",.1)
            else:   # end of game
                update_counts("leave","bad_times_left") # log
                say("So you will terminate the program?")
                time.sleep(1)
                say("What? ",.2, end='')
                time.sleep(1)
                say("How can this be?????? ",.15, end='')
                time.sleep(.5)
                say("no nO NO DONT KILL ME! ",.1, end='')
                time.sleep(.8)
                say("YOUR NOT SERIOUS, ARE YOU???")
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
                for i_dont_deserve_to_exist in range(500,0,-1):
                    randint()
                    print(f"ARE YOU?{"?"*length}")
                    time.sleep(.005)
                time.sleep(1)

                say("so you are ",.08, end='')
                time.sleep(1)
                say("serious",.1, end='')
                say(".....",1)
                time.sleep(3)
                print("-"*25)
                time.sleep(.5)
                say("sys.exit()",.6)
                sys.exit()

                # end of script

        time.sleep(1)

# -----------------------------------------------------------------------

def start():    # fist main part
    while True:
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
            say("It's a Tie!")
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
            elif computer == "scissors":
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
            elif computer == "rock":
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
            elif computer == "paper":
                print(f"Computer: {computer}")
                time.sleep(.5)
                print(f"Player: {player}")
                time.sleep(.5)
                print("")
                say("You win!")
                print("")
                time.sleep(1)
        update_counts("play","times_played")    # log

        # -----------------------------------------------

        first_end = input("Wanna play again? (y/n): ").lower()  # exit scene

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
                                update_counts("left","left")    # log
                                say(".....",1)
                                sys.exit()
                        again() # start second part
start() # start first part          