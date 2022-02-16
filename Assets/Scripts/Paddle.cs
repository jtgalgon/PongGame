using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    public bool isPlayer1;
    private float movement;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayer1){
            movement = Input.GetAxisRaw("VerticalPlayer1");
        }else{
            movement = Input.GetAxisRaw("VerticalPlayer2");
        }

        rb.velocity = new Vector2(0, speed * movement);
        
    }

    public void OnTriggerEnter2D(Collider2D collision){
         ball.GetComponent<Ball>().updateBallSpeed(1);
    }


}
