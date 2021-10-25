# Práctica 2


### Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo.


* **Ninguno de los objetos será físico.**

Al no ser físicos, los objetos no son afectados por la gravedad.
<div align="center">
  <br>
  <img src="img/1a.png" alt="Markdownify">
  <br>
  <br>
</div>


* **La esfera tiene físicas, el cubo no.**

Como la esfera es física, es afectada por la gravedad y cae hasta que choca con el plano.
<div align="center">
  <br>
  <img src="img/1b.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **La esfera y el cubo tienen físicas.**

Al ser físicos los objetos caen contra el plano.
<div align="center">
  <br>
  <img src="img/1c.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo.**

La masa no afecta a la velocidad de caida, imaginamos que le coeficiente de rozamiento es nulo.
<div align="center">
  <br>
  <img src="img/1d.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **La esfera tiene físicas y el cubo es de tipo IsTrigger.**

Para comprobar que la esfera es física y el cubo no, he colocado la esfera por encima del cubo, al iniciar la simulación la esfera cae atravesando el cubo mientras que este se queda en su posición.
<div align="center">
  <br>
  <img src="img/1e.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **La esfera tiene físicas, el cubo es de tipo IsTrigger y tiene físicas.**

Ambos objetos caen, pero como el cubo es de tipo IsTrigger en lugar de chocar contra el plano lo atraviesa.
<div align="center">
  <br>
  <img src="img/1f.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ.**
<div align="center">
  <br>
  <img src="img/1g.gif" alt="Markdownify">
  <br>
  <br>
</div>


---


### Sobre la escena que has trabajado ubica un cubo que represente un personaje que vas a mover. Se debe implementar un script que haga de CharacterController. Cuando el jugador pulse las teclas de flecha (o aswd) el jugador se moverá en la dirección que estos ejes indican.


* **Crear un script para el personaje que lo desplace por la pantalla, sin aplicar simulación física.**
<div align="center">
  <br>
  <img src="img/2a.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **Agregar un campo público que permita graduar la velocidad de movimiento desde el inspector de objetos.**
<div align="center">
  <br>
  <img src="img/2b.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **Elegir otros ejes virtuales para el girar al jugador sobre el oeje OY (up)**

Teclas Q y E para rotar a izquierda y derecha respectivamente.
<div align="center">
  <br>
  <img src="img/2c.gif" alt="Markdownify">
  <br>
  <br>
</div>


---


### Sobre la escena que has trabajado programa los sripts necesarios para las siguientes acciones: 


* **Se deben incluir varios cilindros sobre la escena. Cada vez que el objeto jugador colisione con alguno de ellos, deben aumenar su tamaño y el jugador aumentar puntuación**
<div align="center">
  <br>
  <img src="img/3a.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **Aggregar cilindros tipo A, en los que además, si el jugador pulsa la barra espaciadora lo mueve hacia fuera de él.**
<div align="center">
  <br>
  <img src="img/3b.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **Se deben incluir cilindros que se alejen del jugador cuando esté próximo.**
<div align="center">
  <br>
  <img src="img/3c.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **Ubicar un tercer objeto que sea capaz de detectar colisiones y que se mueva con las teclas I, L, J, M.**
<div align="center">
  <br>
  <img src="img/3d.gif" alt="Markdownify">
  <br>
  <br>
</div>


* **Debes ubicar cubos que aumentan de tamaño cuando se le acerca una esfera y que disminuye cuando se le acerca el jugador.**
<div align="center">
  <br>
  <img src="img/3e.gif" alt="Markdownify">
  <br>
  <br>
</div>
