using UnityEngine;
using System.Collections;

   // MORE LIKELY, WE USE A DYNAMIC ARRAY FOR ZOMBIES:
    //          public Zombie[] MyZombies;
    // AND THEN DYNAMICALLY LOAD THE ARRAY DURING RUNTIME.

public class ArraysAFirstLook : MonoBehaviour
{
 	public GameObject[] MyGameObjects; //WE'LL USE THIS TO FIND ALL THE GAME OBJECTS
    public float[] DynamicFloats;

    void Start()
	{
        int arraySize = Random.Range(3,7); //  WE SET IT AT RUN TIME
        float[] DynamicFloats = new float[arraySize];
        Debug.Log(DynamicFloats.Length + " dynamic floats"); // so we can check the length

        for(int x = 0; x < arraySize; x++)
        {
            DynamicFloats[x] = 0.01f * Random.Range(0,100);
        }

        foreach(float f in DynamicFloats)// IT WILL NOT SHOW UP IN THE INSPECTOR, LENGTH STAYS 0, BECAUSE THE INSPECTOR CANNOT ADJUST THE ARRAY SIZE
        {
            print(f);
        }

        MyGameObjects = GameObject.FindObjectsOfType(typeof(GameObject)) as GameObject[]; //MAKE SURE IT IS PLURAL (FINDOBJECTSOFTYPE) SINCE IT IS AN ARRAY

        Debug.Log("Found " + MyGameObjects.Length + " game objects");

		foreach (GameObject go in MyGameObjects)
		{
			Debug.Log(go.name);
		}
	}
}