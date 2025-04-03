# import time is needed for breaks between loops/prints or whatever
import time
#   for loop =      a statement that will execute it's block of code
#                   a limited amount of times
#
#                   while loop = unlimited
#                   for loop = limited

# i stands for short index, the index can be called anything from seconds or bananas_a_second...

if False:
    for i in range(10): # counts from 1 to 10
        print(i+1)      # prevents it from starting at 0
if False:
    for i in range(50,100+1,2): # the third value makes it jump over every second number like a step
        print(i)
if False:
    for i in "Banana":
        print(i)

# use in practice-

for second in range(10,0,-1): # Count down starting from 10 down to 0.
    print(f"In T-{second} seconds you will explode :O")
    time.sleep(1) # using the time import we have a 1 second delay between each second.
print("BOOM!!!")