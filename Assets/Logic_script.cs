using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic_script : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject Game_over;
    public GameObject Border;
    public GameObject BRAD;
    public GameObject FLORPY_Spawner;
    public GameObject Score;
    public GameObject Score_tables;
    public GameObject Menu;
    public GameObject Pause;
    public GameObject Options;
    public difficulty_options dif_options;
    public InputField nameField;
    public float dif_options_s, dif_options_current;
    public bool restart = false;
    public bool gameOn = false;
    private bool pauseOn = false;

    [ContextMenu("Increase Score")]
    public void addScore(int scpreTpAdd)
    {
        playerScore += scpreTpAdd;
        scoreText.text = playerScore.ToString();
    }

    public void scoreBoard()
    {
        Menu.SetActive(false);
        Score_tables.SetActive(true);
    }

    public void exitScoreBoard()
    {
        Score_tables.SetActive(false);
        Menu.SetActive(true);
    }

    public void startGame()
    {
        dif_options.starting_pa = dif_options_current;
        Menu.SetActive(false);
        Instantiate(BRAD, new Vector3(transform.position.x, 0, 0), transform.rotation);
        FLORPY_Spawner.SetActive(true);
        Score.SetActive(true);
        Border.SetActive(true);
    }

    public void restartGame()
    {
        dif_options.starting_pa = dif_options_current;
        gameOn = false;
        Game_over.SetActive(false);
        Instantiate(BRAD, new Vector3(transform.position.x, 0, 0), transform.rotation);
        Border.SetActive(true);
        playerScore = 0;
        scoreText.text = playerScore.ToString();

        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void exitGame() 
    {
        Application.Quit();
    }

    public void unPauseGame()
    {              
        Pause.SetActive(false);
        pauseOn = false;
        Time.timeScale = 1;
    }

    public void options()
    {
        dif_options.starting_pa = dif_options_current;
        Options.SetActive(true);
        Menu.SetActive(false);
    }

    public void exitOptions()
    {
        Options.SetActive(false);
        Menu.SetActive(true);
        dif_options_current = dif_options.starting_pa;
    }
    public void exitPause()
    {
        Pause.SetActive(false);
        pauseOn = false;
        Time.timeScale = 1;
        gameOn = false;
        Score.SetActive(false);
        playerScore = 0;
        scoreText.text = playerScore.ToString();
        Game_over.SetActive(false);
        Menu.SetActive(true);
    }

    void Update()
    {
        //pauseGame
        if (Input.GetKey("escape") & pauseOn == false & gameOn == true)
        {
            pauseOn = true;
            Time.timeScale = 0;
            Pause.SetActive(true);
        }

    }

    public void gameOver()
    { 
        Game_over.SetActive(true);
        Border.SetActive(false);
    }
}
