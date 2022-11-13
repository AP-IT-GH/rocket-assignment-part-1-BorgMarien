using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoad : MonoBehaviour
{
    public string levelToLoad;

    public void loadLevel(){
        //load new level
        SceneManager.LoadScene(levelToLoad);

    }
}
