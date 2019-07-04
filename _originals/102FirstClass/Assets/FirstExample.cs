// this program addresses the use of external libraries. we include them with the statement using (whatever). in this case, we use system.io to work with files because the filewriter and filereader are in the IO library.
// after you run the program, look for the file myfile.txt in the root folder of the project. It will not be in the assets. We will address that later in the course; in order to make it part of the assets you will have to use a different path to include it in the assets folder and then update the assets list.
//also check the console output.

using UnityEngine;
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








