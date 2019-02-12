using UnityEngine;
using System.Collections;

//THIS SCRIPT COVERS THE MOUSE INPUT - ROTATION SO YOU CAN "AIM" THE DIRECTION OF THE GAMEOBJECT.

// INTERNALLY, ROTATIONS ARE STORED AS QUATERNIONS - INPUT VECTORS WITH FOUR VALUES. THE PROPERTY transform.eulerAngles STORES THE EULER ANGLES IN THE XYZ DIMENSIONS WE ARE USED TO. WE NOW SIMPLY USE Input.GetAxis("Mouse X") ETC.

//IF YOU DON'T SEE ANYTHING AT START, MOVE BACK WITH THE S KEY TO ZOOM OUT.

public class FPSAim : MonoBehaviour
{
    public float mouseX; //I CHANGED THIS TO PUBLIC SO YOU CAN SEE VALUES IN INSPECTOR
	public float mouseY; //I CHANGED THIS TO PUBLIC SO YOU CAN SEE VALUES IN INSPECTOR
    public bool InvertedMouse;

 	void Update()
	{
        //THERE ARE OTHER INPUTS. START TYPING Input. AND LOOK FOR compas, compensateSensors, gyro, inputstring, touches etc - all with wrench indicating functions.
        //Input.

        //IF YOU GO TO EDIT - PROJECT SETTINGS - INPUT AND EXPAND THE INPUTMANAGER IN THE INSPECTOR, YOU SEE MANY DIFFERENT INPUT COMPONENTS. MOUSEX (EXPAND) IS TYPE MOUSE MOVEMENT, BUT THE DROPDOWN ALSO HAS JOYSTICK AXIS. 

        /*
        // MORE DIFFICULT METHOD - SYNTACTICALLY SOUND
		Vector3 mousePosition = Input.mousePosition; //get the mouseposition from inputManager
		Debug.Log(mousePosition); //show it in the consolde
		mouseX = mousePosition.x; // separate off the x component (declared at top)
		mouseY = mousePosition.y; // separate off the y component (declared at top)
        transform.eulerAngles = new Vector3(mouseX * 0.1f, mouseY * 0.1f, 0); // assign the x and y to the transform of the device that has this script as component. WITH THIS SEQUENCE OF PARAMETERS (X,Y,Z) YOU GET A REALLY WEIRD EFFECT. i HAD TO MOVE THE MOUSE ALL THE WAY TO THE LEFT TO LIFT TO THE HORIZON, AND MOVE UP AND DOWN TO ROTATE LEFT AND RIGHT - VERY COUNTER INTUITIVE. THIS IS PROBABLY DUE TO THE 0 0 0 0 POSITION OF EULER ANGLES.	
        //transform.eulerAngles = new Vector3(mouseY * 0.1f, mouseX*0.1f, 0); //THIS HAS THE X AND Y REVERSED, BUT GIVES NORMAL LEFT RIGHT UP DOWN BEHAVIOR.
         */



         //EASIER WAY
         mouseX += Input.GetAxis("Mouse X"); // X AXIS MOVES LEFT RIGHT AS EXPECTED. 
        // IF INVERTEDMOUSE IS FALSE, THE OBJECTS MOVE DOWN IF WE MOVE THE MOUSE UP. JUST CHANGE THE VALUE IN THE INSPECTOR. MOST PEOPLE PROBABLY PREFER TO MOVE THE OBJECTS DOWN IF THE MOUSE MOVES DOWN AND MOVE UP IF THE MOUSE MOVES UP, BUT APPARENTLY THERE ARE SOME  PEOPLE WHO LIKE THE REVERSE. 
         if (InvertedMouse)
         {
             mouseY += Input.GetAxis("Mouse Y"); //IF INVERTEDMOUSE IS CHECKED OR TRUE, MOVE ME UP WHEN THE MOUSE MOVES UP.
         } else
         {
             mouseY -= Input.GetAxis("Mouse Y");
         }
         transform.eulerAngles = new Vector3(mouseY, mouseX, 0); //THE POSITION/TRANSFORM OF THE OBJECT TO WHICH THE SCRIPT IS ATTACHED.


    }
    //CYLINDERS ARE  ADDED TO SHOW THAT THE MOUSE POSITION IS A 2D DEVICE AND THAT THE VALUES ARE IN DEGREES. THE CAMERA IS AT 0 0 -10 SO 10 SET BACK FROM CENTER OF THE WORLD. I PLACED RED CYLINDERS AT 10 0 -10 AND -10 0 -10. IF YOU MOVE THE MOUSE FAR TO THE LEFT YOU WILL SEE THAT THE LEFT RED CYLINDER IS IN THE CENTER OF THE PICTURE WHEN THE ROTATION IS 90. 



}
