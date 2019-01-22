//#define TESTING  //if you uncomment, the #if testing section executes. Use it for checking during development, then simply comment TESTING at top when done.

using System; //provides int, bool, float, double, etc. 
using UnityEngine; //All resources that deal with specific Unity function calls like moving an object , playing sounds, and particle systems
using System.Collections;
using UnityEngine.UI; //provides User Interface elements like textbox, button, scrollbar
using System.IO;  //for file writing and reading. try commenting this line

// free version of Unity only allows System and UnityEngine

/* How to find the library for a specific funtion:
 * in Solution Expolorer, expand the References and click on any of the references
 * this opens the Object Browser window
 * in the Search box, enter streamwriter
 * you find it - among others - in System.IO  */



public class Preprocessor : MonoBehaviour
{
	// Use this for initialization
	
	void Start()
	{
		#if TESTING
		Debug.Log("just testing");
		#endif
		Debug.Log("normal behavior");

        // first delete myfile.txt from the assets in solution explorer
        StreamWriter writer = new StreamWriter("myfile.txt");
        writer.WriteLine("This is my new text file");
        writer.Flush(); // flush the write buffer
        //myfile.txt now shows up in the main folder for the project
        writer.Close();
        StreamReader reader = new StreamReader("myfile.txt");
        string contents = reader.ReadToEnd(); //now read the contents
        Debug.Log(contents); //file contents show in console
        reader.Close();

        //ambiguous function names:
        //int RandomNumber = Random.range(0, 5); // won't work because random is both in unityengine and system libraries.         Error CS0104  'Random' is an ambiguous reference between 'UnityEngine.Random' and 'System.Random' 
        int RandomNumber2 = UnityEngine.Random.Range(0, 5); // works



    }

 
}
