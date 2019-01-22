using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//SETTING DEBUG POINTS DOES NOT APPEAR TO WORK WITH VISUAL STUDIO. Compare identical results without breakpoints and breakpoint at line 27. best thing to do may be to keep statements simple (no lines with multiple statements) and to use the line numbers in the Unity console for warnings and errors.
public class debugging : MonoBehaviour {

	// Use this for initialization
	void Start () {
        /*
        int a, b = 0; // warning: variable b is assigned but its value is never used
        Debug.Log(a); // error: use of unassigned local variable a
        */

        /*
        int a = 0, b = 0; // both initialized but not very readable
        Debug.Log(a + b); //works
        */

        int a = 0;
        int b = 4; // both initialized 
        Debug.Log(a + b); //works 4

        int c = a; int d = b; // works but hard to debug

        ArrayList list = new ArrayList();
        list.Add(1); // integer  1
        list.Add("this"); 
        list.Add(1.0); // double
        list.Add(2.0f); // float
        // lists can have anything in them
        foreach(int i in list)//InvalidCastException: Cannot cast from source type to destination type.
        {
            Debug.Log(i);  
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
