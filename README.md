# - Abyssal-Fight -

Abyssal Fight est un jeu de combat au tour par tour développé entièrement en C# avec l'interface WinForms. 
C'est un projet qui m'a permis de bien comprendre la logique de programmation orientée objet (POO) et la gestion d'états dans un jeu.

## - Comment ça marche ? -

Au début, vous verrez les ennemis que vous allez combattre ainsi que leurs statistiques (HP / DMG), le mode Facile Réduit leur HP/DMG.

Le choix de l'équipement : Avant de lancer le combat, vous choisissez votre équipement qui définit vos stats :

**- DMG : Vos dégâts d'attaque.**
**- HP : Votre barre de vie.**
**- DEF : Votre défense (réduit les dégâts reçus. Par exemple, 10 DEF = chaque coup reçu fait 10 DMG de moins).**

Le combat : Pendant le combat, vous avez plusieurs options :

Cliquer sur l'ennemi pour l'attaquer a hauteur de vos DMG.
Utiliser une action pour vous soigner.
Affaiblir l'ennemi (le Gobelin).

Vous gagnez quand tous les ennemis sont morts (actuellement, le jeu se joue sur un seul round).
