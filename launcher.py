import webbrowser
from threading import Thread
import sys

class Game:
    games = {"plasty-papir-ostatni": {"type": "web", "url": "plasty-papir-ostatni/index.html"}}
    def __init__(self, name):
        self.name = name
        self.type = Game.gettype(name)
    def start(self):
        if self.type == "web":
            Game.openweb(Game.getweburl(self.name))
        else:
            Game.openother(name)
    def gettype(name):
        return Game.games[name]["type"]
    def getweburl(name):
        return Game.games[name]["url"]
    def openweb(url):
        webbrowser.open(url)
    def openother(name):
        # work for ParicBat to implement starting of c# games
        return None

def start_(name):
    game = Game(name)
    game.start()

def start(name):
    th = Thread(target=start_, args=(name,))
    th.start()

if __name__ == "__main__":
    start(sys.argv[1])
