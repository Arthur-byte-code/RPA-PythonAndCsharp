import pyautogui

import time

time.sleep(6)
# Obtém a posição atual do cursor
posicao_cursor = pyautogui.position()

# Imprime as coordenadas x e y
print(posicao_cursor)
