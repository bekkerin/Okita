using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Vector3 vector = new Vector3(1, 2, 3);// create new vector (position) for the cylinder. This script is a component for the cylinder
        vector.x = 4.0f; // now it goes to x = 4 so vector is 4,2,3. YOu can similarly manipulate the y and z axes. If you make a public variable(float), you can also move the cyllinder with the inspector
        transform.position = vector;//set the transform/position of the cylinder to vector. You can see the cylinder shift to the right,up, and away as the scene loads.
        int i = new int(); //this is just some redundant code to show that primitive types (Plain Old Data) can technically be initialized with the new keyword too.
        Debug.Log(i);//prints the 0 value of the int to the console
    }
	
    // Update is called once per frame
    void Update()
    {

    }
}
