using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScreen : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("FirstScene");
    }

    public void GoToInstructionMenu(){
        //SceneManager.LoadScene("InstructionMenu");
    }

    public void GoToMainMenu(){
        //SceneManager.LoadScene("MainMenu");
    }

    public void ExitButton(){
        FindObjectOfType<GameManager>().ExitGame();
    }
}
