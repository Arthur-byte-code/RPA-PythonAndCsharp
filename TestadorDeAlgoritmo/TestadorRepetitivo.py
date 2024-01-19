import time
import pyautogui
import random
import locale
# Configurar o locale para usar vírgula como separador decimal
locale.setlocale(locale.LC_NUMERIC, 'Portuguese_Brazil.1252')

pyautogui.click(x=643, y=871)#este click é para clicar no visual studio code
# Define o intervalo em metros
limite_inferior = 1.6
limite_superior = 2.2

pyautogui.press("f5")# executar o algoritmo c# no visual studio code
time.sleep(6)

#loop que digita 30 vezes
for _ in range(30):
    valor_em_metros = round(random.uniform(limite_inferior, limite_superior), 2)# valores aleatórios dentro de um intervalo atribuidos a uma variavel
    # Converta o número para uma string usando o locale atual
    valor_em_metros_str = locale.str(valor_em_metros)
    pyautogui.write(valor_em_metros_str)
    pyautogui.press("enter")