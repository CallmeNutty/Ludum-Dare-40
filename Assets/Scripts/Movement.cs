using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    //Declaring Variables
    [SerializeField]
    private float speed;

    private Rigidbody2D rb2d;


	// Use this for initialization
	void Start ()
    {
        //Initialise Variables
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
     //Left Movement
	 if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector3(-1 * speed, 0);
        }

     //Right Movement
     if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector3(1 * speed, 0);
        }
	}
}
