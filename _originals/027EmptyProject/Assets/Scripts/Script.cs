// this is just to demonstrate the functions Start and Update. Check the print statements in the console. You will see my name once, and "hello again" multiple times.
// before the script will work, be sure to attach it to an object in the scene you are using. there is only one scene, "untitled". You can attach the script to the main camera, for instance.

using UnityEngine;

public class Script : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Debug.Log("Ernst Bekkering");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("hello again");
    }
}