using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Win;
    public GameObject Lose;

    public GameObject pauseMenu;
    public TMP_Text FinalScore;

    public bool Pausable = true;
    public bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (GunScript.health <= 0)
    //    {
    //        Lose.SetActive(true);
    //        Time.timeScale = 0;
    //        GunScript.paused = true;
    //        GunScript.Pausable = false;
    //        FinalScore.text = Score.ToString();

    //        Cursor.visible = true;
    //        Cursor.lockState = CursorLockMode.None;
    //    }

    //    if (ScoreTarget <= 0)
    //    {
    //        Win.SetActive(true);
    //        Time.timeScale = 0;
    //        GunScript.paused = true;
    //        GunScript.Pausable = false;
    //        FinalScore.text = Score.ToString();

    //        Cursor.visible = true;
    //        Cursor.lockState = CursorLockMode.None;
    //    }
    //}
    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void level1() 
    {
        SceneManager.LoadScene(2);
    }

    public void Continue()
    {
        
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && Pausable == true)
        { 

        }
    }

}
