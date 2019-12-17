class Person:
    def __init__(self, name, age):
        self.name = name
        self.age = age

    def myfunc(self):
        print("Hello my name is " + self.name)

p1 = Person("John", 36)
p1.myfunc() 




class Company:
    def __init__(self, name, ceo, rev, pro):
        self.name = name
        self.ceo = ceo
        self.rev = rev
        self.pro = pro


    def details(self):
            print("Company details " + self.name + self.ceo + self.rev + self.pro)

company = Company("Google ", "Sundar ", "3Billion ", "1Billion")
company.details()