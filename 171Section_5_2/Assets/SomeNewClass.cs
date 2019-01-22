using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ALL SIX SCRIPTS LIKE AIMCONTROLLER ARE EMPTY AND JUST FOR DEMONSTRATION.
//Keep your classes as small as possible. Once it gets larger, try to break up class into smaller specialized classes. 
//below is just the code from the book; not very relevant
public class SomeNewClass : MonoBehaviour {

    int MyFunction(int n)
    {
        return n;
    }
    // Use this for initialization
    void Start() {
        Debug.Log(MyFunction(7));
    }

    // Update is called once per frame
    void Update() {
       
	}
}
