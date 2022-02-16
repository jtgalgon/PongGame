using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        launch();
    }

    //launches ball at random direction at beginning of game
    private float m = 0;
    private void launch(){
        int[] dir = new int[]{-1, 1};
        float x = Random.Range(0,2);
        float y = Random.Range(0,2);
        

        if(x == 0){
            x= dir[0];
        }else{
            x = dir[1];
        }

        if(y == 0){
            y = dir[0];
        }else{
            y = dir[1];
        }

        rb.velocity = new Vector2(x * speed, y * speed);
    }

    public void updateBallSpeed(float n){
        m += n;
    }
}
