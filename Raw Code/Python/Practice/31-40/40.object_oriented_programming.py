from asset import Car  # what is this?: "from (file name (has to be in same folder)) import (the name of your class)"

import time
# Here we require a make, model, year and color since thats whats requested in the class
# (folder: Assets. file: 40.assets.py)
car_1 = Car("Chevy","Corvette",2021,"blue") # if you maybe noticed, we are not passing "self" in, thats because python already does that for us!
car_2 = Car("Ford","Mustang",2022,"red")    # we can re-use classes

print(f"- {car_1.make}")
print(f"- {car_1.model}")
print(f"- {car_1.year}")
print(f"- {car_1.color}")

print()

car_1.drive()
car_1.stop()

time.sleep(1)
print("-"*20)

print(f"- {car_2.make}")
print(f"- {car_2.model}")
print(f"- {car_2.year}")
print(f"- {car_2.color}")

print()

car_2.drive()
car_2.stop()
