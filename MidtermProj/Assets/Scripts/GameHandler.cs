using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour
{

    public void playGame() {
        SceneManager.LoadScene("GameScene");
    }

    // public void Button_OpenTutorial(){
    //     Tutorial.SetActive(true);
    //     buttonOpenTutorial.SetActive(false);
    // }

    // public void Button_CloseTutorial() {
    //     Tutorial.SetActive(false);
    //     buttonOpenTutorial.SetActive(true);
    // }


    // Update is called once per frame
    void Update()
    {
        
    }
}
