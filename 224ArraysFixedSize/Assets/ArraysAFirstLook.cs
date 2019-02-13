using UnityEngine;
using System.Collections;

//  THIS IS FOR FIXED SIZE ARRAYS
public class ArraysAFirstLook : MonoBehaviour
{
	public int[] scores = new int[5];
	public float[] floats = new float[5];
	int[] Primes = new int[]{ 1, 3, 5, 7, 11, 13, 17 };// THIS IS JUST AN EXAMPLE OF SETTING SIZE BY USING THE VALUES, WE DON'T USE IT.

	public class MyClass
	{
        //THERE IS NOTHING IN THE CLASS
	}
	public MyClass[] MyClasses = new MyClass[10];// WE TYPICALLY USE PLURAL ("MYCLASSES") FOR THE ARRAY AND SINGULAR (MYCLASS) FOR THE TYPE OF ARRAY. SO AN ARRAY MIGHT BE ZOMBIES[10] AND THE DATA TYPE ZOMBIE. YOU WOULD USE A STATEMENT LIKE
      //          public Zombie[] Zombies = new Zombie[10];

    void Start()
    {
        // FIRST THE INT ARRAY SCORES
        int s = 0;
        while (s < scores.Length)
        {
            scores[s] = Random.Range(0, 100);
            print(scores[s]);
            s++;
        }

        //ANOTHER WAY
        for (int t = 0; t < floats.Length; t++)
        {
            floats[t] = Random.Range(0, 100) * 0.01f;
        }
        foreach (float f in floats)
        {
            print(f);
        }
    }
 }