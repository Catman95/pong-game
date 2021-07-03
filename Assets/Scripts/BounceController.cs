using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;
    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHeight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "leftPaddle")
        {
            x = 1;
        }else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHeight;

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "leftPaddle" || collision.gameObject.name == "rightPaddle")
        {
            this.BounceFromRacket(collision);
        }else if(collision.gameObject.name == "LeftWall")
        {
            StartCoroutine(this.ballMovement.StartBall(true));
            this.scoreController.GoalRight();
        }else if(collision.gameObject.name == "RightWall")
        {
            StartCoroutine(this.ballMovement.StartBall(false));
            this.scoreController.GoalLeft();
        }
    }
}
