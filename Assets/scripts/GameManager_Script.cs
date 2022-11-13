using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager_Script : MonoBehaviour
{
    public enum States{
        playing, gameover, succes
    }

    public GameObject player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
     public GameObject SuccesCanvas;
    private Health playerHealth;

    public States gameState = States.playing;

    // Start is called before the first frame update
    void Start()
    {
        if(player == null){
            player = GameObject.FindWithTag("Player");
        }

        playerHealth  = player.GetComponent<Health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //statemachine
        switch(gameState){
            case States.playing:
                if(!playerHealth.isAlive){
                    Debug.Log("entered");
                    gameState = States.gameover;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }

            break;
            
        }
    }
}
