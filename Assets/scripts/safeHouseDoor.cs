using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class safeHouseDoor : MonoBehaviour
{
    AudioSource safeDoorAudio;
    public Text endGameText;
    public restartGame theGameController;
    // Start is called before the first frame update
    void Start()
    {
        safeDoorAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.tag == "Player"){
            Animator safeDoorAnim = GetComponentInChildren<Animator>();
            safeDoorAnim.SetTrigger("safeHouseTrigger");
            safeDoorAudio.Play();
            endGameText.text = "Safe House";
            Animator endGameAnim = endGameText.GetComponent<Animator>();
            endGameAnim.SetTrigger("endGame");
            theGameController.restartTheGame();
        }
    }
}
