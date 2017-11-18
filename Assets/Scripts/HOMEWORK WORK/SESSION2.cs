using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SESSION2 : MonoBehaviour {

    CustomClass cc = new CustomClass ();

    List<string> subjects = new List<string>() { "History", "Geography", "Social Sciences" };

    int TestNumber = 5;

    // Use this for initialization
    void Start () {

        print(cc.Health + "/" + cc.MaxHealth);

        print("Health " + cc.CurrentHealthPercent () + "%");
        
        switch (TestNumber)
        {
            case 1 :
                print(TestNumber);
                break;
            case 2 :
                print(TestNumber);
                break;
            case 5 :
                print(TestNumber);
                break;


        }
        
   


        //ConditionTest();

        TestingLoop();
    }

 
    // Update is called once per frame
    void Update () {
		
	}

    void ConditionTest()
    {
        //string name = "Anna";
        //string name = "Issa";

        //if (name == "Anna")

        

        {

       //     print("Name is Anna");
        }
       // else print("Name is not Anna");

        int power = 10;
        //int power = 0;

        bool isDrained = power <= 0;

        print("isDrained " + isDrained);

        //if (power <= 0)
        if (isDrained)

        {
            print("agent is drained");
        }
        else print("agent has power");

        string mode = isDrained == true ? "Game Over!" : "IsActive";

        print("Game mode" + mode);

            }

    void TestingLoop() {
        //for (int i = 0; i < 10; i ++)
        {
            //print("Loop " + i);
        }

        for (int i = 10; i > -1; i--)
        {
            print("Loop " + i);
        }

        foreach (string name in subjects)
        {
      
         print(name);
        }

       


    }

  }