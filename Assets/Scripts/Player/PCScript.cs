using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PCScript : MonoBehaviour {

    //Declare Variables
    [SerializeField]
    private Canvas computerCanvas;
    [SerializeField]
    private GameObject computer;
	
	// Update is called once per frame
	void Update ()
    {
        //Activate/ Deactivate when near PC AND not dead
	    if (transform.position.x - computer.transform.position.x > -1.9 && Bars.dead != true)
        {
            ActivatePC(computerCanvas);
        }
        else //Else disable PC canvas
        {
            DeActivatePC(computerCanvas);
        }
	}

    //Activate PC
    void ActivatePC(Canvas canvas)
    {
        canvas.gameObject.SetActive(true);
    }

    //Deactivate PC
    void DeActivatePC(Canvas canvas)
    {
        canvas.gameObject.SetActive(false);
    }
}
