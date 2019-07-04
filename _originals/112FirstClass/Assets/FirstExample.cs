// this program looks at functions, specifically the start and update functions.
// fun fact: if you check the console, you see that "start and "simple function is being called" are each done twice. Why is that???? answer is all the way at the bottom of this script.

using UnityEngine;
using System.Collections;
using System.IO;


public class FirstExample : MonoBehaviour
{
    class MyClass
    {
        public int num = 0;
        public void PrintNum()
        {
            Debug.Log(num);
        }
    }
    class AnotherClass
    {
        public int anotherNum = 1;
        public void PrintNum()
        {
            Debug.Log(anotherNum);
        }
    }
    void SimpleFunction()
    {
        Debug.Log("simple function is being called");
    }

    // Use this for initialization
    void Start()
    {
        Debug.Log("Start");
        SimpleFunction(); // message that simplefunction is called
    }


}











































// the script is twice attached to the camera, so there are two start functions.