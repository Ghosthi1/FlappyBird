using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollosionDetector : MonoBehaviour
{
    public int score = 0;
    //true if game should be running 
    public static bool gameState;
    public TextMeshProUGUI scoreUI;
    public GameObject PauseButton;
    public GameObject StartButton;
    public GameObject GameOver;
    public GameObject DefualtGame;
    public TextMeshProUGUI FinalScore;
    public TextMeshProUGUI HighScoreUI;
    public int highScore = 0;

    public bool ground = false;
    public Animation animator;
    public AudioSource scoreSound;

    void Start(){
        gameState = false;
        //Gets the highscore 
        highScore = PlayerPrefs.GetInt("HighScore" , 0);
    }

    void OnCollisionEnter2D(Collision2D col){
        string tagString = col.gameObject.tag;
        //compaers the tag from the collision to determine output
        switch (tagString){
            case "Pipe":
                EndGame();
                break;

            case "Ground":
                ground = true;
                EndGame();
                break;

            case "Score":
                ScoreIncrease();
                break;
        }
    }
    
    //on collision stop the pipes 
    public void EndGame(){
        gameState = false;
        //stops the animation 
        StopAnimation();
        //chnages the ui
        EndUI();

    }

    public void ScoreIncrease(){
        //increase score
        score++;
        scoreSound.Play();
        scoreUI.SetText(score.ToString());
    }
    public void StartPressed(){
            gameState = true;  
    }
    public void PauseGame(){
        //stops game
        Time.timeScale = 0;
        //change button to start button 
        PauseButton.SetActive(false);
        StartButton.SetActive(true);
    }
    public void StartGame(){
        Time.timeScale = 1;
        PauseButton.SetActive(true);
        StartButton.SetActive(false);
    }
    public void EndUI(){
        if(ground == true){
            DefualtGame.SetActive(false);
            GameOver.SetActive(true);
            HighScore();
            FinalScore.SetText(score.ToString());

        }

    }

    public void HighScore(){
        if(highScore < score){
            highScore = score;
            //sets new high score 
            PlayerPrefs.SetInt("HighScore", highScore);
        }
        //displays the high score
        HighScoreUI.SetText(highScore.ToString());

    }

    public void ReloadScene(){
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName);
    }

    public void StopAnimation(){
        animator.enabled = false;
    }



}
