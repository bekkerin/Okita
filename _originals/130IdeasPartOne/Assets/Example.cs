// this project starts with user input - in this case from the mouse. In the original the mouse controls the camera rotation, which is kind of silly since you really cannot see anything other than the transform-rotation of the camera changing in the inspector. 
// So I added three cubes to the project, and shifted the script to the cubes. Experiment by enabling different lines of code
using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
		// Use this for initialization
		void Start ()
		{
		
		}
	
		// Update is called once per frame
		void Update ()
		{
        Debug.Log(Input.mousePosition.x%36 + " " + Input.mousePosition.y%36 + " " + transform.rotation); //mod 36 so we see rotation in 10 degree increments in the console
        // this line will rotate the cube side to side (x) or twisting around (y)
        //transform.rotation = Quaternion.Euler (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0));                
        // this line will rotate the cube twisting around  (y) or side to side (y)
        transform.rotation = Quaternion.Euler (new Vector3 (0, Input.mousePosition.x, Input.mousePosition.y));
        // this line will rotate the cube forward backward (x) or twisting around (y)
        //transform.rotation = Quaternion.Euler (new Vector3 (Input.mousePosition.x, 0, Input.mousePosition.y));

    }
}
