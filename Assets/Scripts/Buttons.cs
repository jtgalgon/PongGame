using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    
    // Start Button changes the scene
    public void startBtn(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    public void quitBtn(){
        Debug.Log("Quit Application");
        Application.Quit();
    }
}
