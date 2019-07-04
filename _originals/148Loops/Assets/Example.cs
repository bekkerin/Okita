using UnityEngine;
//EXAMPLE OF FOR LOOP, WHILE LOOP, AND CREATION OF OBJECTS AT RUNTIME
//camera  rotation  0 10 0  to see them all
public class Example : MonoBehaviour
{

    public int numFrames = 0;
    public int numCubes = 3;
    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < numCubes; i++)
        {
            for (int j = 0; j < numCubes; j++)
            {
                GameObject box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                box.transform.position = new Vector3(i * 2.0f, j * 2.0f, 0f);
                box.name = "Cube_" + i + "_" + j; // to keep track, see hierarchy during runtime
                // Summary of createprimitive:
                //     Creates a game object with a primitive mesh renderer and appropriate collider.
                //
                // Parameters:
                //   type:
                //     The type of primitive object to create.

                //definition of primitivetype:
                // public enum PrimitiveType where sphere = 0, capsule = 1, etc.
            }
        }
        Debug.Log("at the start");
        for (; ; ) //this is just a demo that a for loop will stop at the break and not resume
        {
            Debug.Log("before the return");
            break; //not return!
            Debug.Log("after the return"); // is unreachable due to break
        }
        Debug.Log("at the bottom");

    }
    // Update is called once per frame
    void Update()
    {
        int counter = 0;
        while (true)
        {
            counter++;
            if (counter > 10)
            {
                break;
            }
        }
        numFrames += 1; // see increase in inspector since numFrames is public int. It keeps running.
    }
}

