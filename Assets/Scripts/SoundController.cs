using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource pop;
    public AudioSource pointSound;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "LeftWall" || col.gameObject.name == "RightWall")
        {
            this.pointSound.Play();
        }else
        {
            this.pop.Play();
        }
    }
}
