// If you make changes to the default values (in the Inspector) and save the scene, the changes will be saved to the script.To bring them back right click on the script’s component title bar and select [Reset] to revert the values to those declared in the script
//while the project is running, change OtherInt to 14 in the inspector. You will see that the value returns to 7 once you stop. Now change the value of OtherInt to 14 and you see the asterix * in the #Scene tab. Use Ctrl-S to save the scene, and OtherInt is now 14 in Inspector and 7 in code. You can go back to the original 7 by right clicking title bar of script in Inspector as described above. The value on line 9 never changes. The significance of this is that you can adjust values in the inspector, but you have to be careful with it.

using UnityEngine;

public class Example : MonoBehaviour
{
    public int SomeInt;
    public int OtherInt = 7;
	// Use this for initialization
	void Start()
	{
        Debug.Log(OtherInt);
	
	}

    // Update is called once per frame
    void Update ()
    {
        
    }
}
