using UnityEngine;
using System.Collections;

public class Example : MonoBehaviour
{
    public float sensitivity = 1.0f;
    // added some game objects to scene for demo purposes
	// Use this for initialization
	void Start ()
	{   
        // we don't need anything under start
	}
	
	// Update is called once per frame
	void Update ()
	{
    //right click on euler and then go to definition
    // Summary:
    //     Returns a rotation that rotates z degrees around the z axis, x degrees around
    //     the x axis, and y degrees around the y axis.
    //
    // Parameters:
    //   euler:

    transform.rotation = Quaternion.Euler (new Vector3 (sensitivity * Input.mousePosition.x, sensitivity * Input.mousePosition.y, 0));
    Debug.Log(Input.mousePosition); // look in inspector under rotation
	}
    // https://docs.unity3d.com/Manual/QuaternionAndEulerRotationsInUnity.html
    //In Unity all Game Object rotations are stored internally as Quaternions, because the benefits outweigh the limitations.
    //In the Transform Inspector however, we display the rotation using Euler angles, because this is more easily understood and edited.New values entered into the inspector for the rotation of a Game Object are converted “under the hood” into a new Quaternion rotation value for the object.

    //we attach this script as component to the main camera so we can use the mouse to rotate the camera. z axis is set to 0 so you can only rotate horizontally and vertically, not front/back.

    // all objects in the hierarchy are gameobjects. 

    //gameobjects have other classes as components, such as mesh filters, box colliders, and rigidbodies. 
}
