using UnityEngine;
using System.Collections;

public class ClassScope : MonoBehaviour
{   // section 4-7 is really about order of operation but the code is different from book. material covers ordinary priority (*/+- etc).
	int ClassInt;
	
		void Start ()
		{
			int StartInt;
		
				for( int i = 0; i < 10; i++ )
				{
			
					Debug.Log( i );
			
				}
		}
	
		void Update ()
		{
			int UpdateInt;
                Debug.Log("new loop"); // make sure Clear on Play is on
		
				for( int i = 1000; i < 1010; i++ ) // instead of 0-10
				{
			
					Debug.Log( i );
			
				}		
		}
}
