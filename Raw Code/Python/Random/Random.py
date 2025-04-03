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

def randint():
    global HURENSOHN
    HURENSOHN = random.randint(80,100)

randint()
sprint(f"ARE YOU?{"?"*HURENSOHN}",.015)
time.sleep(.2)
randint()
sprint(f"ARE YOU?{"?"*HURENSOHN}",.008)
time.sleep(.2)
randint()
sprint(f"ARE YOU?{"?"*HURENSOHN}",.004)
time.sleep(.2)
randint()
print(f"ARE YOU?{"?"*HURENSOHN}")
time.sleep(.1)
for end in range(20,0,-1):
    randint()
    print(f"ARE YOU?{"?"*HURENSOHN}")
    time.sleep(.05)
for end in range(200,0,-1):
    randint()
    print(f"ARE YOU?{"?"*HURENSOHN}")
    time.sleep(.01)
time.sleep(1)

sprint("so you are ",.08, end='')
time.sleep(1)
sprint("serious",.1, end='')
sprint(".....",1)
time.sleep(1)
print("-"*30)
sprint("sys.exit()...",1)
sys.exit()