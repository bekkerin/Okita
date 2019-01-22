using UnityEngine;
using System.Collections;
using System;
public class MultiDimensionalArray : MonoBehaviour {
	public GameObject[] oneDArray;
	public GameObject[,] mArray;
	// Use this for initialization
void Start () {

	GameObject a = new GameObject("GameObject_A");
	GameObject b = new GameObject("GameObject_B");
	GameObject c = new GameObject("GameObject_C");
	GameObject d = new GameObject("GameObject_D");
	GameObject e = new GameObject("GameObject_E");
	GameObject f = new GameObject("GameObject_F");
	GameObject[,] twoDimension = new GameObject[2,3]{ {a, b, c} , {d, e, f} };
	GameObject[,,] threeDimension = new GameObject[4,3,2]
		{
			{  {a,b} ,{c,d}, {e,f}  },
			{  {a,b} ,{c,d}, {e,f}  },
			{  {a,b} ,{c,d}, {e,f}  },
			{  {a,b} ,{c,d}, {e,f}  }
		};
	
	InspectArray( twoDimension );
        Inspect3DArray(threeDimension);
}

    void InspectArray(GameObject[,] gos)
    {

        int columns = gos.GetLength(0);
        Debug.Log("Columns: " + columns);

        int rows = gos.GetLength(1);
        Debug.Log("Rows: " + rows);

        for (int c = 0; c < columns; c++)
        {
            for (int r = 0; r < rows; r++)
            {
                Debug.Log(gos[c, r].name);
            }
        }
    }
    void Inspect3DArray(GameObject[,,] gos)
    {

        int columns = gos.GetLength(0);
        Debug.Log("Columns: " + columns);

        int rows = gos.GetLength(1);
        Debug.Log("Rows: " + rows);

        int depth = gos.GetLength(2);
        Debug.Log("Depth: :" + depth);

        for (int c = 0; c < columns; c++)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int d = 0; d < depth; d++)
                {
                    Debug.Log(gos[c, r,d].name + " at " + c + r + d);
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
