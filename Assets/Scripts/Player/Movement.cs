using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    //Declaring Variables
    [SerializeField]
    private float speed;

    [SerializeField]
    private Animator playerAnimator;
    private Rigidbody2D rb2d;
    private Transform playerTransform;


	// Use this for initialization
	void Start ()
    {
        //Initialise Variables
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
     
     //If released movement key "A"
     if (!Input.GetKey(KeyCode.A))
        {
            playerAnimator.SetBool("WalkingLeft", false); //Set animator bool to false
            rb2d.velocity = new Vector2(0, 0);
        }

     //If released movement key "D"
     if (!Input.GetKey(KeyCode.D))
        {
            playerAnimator.SetBool("WalkingRight", false);//Set animator bool to false
            rb2d.velocity = new Vector2(0, 0);
        }
	}

    private void LateUpdate()
    {
        //Left Movement
        if (Input.GetKey(KeyCode.A) && Sleeping.sleeping == false && ProcrastinationManager.isProcrastinating == false)
        {
            rb2d.velocity = new Vector3(-1 * speed, 0);
            playerAnimator.SetBool("WalkingLeft", true);//Set animator bool to true
        }

        //Right Movement
        if (Input.GetKey(KeyCode.D) && Sleeping.sleeping == false && ProcrastinationManager.isProcrastinating == false)
        {
            rb2d.velocity = new Vector3(1 * speed, 0);
            playerAnimator.SetBool("WalkingRight", true);//Set animator bool to true
        }
    }
}
