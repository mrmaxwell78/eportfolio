class GameStats():
    #Track your statistics
    def __init__(self, si_settings):
        self.si_settings = si_settings
        self.reset_stats()
        self.game_active = False
        #high score should never be reset
        self.high_score = 0

    def reset_stats(self):
        #Initialize statistics that can change during the game.
        self.ships_left = self.si_settings.ships_left
        self.score = 0
        self.level = 1