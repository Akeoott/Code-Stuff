import time, sys, winsound

musket_sounds = ["musket1.wav", "musket2.wav"]

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

def play_sound(sound):
    """Plays a sound without blocking execution."""
    winsound.PlaySound(sound, winsound.SND_FILENAME | winsound.SND_ASYNC) # type: ignore

sprint("Now, I can only speak python... ", end='', flush=True)
time.sleep(1)
sprint('"Just as the founding fathers intended"', delay=.08)
print("")
time.sleep(2)

sprint("Own a musket for home defense, ", end='', flush=True)
time.sleep(.5)
sprint("since that's what the founding fathers intended.")
print("")
time.sleep(2)

sprint("Four ruffians break into my house. ", end='', flush=True)
time.sleep(.5)
sprint('"What the devil?" ', end='', flush=True)
time.sleep(.5)
sprint("As I grab my powdered wig and Kentucky rifle.")
print("")
time.sleep(1.5)

sprint("Blow a golf ball sized hole through the first man, ", end='', flush=True)
play_sound("musket1.wav")
time.sleep(.5)
sprint("he's dead on the spot.", delay=.3)
print("")
time.sleep(1)

sprint("Draw my pistol on the second man, ", end='', flush=True)
time.sleep(.5)
play_sound("musket2.wav")
sprint("miss him entirely because it's smoothbore and nails the neighbor's dog.")
print("")
time.sleep(1)

sprint("I have to resort to the cannon... ", end='', flush=True)
time.sleep(1)
sprint("mounted at the top of the stairs loaded with grape shot, ", end='', flush=True)
time.sleep(.5)
sprint('"Tally ho lads" ', end='', flush=True)
time.sleep(.5)
sprint("the grape shot shreds two men in the blast, ", end='', flush=True)
time.sleep(.5)
sprint("the sound and extra shrapnel set off car alarms.")
print("")
time.sleep(1)

sprint("Fix bayonet and charge the last terrified rapscallion.")
print("")
time.sleep(1)
sprint("He bleeds out waiting on the police to arrive since triangular bayonet wounds are impossible to stitch up, ", end='', flush=True)
time.sleep(2)
sprint("Just as the founding fathers intended...", delay=.3)
