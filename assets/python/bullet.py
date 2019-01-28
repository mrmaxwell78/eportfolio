import pygame
from pygame.sprite import Sprite

class Bullet(Sprite):
    #Class to manage bullets

    def __init__(self, si_settings, screen, ship):
        #Create bullet object at ship's current position
        super(Bullet, self).__init__()
        self.screen = screen
        
        #Create bullet rect at (0,0) and then set correct position
        self.rect = pygame.Rect(0, 0, si_settings.bullet_width, si_settings.bullet_height)
        self.rect.centerx = ship.rect.centerx
        self.rect.top = ship.rect.top
        #Store bullet's position as decimal value
        self.y = float(self.rect.y)

        self.color = si_settings.bullet_color
        self.speed_factor = si_settings.bullet_speed_factor

    def update(self):
        #move the bullet up the screen
        #update the decimal position
        self.y -= self.speed_factor
        #update rect position
        self.rect.y = self.y

    def draw_bullet(self):
        #draw bullet to the screen
        pygame.draw.rect(self.screen, self.color, self.rect)
    