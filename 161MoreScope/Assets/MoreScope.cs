using UnityEngine;
using System.Collections;
public class MoreScope : MonoBehaviour
{
    //This project shows one gameobject controlling another.
    //MoreScope has been added as component to the main camera, and OtherScope has been added as component to the cube. In hierarch, select the camera and use the public OtherScale variable to control the size of the cube. This shows how you can control (the size of, in this case) of one gameobject - the cube - from another gameobject - the camera. If you disable the MoreScope script in the camera, you can directly control the size of the cube through Size in the OtherScope script.
	
		OtherScope other;
	
		// Use this for initialization
		void Start ()
		{
				other = (OtherScope)GameObject.FindObjectOfType (typeof(OtherScope));
				Debug.Log (other.gameObject.name);
		}
	
		// Update is called once per frame
		public float otherScale = 1.0f;
		void Update ()
		{
				other.Size = otherScale;
		}
}
