using UnityEngine;
using System.Collections;

public class Logic : MonoBehaviour
{
    //EXAMPLE OF NESTED IF STATEMENTS

    public GameObject A_Cube;
    public GameObject B_Cube;

    // Use this for initialization
    void Start()
    {
        //two cubes are added
	    //both cubes start at the center of the world
        //script is component for both cubes, not the camera.The cubes are what moves.
        // move the cubes with the transform position values in the inspector. We don't have inputs yet.
    }
	
    // Update is called once per frame
    void Update()
    {
        // color is red by default. if cube1 moves to left, color is blue. if cube1 is to right of cube2, both are black. Then, if both are to the right for combined >4, color is light blue (cyan). Then, if you move both up, color changes to green.
        Color col = Color.red;

        float Ax = A_Cube.transform.position.x;
        float Ay = A_Cube.transform.position.y;
        float Bx = B_Cube.transform.position.x;
        float By = B_Cube.transform.position.y;

        float d = Ax + Bx;

        if (Ax > Bx)
        {
            col = Color.black;
            if (d > 4.0f)
            {
                col = Color.cyan;
                float e = Ay + By;
                if (e > 1.0f)
                {
                    col = Color.green;
                }
            }
        } else if (Ax <= Bx)
        {
            col = Color.blue;
            if (d > 5.0f) // example of unreachable code - is not caught. see line 36
                col = Color.magenta; 
        }

        GetComponent<Renderer>().material.color = col;
    }
}
