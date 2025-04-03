# **kwargs =    parameter that will pack all arguments into one dictionary
#               useful so that a functions can accept a varying amount of keyword arguments

def hello(**kwargs):    # Name doesnt matter, only the ** matter before the name assignment like "**something"
    if False:
        print(f"Hello {kwargs['first']} {kwargs['last']}")  # Prevents error even if there are more arguemnts
    print(f"Hello",end=' ')
    for key,value in kwargs.items():
        print(value,end=' ')

hello(title="Dr.",first="Banana",middle="Yellow",last="Man")