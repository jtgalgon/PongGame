using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Goal : MonoBehaviour
{
    // Start is called before the first frame update

    
    [Header("Ball")]
    public GameObject ball;

    [Header("PlayersPaddle")]

    public GameObject player1;
    public GameObject player2;

    [Header("Transform positions")]
        public Transform ballPos;
        public Transform Player1Pos;
        public Transform Player2Pos;
    

    

    private int homeScore;
    private int awayScore;
    public Text home;
    public Text away;

    public bool isPlayer1Goal;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision){
        if(!isPlayer1Goal){
            addHomeScore();
            reset();
            launch();
            checkState();
            
        }else{

            addAwayScore();
            reset();
            launch();
            checkState();
        }
    }

    private void addHomeScore(){
        Debug.Log("Home Team Has scored");
        homeScore++;
        home.text = homeScore.ToString();

    }

    private void addAwayScore(){
        Debug.Log("Away Team has scored");
        awayScore++;
        away.text = awayScore.ToString();
    }

    private void reset(){
        ball.transform.position = ballPos.transform.position;
        player1.transform.position = Player1Pos.transform.position;
        player2.transform.position = Player2Pos.transform.position;
    }

    private void launch(){
        ball.GetComponent<Ball>().rb.velocity = new Vector2(0,0);
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
          ball.GetComponent<Ball>().rb.velocity = new Vector2(x* 5, y * 5);
    }

    

    private void checkState(){
        if(homeScore == 10){
            Debug.Log("Player 1 has won the game");
            SceneManager.LoadScene(0);
        }
        if(awayScore == 10){
            Debug.Log("Player 2 has won the game");
            SceneManager.LoadScene(0);
        }
    }
}
