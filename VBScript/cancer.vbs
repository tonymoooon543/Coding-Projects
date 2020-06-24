Dim oPlayer
Set oPlayer = CreateObject("WMPlayer.OCX")

isdate1 = IsDate("June 24")
isdate2 = IsDate("June 24")
message = MsgBox("Gay", vbOKOnly)
counter1 = 0
counter2 = 0

If isdate1 = True Then
	Do
	counter1 = counter1 + 1
	WScript.Echo message
	Loop Until counter = 10000
End If

If isdate1 = True Then
	Do
	counter2 = counter2 + 1
	oPlayer.URL = "C:\Windows\WinSxS\amd64_microsoft-windows-shell-sounds_31bf3856ad364e35_10.0.18362.1_none_e96fec2e32c20607\Windows Background.wav"
	oPlayer.controls.play
	Loop Until counter2 = 100
End If