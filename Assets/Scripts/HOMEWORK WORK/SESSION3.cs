using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SESSION3 : MonoBehaviour
{
    public GameObject Cube;
    public GameObject Sphere;
    public Material Colors;
    public Renderer rend;
    int counter = 0;
    bool moveUp = true;

    bool moveDown = false;





    // Use this for initialization
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;


    }

    // Update is called once per frame
    void Update()

    {

        if (moveUp == true)

        {

            if (counter <= 10)

            {

                gameObject.transform.Translate(Vector3.up);

                counter++;

            }

            else

            {

                moveUp = false;

                moveDown = true;

                counter = 0;

            }

        }

        if (moveDown == true)

        {

            if (counter <= 10)

            {

                gameObject.transform.Translate(Vector3.down);

                counter++;

            }

            else

            {

                moveUp = true;

                moveDown = false;

                counter = 0;
                if (Input.GetMouseButtonDown(0))
                {
                    rend.material.color = Color.blue;
                }

            }

        }
    }
}
    
//Another Way of moving things on the screen...
            
            
    /*
                    if (Input.GetKeyDown(KeyCode.Space))
            {
                this.transform.Translate(transform.right);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {

            }
        }*/


