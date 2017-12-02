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
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
	 if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector3(-1 * speed, 0);
        }

     if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector3(1 * speed, 0);
        }
	}
}
