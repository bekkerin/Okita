//this script is attached to the cube, the other script MoreScope is attached to the camera. Notice that the classses are public.
// this script is attached to the cube, and it might make more sense to use the size of the camera object from here. So, put the findobjectwithtag code in this script.
using UnityEngine;
using System.Collections;

public class OtherScope : MonoBehaviour {
	
	public float Size;
	Vector3 mScale; //m is short for "my"
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		mScale = new Vector3( Size, Size, Size); // Size comes from the MoreScope script attached to the camera.
		gameObject.transform.localScale = mScale;
	}
}
