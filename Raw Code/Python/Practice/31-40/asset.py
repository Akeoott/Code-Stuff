class Car:  # this declares what this is supposed to be, a import-able code block wich can be used from other files
    
    def __init__(self,make,model,year,color):
        # The init method  will construct objects for us. In other languages, this is called the constructer.
        # We need this method to create objects.

        # Then we assign our car objects, unique variables.
        self.make = make    # self. refers to the object we are currently working on or creating
        self.model = model  # = model is whatever we recive in the __int__ method that is called model
        self.year = year
        self.color = color

            # self refers to the object that is using this method
    def drive(self):    # function 1
        print(f"this {self.model} is driving")

    def stop(self):     # function 2
        print(f"This {self.model} is stopped")