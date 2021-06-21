# TrabajoPracticoDSI

### 1 Hacer fork a este repositorio (Aparece arriba a la derecha)

### Crear una nueva carpeta donde queramos que esté el proyecto y realizar los siguientes pasos:
  - Click derecho en la carpeta (tratar de que sea una carpeta vacía) 
  - Git Bash Here
  
Luego ejecutamos los siguientes comandos en la terminal:
```bash
 git clone <url-de-su-repositorio> 
 cd TrabajoPracticoDSI 
 git remote add <unNombre> https://github.com/moradebianchetti/TrabajoPracticoDSI.git --> Agregamos este repositorio como remoto

```
Tener en cuenta:
 - Para la url de su repositorio es importante que sea el que esta en su cuenta y no el original. 
  Para saber cual es la url van a su perfil en GitHub > Repositorios > abren el ultimo > copian la dirección del navegador.
 - Verificar que aparezca "(main)" entre parentesis y en azul al lado del nombre del directorio 

## Si todo sale bien ejecutamos:
```bash
 git status
```
y debería salirnos que no hay cambios y que el árbol de trabajo está limpio

## Importante:
Antes de empezar a trabajar hay que verificar que no haya cambios que no tengamos en nuestra máquina
Para eso ejecutamos lo siguiente:

```bash
 git remote -v
```

Y debería figurarnos el nombre por el que hay que reemplazarlo a la izquierda de la url de este repositorio 
```
 ...
 unNombre https://github.com/moradebianchetti/TrabajoPracticoDSI.git (fetch)
 unNombre https://github.com/moradebianchetti/TrabajoPracticoDSI.git (push)
```

Entonces traemos los cambios del repositorio original
```bash
 git pull <unNombre> <nombreRama> 
```
### Aclaraciones Importantes
Es posible que Git nos pida que guardemos los cambios en un commit antes de hacer pull.
Esto pasa porque se necesita tener guardados nuestros cambios en el entorno local antes de
intentar traer y fusionar las cosas que están en el repositorio original

Para poder "guardar" los cambios en nuestra máquina necesitamos hacer un commit ejecutando los siguientes comandos
```bash
 git add .
 git commit -m "<UnMensajeAca>"
```


## Subir los cambios
Siempre que terminemos de hacer cambios ejecutamos los siguientes comandos:
```bash
 git add .
 git commit -m "UnMensajeAca"
 git push <tuNombre> main
```

#Tener en cuenta: 
-Para obtener tuNombre debes ejecutar
```bash
 git remote -v
``` 

Y debería figurarnos el nombre por el que hay que reemplazarlo a la izquierda de la url de TU repositorio 
 ````bash
 tuNombre <url-de-su-repositorio> (fetch)
 tuNombre <url-de-su-repositorio> (push)
 ````
 
Luego vamos a GitHub > Su Perfil > Repositorios > TrabajoPracticoDSI > Pull requests > New Pull request > Create Pull Request 

Una vez que se acepta el Pull request te llega un mail con la confirmacion y se actualiza el codigo para todos.

 
