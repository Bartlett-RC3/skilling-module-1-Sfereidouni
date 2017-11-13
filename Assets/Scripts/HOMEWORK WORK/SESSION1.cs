using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SESSION1 : MonoBehaviour {

    public string text = "SESSION1";
    public bool TurnOn = true;
    public float PositionX = 3.2f;
    public int IntTest = 3;

    List<string> subjects = new List<string>() { "History", "Geography", "Social Sciences"};

     string[] names = new string[]{"Sarah", "Lee"};

    public Dictionary<string, string> cars = new Dictionary<string, string> ();




	// Use this for initialization
	void Start () {

        subjects.Add("Arts");

        //once arts is removed, the last subject becomes social sciences again.
        subjects.Remove("Arts");

        //names[0] = "Sarah";

        //text = Test("Calling test 2()"); //"Updated During Start()";

        //this is with no space between first and last name
        //print (names[0]+names[1]);

        //this is with space between first and last name
        print (names[0]+" " + names[1]);

        print("total names" + names.Length);

        print("total subjects " + subjects.Count);
        print("subject 1 " + subjects[0]);
        print("subject 2 " + subjects[1]);
        print("subject 3 " + subjects[2]);

        print("Last subject " + subjects [subjects.Count-1]);

        cars.Add("place 1", "BMW");
        cars.Add("place 2", "Toyota");

        print("car in place 1 " + cars ["place 1"]);
        print("car in place 2 " + cars["place 2"]);
    }

    // Update is called once per frame
    void Update () {
		
	}

    string Test (string value) {
        return value + " Hello Unity";
    }
}
