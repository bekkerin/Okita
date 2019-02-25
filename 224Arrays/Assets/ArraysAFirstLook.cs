using UnityEngine;
using System.Collections;
public class ArraysAFirstLook : MonoBehaviour
{
	public int[] scores = new int[5];
	public string[] strings = new string[5];
	public float[] floats = new float[5];

    // WE HAVE AN EMPTY CLASS HERE, JUST FOR DEMONSTRATION
    public class MyClass
	{
	}


	public MyClass[] MyClasses = new MyClass[5];// WE CAN CREATE AN ARRAY OF OBJECTS TOO
	public GameObject[] MyGameObjects;//THIS IS AN ARRAY OF BUILT-IN GAMEOBJECTS
	public int ArrayLength;// SO WE CAN SET THE LENGTH OF ARRAYS
	public int[] Primes = new int[]{ 1, 3, 5, 7, 11, 13, 17 };// YOU CAN SEE THESE IN THE INSPECTOR SINCE VALUES ARE GIVEN
	void Start()
	{
        ArrayLength = 5; // OR THE LENGTH IS 0
		float[] DynamicFloats = new float[ArrayLength];// HIDDEN BECAUSE THEY ARE NOT PUBLIC
		Debug.Log("NUMBER OF GAME OBJECTS: " + MyGameObjects.Length);
        // THE CONSOLE WILL TELL YOU ZERO BUT IT IS A PUBLIC ARRAY SO CHANGE THE SIZE OF THIS ARRAY IN THE INSPECTOR AND YOU CAN DRAG CUBES INTO THE ARRAY ELEMENTS
		for (int i = 0; i < MyGameObjects.Length; i++)
		{
			MyGameObjects [i].name = i.ToString();
		}
		foreach (GameObject go in MyGameObjects)
		{
			Debug.Log("CUBE " + go.name);
		}
		int[] scores = new int[10];
		int s = 0;
		while (s < 10)
		{
			scores [s] = Random.Range(0, 100);
			int score = scores [s]; //getting a value from the array
			print(score);
			s++;
		}
	}
}