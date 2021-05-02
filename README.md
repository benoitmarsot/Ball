# Ball
## Author: Benoit Marsot
![img1](https://raw.githubusercontent.com/benoitmarsot/Ball/master/Img/Main.png)
Ball is a #MRTK #Hololens2 ball application, the player push the ball and can control multiple parameters. also the ball can be control using a controller.

## Features:

 - Menu 
    - Gravity Slider 
    - Bounciness Slider 
    - Size Slider
    - Bring Ball
 - Game pad can be use to control the ball
 - The ball is deformed on collision
	 - The Cube sphere and deformation  by Jasper Flick from:
		 - https://catlikecoding.com/unity/tutorials/mesh-deformation/
- The collision with the hand is done through "HandSmashService" created by Joost van Schaik:
	- https://localjoost.github.io/HandSmashService-an-MRTK2-extension-service-to-smash-holograms-at-high-speed/

## Gameplay

 ![Image 1](https://raw.githubusercontent.com/benoitmarsot/Ball/master/Img/20210401_001624_HoloLens.jpg)

 
![Image 2](https://raw.githubusercontent.com/benoitmarsot/Ball/master/Img/20210403_010428_HoloLens.jpg)
![Image 3](https://raw.githubusercontent.com/benoitmarsot/Ball/master/Img/20210403_010500_HoloLens.jpg)
![Image 4](https://raw.githubusercontent.com/benoitmarsot/Ball/master/Img/20210403_010508_HoloLens.jpg)
![Image 5](https://raw.githubusercontent.com/benoitmarsot/Ball/master/Img/20210403_122232_HoloLens.jpg)
![Image 6](https://raw.githubusercontent.com/benoitmarsot/Ball/master/Img/20210403_122235_HoloLens.jpg)
![Image 7](https://raw.githubusercontent.com/benoitmarsot/Ball/master/Img/20210403_122244_HoloLens.jpg)

## To do
- Top menu icons doesn't work
- Use a better bounce sound
- Vertical joystick connection
- More sliders parameterization
- Make the new HandSmashService trigger the ball deformation.

## Done
- Fix buttons only tether click is working 
- Adjust the force when pushing the ball.
