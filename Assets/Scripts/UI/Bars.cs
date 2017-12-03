using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Bars : MonoBehaviour
{
    //Declare Variables
    public static bool dead;
    public double energyMultiplier;
    public double interestMultiplier;
    public double energyCap = 1;

    [SerializeField]
    private AudioSource music;
    [SerializeField]
    private AudioSource death;
    [SerializeField]
    private Canvas computer;
    public Image energyBar;    
    public Image interestBar;
    [SerializeField]
    private Image deathScreen;
    [SerializeField]
    private Image boredScreen;
    [SerializeField]
    private Image winScreen;
    [SerializeField]
    private Text finalScoreE;
    [SerializeField]
    private Text finalRankE;
    [SerializeField]
    private Text finalScoreI;
    [SerializeField]
    private Text finalRankI;
    [SerializeField]
    private Text finalScoreW;
    [SerializeField]
    private Text finalRankW;


    // Update is called once per frame
    void Update()
    {
        //Gradually decrease bars
        energyBar.fillAmount -= 0.001f * (float)energyMultiplier;
        interestBar.fillAmount -= 0.001f * (float)interestMultiplier;

        if (energyBar.fillAmount > energyCap)
        {
            energyBar.fillAmount = (float)energyCap;
        }

        //If out of Energy
        if (energyBar.fillAmount == 0)
        {
            finalScoreE.text = "Your Final Score: " + ProcrastinationManager.slackingPoints; //Write Final Score
            finalRankE.text = "Your Final Rank: " + ProcrastinationManager.currentRank; //Write Final Rank
            music.Stop();
            death.Play();

            OutOfEnergy(deathScreen, computer); //Show death screen and pause game
        }

        //If bored
        if (interestBar.fillAmount == 0)
        {
            finalScoreI.text = "Your Final Score: " + ProcrastinationManager.slackingPoints; //Write Final Score
            finalRankI.text = "Your Final Rank: " + ProcrastinationManager.currentRank; //Write Final Rank
            music.Stop();
            death.Play();

            OutOfEnergy(boredScreen, computer); //Show death screen and pause game
        }

        //If Won
        if (TimeSystem.day == "Monday")
        {
            finalScoreW.text = "Your Final Score: " + ProcrastinationManager.slackingPoints; //Write Final Score
            finalRankW.text = "Your Final Rank: " + ProcrastinationManager.currentRank; //Write Final Rank

            OutOfEnergy(winScreen, computer); //Show death screen and pause game
        }
    }

    private void OutOfEnergy(Image DeathScreen, Canvas PC)
    {
        DeathScreen.gameObject.SetActive(true);
        dead = true;

        Time.timeScale = 0;
    }

}
