//this is a program with logic. we use the position of cubeA and cubeB to determine the color of the main cube. both cubeA and cubeB are public objects for the main cube. Be sure to add them from the hierarchy to the slots in the main cube's script component. Once you do, you can select one of the two cubes in the hierarchy and manipulate the x and y  values for its transform/position. When you do, and you move far enough, you can see the color of the main cube change. Try to shift the color first to black, then to cyan, then to green. By the way, is it ever possible to make the main cube red??

using UnityEngine;

public class Logic : MonoBehaviour
{
    public GameObject A_Cube;
    public GameObject B_Cube;

    // Use this for initialization
    void Start()
    {
	
    }
	
    // Update is called once per frame
    void Update()
    {
        Color col = Color.red;

        float Ax = A_Cube.transform.position.x;
        float Ay = A_Cube.transform.position.y;
        float Bx = B_Cube.transform.position.x;
        float By = B_Cube.transform.position.y;

        float d = Ax + Bx;

        if (Ax > Bx)
        {
            col = Color.black;
            if (d > 10.0f)
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
        }

        GetComponent<Renderer>().material.color = col;
    }
}
