import tkinter as tk
from tkinter import *
import pyautogui
import sys

def ready():
    placeX = 10
    placeY = 10
    width, height= pyautogui.size()
    sWidth = 640
    sHeight = 490
    x=width/2-640/2
    y=height/2-490/2
    
    root = Tk()
    l = Label(root, text="l")
    l.place(x=placeX,y=placeY)
    
    def keydown(a):
        nonlocal placeX
        if a.char == "a":
            placeX -=5
            l.place(x=placeX,y=placeY)
        if a.char == "d":
            placeX +=5
            l.place(x=placeX,y=placeY)
            
    root.bind("<KeyRelease>", keydown)
    root.resizable(False, False)
    #root.eval('tk::PlaceWindow . center')
    root.geometry('%dx%d+%d+%d' % (sWidth, sHeight, int(x), int(y)))
    root.title("Testing :)")
    Button(root, text="Quit", command=root.destroy).pack()
    root.mainloop()
ready()