# This is a very simple login system

with open ("user.txt", "r") as userfile:
    password = userfile.readline()
    username = userfile.readline(2)

if username=="user1" and password=="password":
    print("Welcome, Tonymoooon543")
    print("https://www.google.com")
