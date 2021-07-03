using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int scoreLeft = 0;
    private int scoreRight = 0;

    public GameObject scoreTextLeft;
    public GameObject scoreTextRight;

    public int goalToWin;

    void Update()
    {
        if(this.scoreLeft >= this.goalToWin || this.scoreRight >= this.goalToWin)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void FixedUpdate()
    {
        Text uiScoreLeft = this.scoreTextLeft.GetComponent<Text>();
        uiScoreLeft.text = this.scoreLeft.ToString();

        Text uiScoreRight = this.scoreTextRight.GetComponent<Text>();
        uiScoreRight.text = this.scoreRight.ToString();
    }

    public void GoalLeft()
    {
        this.scoreLeft++;
    }

    public void GoalRight()
    {
        this.scoreRight++;
    }
}
