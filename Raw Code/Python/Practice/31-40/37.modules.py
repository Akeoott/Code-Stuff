# module =  a file containing python code. May contain functions, classes, etc.
#           used with modular programming, wich is to seperate a program into parts.

# import messages
# import messages as m
# from messages import hello,bye
# from messages import * (this one is dangerous)

help("modules")

print("https://docs.python.org/3/py-modindex.html")

def hello():
    print("Hi Hi Banana!")

def bye():
    print("Bye Bye Banana!")

# to call these functions from a different file in the same directory do as following

#import file_name

#file_name.hello()
#file_name.bye()

#---------------------------------

#import file_name as msg

#msg.hello()
#msg.bye()

#---------------------------------

#from file_name import hello,bye

#hello()
#bye()
