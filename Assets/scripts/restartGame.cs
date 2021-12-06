using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartGame : MonoBehaviour
{
    public float restartTime;
    bool resetNow = false;
    float resetTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(resetNow && resetTime <= Time.time){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name, LoadSceneMode.Single);
        }
    }

    public void restartTheGame(){
        resetNow = true;
        resetTime = restartTime + Time.time;
    }
}
