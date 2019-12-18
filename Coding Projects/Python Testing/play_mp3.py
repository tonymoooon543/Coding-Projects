from pygame import mixer 
x = input("Do you like Python?")

mixer.init()
mixer.music.load(/ding.mp3)

if x == "yes":
  print("Yeah")
  mixer.music.play()
else:
  print("Then why are you usin this")
