using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPaddle : MonoBehaviour
{
    public float movementSpeed;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

}
