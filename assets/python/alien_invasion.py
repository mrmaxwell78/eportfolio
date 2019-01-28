import pygame

from settings import Settings
from ship import Ship
import game_functions as gf
from pygame.sprite import Group
from aliens import Alien
from game_stats import GameStats
from button import Button
from scoreboard import Scoreboard

def run_game():
    #init game and screen
    pygame.init()
    si_settings = Settings()
    screen = pygame.display.set_mode((si_settings.screen_height, si_settings.screen_width))
    pygame.display.set_caption("Space Invaders")

    stats = GameStats(si_settings)
    ship = Ship(si_settings, screen)

    bullets = Group()
    aliens = Group()
    sb = Scoreboard(si_settings, screen, stats)
    #Make the play button
    play_button = Button(si_settings, screen, "Play")
    #Create the fleet!!
    gf.create_fleet(si_settings, screen, ship, aliens)

    #start the main loop for the game.
    while True:
        #watch for keyboard and mouse events
        gf.check_events(si_settings, screen, stats, sb, play_button, ship, aliens, bullets)
        
        if stats.game_active:
                ship.update()
                gf.update_bullets(si_settings, screen, stats, sb, ship, aliens, bullets)
                gf.update_aliens(si_settings, screen, stats, sb, ship, aliens, bullets)
                
        gf.update_screen(si_settings, screen, stats, sb, ship, aliens, bullets, play_button)
               
        
        if not stats.game_active:
                play_button.draw_button()

run_game()