// Scope: where stuff works
// more professionally stated: where something is visible / accessible to other objects. we do have to be careful with naming conflicts.

using UnityEngine;

public class Scope : MonoBehaviour
{
		int MyInt = 1;

    void Start()
    {
        //Debug.Log(MyInt); // won't work because it is declared at the class level and again later on line 21. Message: " Cannot use local variable 'MyInt' before it is declared.The declaration of the local variable hides the field 'Scope.MyInt'.". if you comment out line 21, or remove the "int" in line 21, it will work because there is no longer a conflict.

        Debug.Log("printing the for loop");
        for (int i = 0; i < 10; i++)
        {
            print(i);
        }
        // i only exists between the { and }
        Debug.Log(this.MyInt); //class scope version of MyInt or 1
        int MyInt = 3;
        Debug.Log(MyInt); //Start scope version of MyInt or 3
    }
}
