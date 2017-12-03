using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimeSystem : MonoBehaviour
{

    //Declare Variables
    [SerializeField]
    private Text timeText;
    [SerializeField]
    private Animator window;
    [SerializeField]
    private Light windowLight;

    [SerializeField]
    private float gameSpeed;    
    private float time;
    public static int realTime;
    public static string day;

	// Use this for initialization
	void Start ()
    {
        //Initialise Variables
        realTime = 23;
        day = "Friday";
    }
	
	// Update is called once per frame
	void Update ()
    {
        //gameCounter affected by gameSpeed variable and deltaTime
        time += 1 * gameSpeed * Time.deltaTime;

        //If gameTimer has reached 1
        if (time > 1)
        {
            realTime++; //1 hour forward
            time = 0; //Reset gameTimer

            if (Sleeping.sleeping == true)
            {
                Sleeping.sleepDone++;
            }
        }

        //If it is daytime
        if (realTime > 6 && realTime < 18)
        {
            window.SetBool("DayTime", true); //Set bool "is daytime" true
            windowLight.intensity = 6.3f;
            windowLight.range = 62;
        }
        else
        {
            window.SetBool("DayTime", false);//Set bool "is daytime" false
            windowLight.intensity = 0;
            windowLight.range = 0;
        }

        //Change timeText according to current time and day
        timeText.text = String.Format ("{0}:00 {1} ", realTime, day);

        if (realTime > 23)
        {
            realTime = 0; //Change time back to 1:00
            
            //Change days according to current day
            if (day == "Friday") { day = "Saturday"; } //Fr to Sa
            else if (day == "Saturday") { day = "Sunday"; } //Sa to Sun
            else if (day == "Sunday") { day = "Monday"; } //Sun to Mon
        }
        
	}
}
