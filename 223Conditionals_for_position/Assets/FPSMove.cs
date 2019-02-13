using UnityEngine;
using System.Collections;

//I CHANGED THE ASWD KEYS TO GO LEFT/RIGHT AND UP/DOWN FOR THE RED ZOMBIE
// THIS SCRIPT IS ATTACHED TO THE ZOMBIE. 
// THE SCRIPT TO CHECK POSITION IS IN RETURNZOMBIE ATTACHED TO THE CAMERA.

public class FPSMove : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
	
	}
	
	// Update is called once per frame
	public float speed = 0.1f; 
	void Update()
	{
        

		if (Input.GetKey(KeyCode.W))
		{
			transform.position += transform.up * speed; // += AND UP IS UP
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position -= transform.up * speed; // -= AND UP IS DOWN
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.position -= transform.right * speed; 
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.position += transform.right * speed;
		}


	}

}
