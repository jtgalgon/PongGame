using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

[Header("Score UI")]
public Text homeScore;
public Text awayScore;

public void GameEnd(){
    if (homeScore.ToString().Equals("10") || awayScore.ToString().Equals("10")){
         Debug.Log("Game Has Ended!");
    }
}


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
