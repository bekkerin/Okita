using UnityEngine;
using System.Collections;

public class NumberTypes : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int a = 1;
		double b = 0.9;
        //int c = a * b; //does not work, Assets/NumberTypes.cs(10,17): error CS0266: Cannot implicitly convert type `double' to `int'. An explicit conversion exists (are you missing a cast?)
        int c = a * (int)b;//convert b to int, rounding down
        Debug.Log ( c ); // c is int 
		double d = a; //can load int into double if double has not initialized yet
		Debug.Log( d ); //1
		float f = a;// can load int into float if float has not initialized yet
		Debug.Log( f ); //1
		int largeInt = 214748361; //21 billion
        Debug.Log( largeInt );
        //int largeInt2 = 214748361000; // 21 billion  Assets/NumberTypes.cs(18,25): error CS0031: Constant value `214748361000' cannot be converted to a `int'
        long largeInt3 = 214748361000L;//need to make it a long
        Debug.Log(largeInt3);
        float largeFloat = largeInt;
		Debug.Log( largeFloat );
		int backAgain = (int)largeFloat;
		Debug.Log( backAgain );
		string s = "1";
		int fromString = int.Parse(s);//convert string to number
		Debug.Log( fromString );
        //where is this most important? vectors. They are initialized with floats for all dimensions, Not as doubles. If you just initialize with decimal numbers, they are going to be seen as doubles. You need to explicitly convert to floats.
        //Vector3 vec = new Vector3(1.0, 1.0, 1.0); // fails,   Assets/NumberTypes.cs(30,35): error CS1503: Argument `#1' cannot convert `double' expression to type `float'     
        Vector3 vec2 = new Vector3(1.0f, 1.0f, 1.0f); // works

        //BY THE WAY, NOTICE THAT THE LINE NUMBERS IN THE CONSOLE MESSAGE MATCH THE LINES IN THE CODE.
        // //RIGHT CLICK - PEEK DEFINITION, FIND ALL REFERENCES, OUTLINING
        float q= 10;
        float e = 5;
        float r = 3;
        Vector3 vec = new Vector3(q,e,r);

    }

    // Update is called once per frame
    void Update () {
	
	}
}
