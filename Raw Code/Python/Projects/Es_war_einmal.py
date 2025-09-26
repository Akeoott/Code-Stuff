import sys,time

def slow_print(text, delay=0.05):
    for char in text:
        sys.stdout.write(char)
        sys.stdout.flush()
        time.sleep(delay)
    print()

def get_choice(prompt, options):
    while True:
        try:
            choice = int(input(prompt))
            if choice in options:
                return choice
            slow_print("Gebe eine gültige Option ein!")
        except ValueError:
            slow_print("Gebe eine gültige Zahl ein!")

# Es war einmal DÖNER! (made by Akeoot <3)
name = ""
while len(name) <= 2:
    name = input("Es gibt 4 enden... Was ist dein Name?: ")
if name == "777":
    slow_print("...Du erinnerst dich auf eine entscheidung bei deiner nächsten begegnung...")
if name == "Dev":
    slow_print("Das ist das CHEAT fenster! Töte das program SOFORT wenn du nicht gespoilert werden willst!")
    for second in range(10,0,-1):
        print(f"In T-{second} sec wirst du gespoilert!")
        time.sleep(1)
    print("Entscheidungen: 1-1 = Schlechtes Ende, 1-2 = SUPER Ende, 2-0 = Gutes Ende, 1-??? = SECRET-ENDE!")
    slow_print("DIRTY CHEATER!", 0.5)
    sys.exit()
slow_print("....", 0.4)
time.sleep(1)
slow_print(f"Es war einmal ein {name}.")
time.sleep(1)
slow_print(f"Dieser {name} ging zu einem Dönerladen, um sich einen saftigen Döner zu holen.")
time.sleep(1)

decision1 = get_choice(f"Ist {name} die Abkürzung gegangen (1) oder den normalen Weg (2)?: ", {1,2})

if decision1 == 1:
    print("Nicht Jetzt...")
    slow_print(f"{name} ist die Abkürzung gegangen!")
    slow_print(".....", 0.5)
    time.sleep(3)
    slow_print(f"Auf dem Weg zum Dönerladen wurde {name} von drei Manjeks angegriffen. Diese fetten Wixer...")
    if name == "777":
        slow_print("Jetzt ist deine zeit zu scheinen...")
    time.sleep(1)

    decision2 = get_choice(f"SCHNELL! KÄMPFT {name.upper()} (1) ODER FLÜCHTET {name.upper()} (2)!: ", {1,2,777})

    if decision2 == 1:
        slow_print("......", 0.8)
        slow_print(f"Die Manjeks haben {name}s Nudelarme gebrochen, ihn gefickt, sein Zuhause gefunden und seine Mutter vergewaltigt....")
        slow_print("Du hast das schlechte Ende erreicht... Eine dunkle stimme flüstert... 777?", 0.4)
    elif decision2 == 777:
        slow_print("...", 1)
        print()
        slow_print(f"Es ist {name} egal...", 0.4)
        time.sleep(2)
        slow_print(f"{name} ist jetzt alles egal...", 0.4)
        time.sleep(2)
        slow_print(f"Als die Manjeks auf {name} zuranten war es schon zu spät...           FÜR DIE MANJEKS!")
        time.sleep(1)
        slow_print(f"{name} gibt den Manjeks eine fette klatsche und sagt das verbotene satz...")
        slow_print('"Amına koyayım!"', 0.8)
        slow_print(f"{name} vergewaltigt die Manjeks mit seiner faust ins gesicht.")
        time.sleep(2)
        slow_print("Alle werden so hart geschlagen, sie hoffen nie geboren zu sein.")
        slow_print(f'"Siktir lan ihr fetten wixer" Schreit {name}', 0.6)
        slow_print(f"Er lacht in Schadenfreude...")
        time.sleep(3)
        print("-" * 33)
        slow_print("Du hast das SECRET-ENDE gefunden...        Gut gemacht >:)")
        print("-" * 33)

    else:
        slow_print(f"{name.upper()} RENNT!", 0.05)
        time.sleep(2)
        slow_print(f"Als {name} rannte, sind die Manjeks gestolpert und vor einen Bus geflogen...")
        time.sleep(2)
        slow_print(".....", 1)
        slow_print(f"{name} hat ihre paralysierten Körper gefickt und ihre Mütter geschlagen.")
        time.sleep(1)
        slow_print(f"Danach ist {name} zum Dönerladen gegangen und alles ging gut.")
        time.sleep(1)
        print("-" * 33)
        slow_print("Gratulation! Du hast das SUPER gute ende gefunden!")
        print("-" * 33)
else:
    slow_print(f"{name} ist nicht die Abkürzung gegangen...")
    time.sleep(2)
    slow_print(f"{name} ist am Dönerladen angekommen und alles ging gut!")
    time.sleep(1)
    print("-" * 33)
    slow_print("Gratulation! Du hast das gute Ende erreicht!")
    print("-" * 33)

    decision2 = get_choice("")
