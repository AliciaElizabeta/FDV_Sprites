# FDV_Sprites
Práctica de Scripts en Unity

Para esta práctica los sprites utilizados se encuentran en Assets/Sprites/Zombie y Assets/Sprites/Goblin respectivamente

Para mover al zombie se usa un transform.position y para saltar se usa el rigidbody

Para el zombie se han creado tres animaciones a partir de los sprites y para el goblin dos. Ambos cuentan con sus respectivas máquinas de estados. Las animaciones del zombie son iddle, dead, y move. Para el Goblin son iddle y attack.
Para girar el sprite en el movimiento se emplea la función flip

Para las colisiones se activan parametros en cada animación que activan sus respectivas animaciones
