// this script is attached to the camera, the other script to the cube. Notice that the classes are public.

using UnityEngine;
using System.Collections;
public class MoreScope : MonoBehaviour
{
	
		OtherScope other;
		public float otherScale;
	
		// Use this for initialization
		void Start ()
		{       // this finds the name of the object to which the OtherScope script is attached - the cube  - and prints it to the console. The problem is that OtherScale is not initialized. By default it is 0, and you can see this in the inspector for the camera. Effectively, it hides the cube until you set OtherScale greater than 0. We'll just initialize it her in line 15, but you can change it in the camera inspector too and see the cube shrink or swell.
				other = (OtherScope)GameObject.FindObjectOfType (typeof(OtherScope));
				Debug.Log (other.gameObject.name);
                //otherScale = .1f; // if you want to give it a fixed value
                otherScale = GameObject.FindGameObjectWithTag("MainCamera").transform.localScale.x; // this gives it the same scale as the main camera.
		}
	
		// Update is called once per frame
		void Update ()
		{
				other.Size = otherScale;// every frame, the scale of the cube is adjusted to the scale of the camera. Other is the cube.
		}
}
