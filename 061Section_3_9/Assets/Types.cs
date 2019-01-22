using UnityEngine;
using System.Collections;

public class Types : MonoBehaviour {
    // a class is a collection of instructions and data. the instructions can be referred to as functions or methods. the data stored in a class is called a field or property.
    // instancing: you can create more than one object of a class. Each object is another instance of the class.
    //encapsulation: how classes hide data and functions. If you create a property or function, and you don't specify that it is public, it is private to the class and anything outside does not have access to it. If you declare it public, it can be used outside the class. Public variables show up in the inspector. 
    // numeric variables in the inspector can be changed with the keyboard, or you can select the field, move slightly to the left of the box, and drag left or right to decrease and increase.
    // inheritance allows multiple classes to share common attributes and behaviors. For instance, both humans and dogs can share a movement controller script.
    // aggregation means that you can combine multiple classes into a single class. 
    // you still need to associate a  script with one or more objects before you can use it. Simpley drag the script from the assets to the inspector, or use "add component". 
    //Don't forget to save the script before you try to use the new version.
    // the sphere's location is a variable called the transform.position.//to make it easier to find a "lost" object: select it in the hierarchy, right click on the transform, and click Reset. It brings it back to the center of the world (0,0,0).
    //the 

    int SomeNumber; // makes it private to the class by default
    private int PrivateNumber;// explicit private, by default has value 0
    public int PublicNumber; // notice how inspector separates the two words. Has defaulty initialization of 0
    public int PublicNumber2 = 10; //dynamic initialization (not the default value). Check the value in the inspector.

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
