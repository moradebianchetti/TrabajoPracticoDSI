# TrabajoPracticoDSI

### 1 Hacer fork a este repositorio (Aparece arriba a la derecha)

### 2 Una vez hecho el fork en el directorio donde queramos que esté el proyecto ejecutamos los siguientes comandos en la terminal

(Click derecho en la carpeta del tp, tratar de que si o si estar en una carpeta vacía) > Git Bash Here):

```bash
 git clone <url-de-su-repositorio> 
 cd TrabajoPracticoDSI !-- Importante verificar que aparezca "(main)" entre parentesis y en azul al lado del nombre del directorio 
 git remote add main https://github.com/moradebianchetti/TrabajoPracticoDSI.git --> Agregamos este repositorio como remoto

```

para la url de su repositorio es importante que sea el que esta en su cuenta y no el original. 
Para saber cual es la url van a su perfil en GitHub > Repositorios > abren el ultimo > copian la dirección del navegador

## Si todo sale bien ejecutamos:
```bash
 git status
```
y debería salirnos que no hay cambios y que el árbol de trabajo está limpio

## Importante:
Antes de empezar a trabajar hay que verificar que no haya cambios que no tengamos en nuestra máquina
Para eso ejecutamos lo siguiente:
```bash
 git pull upstream main 
```

Es posible que "upstream" sea distinto en la máquina de cada uno
para estar seguros de que nombre hay que reemplazar en lugar de upstream ponemos
```bash
 git remote -v
```

Y debería figurarnos el nombre por el que hay que reemplazarlo a la izquierda de la url de este repositorio 
```
 ...
 unNombre https://github.com/JoaquinGomez1/Aerolinea-PAV1-GP07 (fetch)
 unNombre https://github.com/JoaquinGomez1/Aerolinea-PAV1-GP07 (push)
```
Algo asi deberia aparecernos 


### Aclaraciones Importantes
Es posible que Git nos pida que guardemos los cambios en un commit antes de hacer pull.
Esto pasa porque se necesita tener guardados nuestros cambios en el entorno local antes de
intentar traer y fusionar las cosas que están en el repositorio original

Para poder "guardar" los cambios en nuestra máquina necesitamos hacer un commit ejecutando los siguientes comandos
```bash
 git add .
 git commit -m "<UnMensajeAca>"
```

Siempre que terminemos de hacer cambios ejecutamos los siguientes comandos:
```bash
 git add .
 git commit -m "UnMensajeAca"
 git push 
```

Luego vamos a GitHub > Su Perfil > Repositorios > Aerolinea-PAV1-GP07-1 > Pull requests > New Pull request > Create Pull Request 

Una vez que se acepta el Pull request te llega un mail con la confirmacion y se actualiza el codigo para todos.
Nota: 
 Todos los del grupo podemos aceptar cualquier pull request en el repositorio original
 
 #### Remover Archivos Binarios
```bash
git rm -r .vs
git rm -r ./TrabajoPrácticoPAV/.vs
git rm -r ./TrabajoPrácticoPAV/obj
git rm -r ./TrabajoPrácticoPAV/bin
```
