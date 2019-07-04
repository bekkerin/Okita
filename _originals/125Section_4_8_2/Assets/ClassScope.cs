// this just shows scope of variables. the section in the book is really about making functions public, but that is not covered.

using UnityEngine;
using System.Collections;

public class ClassScope : MonoBehaviour
{
	int ClassInt;
	
		void Start ()
		{
			int StartInt;
            Debug.Log(ClassInt); // will work
		
			for( int i = 0; i < 10; i++ )
			{
			
				Debug.Log( i );
			
			}
            
		}
	
		void Update ()
		{
			int UpdateInt;
            //Debug.Log(StartInt); //won't work
		
			for( int i = 0; i < 10; i++ )
			{
			
				Debug.Log( i );
			
			}		
		}

 
}
