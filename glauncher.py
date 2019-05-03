import webbrowser
from threading import Thread
import sys
import tkinter as tk
from launcher import *

def plasty_papir_ostatni(*a, **k):
    start("plasty-papir-ostatni")

root = tk.Tk()
root.title("")
root.minsize(300, 300)
root.maxsize(300, 300)

title = tk.Label(root, text="Spouštěč her")
title.config(font=("", 20))
title.pack(side="top")

space = tk.Label(root, text="")
space.pack(side="top")

game1 = tk.Button(root, text="Plasty, papír, ostatní", command=plasty_papir_ostatni)
game1.pack(side="top")

quit = tk.Button(root, text="Odejít", command=root.quit)
quit.pack(side="bottom")

root.mainloop()
