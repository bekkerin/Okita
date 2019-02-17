using UnityEngine;
using System.Collections;

public class Scope : MonoBehaviour
{
		int MyInt = 1;
    public string MyName;


		void Start ()
		{
                //Debug.Log(MyInt); // won't work because it is at the class level. Cannot use local variable 'MyInt' before it is declared.The declaration of the local variable hides the field 'Scope.MyInt'.

                Debug.Log("printing the for loop");
                for (int i = 0; i < 10; i ++) {
						print (i);
				}
				// i only exists between the { and }
				Debug.Log (this.MyInt); //class scope version of MyInt or 1
				int MyInt = 3;
				Debug.Log (MyInt); //Start scope version of MyInt or 3
		}
}
