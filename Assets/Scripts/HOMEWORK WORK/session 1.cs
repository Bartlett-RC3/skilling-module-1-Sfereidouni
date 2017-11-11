//References
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Where code lives
public class SESSION1 : MonoBehaviour {

    //1.Variables
    //Scope -- Type -- Name -- Value

        //numbers
    public int myfirstintegermumber = 98; //Make sure you end with ;
    float Myfirstfloatnumber = 1.64f;


    //Text
   public string Myfirststring = "My text is here.";

    //Logical Variable
    bool myfirstboolean = true;


    //Data structures
    //Scope -- Type -- Values 

    //3.a.arrays
    public int[] myintegerArray = { 1, 2, 3, 4, 5 };
    public float[] myfloatArray = new float[5];




    //3.b.lists
    public List<int> myintegerlist = new List<int>();
    


    //2.functions

    //scope -- type -- variables --body (instructions)

    // Use this for initialization
    private void Start () {
        Debug.Log("addition of 5 and 3 is: " + AdditionOfNumbers(5, 3));
        myfloatArray[2] = 3.2f;
        myfloatArray[3] = 3.5f;
        myfloatArray[4] = 9.2f;

        myintegerlist.Add(1);
        myintegerlist.Add(2);
        myintegerlist.Add(3);

       

    }
	
    int AdditionOfNumbers(int Number1, int number2)
    { 

  int Additionresult = Number1 + number2;
    return Additionresult; 


	// Update is called once per frame
	void Update () {

            Debug.Log("Hello world!");
	}

