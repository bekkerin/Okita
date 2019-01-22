using UnityEngine;
using System.Collections;

// create the sphere with GameOBject - 3D - Sphere
// create this new script GameController and assign it as component of the sphere
public class SphereController : MonoBehaviour {
	public float Control;//shows up in Inspector
	public float OtherControl;// also shows in Inspector
	// Use this for initialization
	void Start () {
        //sphere starts in center of the world	
	}
	
	// Update is called once per frame
	void Update () {
        //we don't have to specify which object the transform belongs to. the script is a component of the spere, so it is the transform of the sphere. 
        // this is just the general declaration of the transform. Notice that the y is 2 x control, and z is control * control
        //transform.position = new Vector3 (Control, Control + Control, Control * Control);

        // you can also declare it as statement on separate lines for clarity
        // the book code is a somewhat difficult path to follow in play due to sin and cos
        //transform.position = new Vector3 (
        //Control,
        //Control + Control,
        //Control * Control);

        //this is probably the clearest way to define it - with separate variables.
        float x = Control;
        float y = Control + Control;
        float z = Control * Control;
        transform.position = new Vector3(x, y, z);        
        
        // now go to the other object (sphere or capsule) with the same script attached. It works the same - except capsule will jump to center of world initially.

    }
}
