using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {
    int MyNumber()
    {
        return 7;
    }
    int MyAdd(int a, int b)
    {
        return a + b;
    }
	// Use this for initialization
	void Start () {
        int a = MyNumber();
        print(a);
        int b = MyAdd(6, 7);
        print(b);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
