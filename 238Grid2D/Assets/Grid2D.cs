using UnityEngine;
using System.Collections;

public class Grid2D : MonoBehaviour
{   //THIS SCRIPT IS ATTACHED TO THE (NEW) EMPTY GAMEOBJECT CALLED GAME
    //PUZZLEMATERIAL MUST BE ADDED IN INSPECTOR OF SPHERE IN THE SHADER SECTION OR THE SPHERES REMAIN BLACK.

	public int Width; //SET IN THE INSPECTOR AT 6
	public int Height; //SET IN THE INSPECTOR AT 6
    public GameObject PuzzlePiece; //SET IN THE INSPECTOR AS SPHERE
	private GameObject[,] Grid; //NOTICE THAT THIS ONE IS PRIVATE TO THE CLASS. TWO-DIMENSIONAL ARRAY OF GAMEOBJECTS (AND OF COURSE WE USE THE SPHERES AS PUZZLE PIECES.)

	// Use this for initialization
	void Start()
	{
		Grid = new GameObject[Width, Height];
		for (int x = 0; x < Width; x++)
		{
			for (int y = 0; y < Height; y++)
			{
				GameObject go =
					GameObject.Instantiate(PuzzlePiece) as GameObject;// PUZZLE PIECE IS A SPHERE AS DEFINED IN THE INSPECTOR FOR THE GAME
				Vector3 position = new Vector3(x, y, 0);
				go.transform.position = position;
				Grid [x, y] = go;
			}
		}
	}

	// Update is called once per frame
	void Update()
	{
		Vector3 mPosition = // mouse position
			Camera.main.ScreenToWorldPoint(Input.mousePosition);

		UpdatePickedPiece(mPosition);
	}
	
	void UpdatePickedPiece(Vector3 position)
	{
		
		int x = (int)(position.x + 0.5f); //SO WE CONNECT WITH CENTER OF SPHERES
		int y = (int)(position.y + 0.5f);//SO WE CONNECT WITH CENTER OF SPHERES

        for (int _x = 0; _x < Width; _x++)
		{
			for (int _y = 0; _y < Height; _y++)
			{
				GameObject go = Grid [_x, _y];
				go.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
 			}
		}
		
		if (x >= 0 && y >= 0 && x < Width && y < Height)//IF IT FALLS WITHIN THE GRID. CAPSULE AND CYLINDER DO NOT CHANGE COLOR.
		{
			GameObject go = Grid [x, y];
			go.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
		}
	}
}
