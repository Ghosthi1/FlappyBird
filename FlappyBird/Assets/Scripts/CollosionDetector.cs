using UnityEngine;
using UnityEditor;

public class CollosionDetector : MonoBehaviour
{
    public int score = 0;
    //true if game should be running 
    public bool gameState = true;

    void Start(){
        gameState = true;
    }

    void OnCollisionEnter2D(Collision2D col){
        string tagString = col.gameObject.tag;
        //compaers the tag from the collision to determine output
        switch (tagString){
            case "Pipe":
                EndGame();
                break;

            case "Ground":
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

        //gets all pipes 
        GameObject[] toStop = GameObject.FindGameObjectsWithTag("Pipe");

        //sets the gamestate to false for each pipe
        foreach (GameObject stop in toStop){
            MoveToLeft script = stop.GetComponent<MoveToLeft>();
            if(script != null){
                script.gameState = false;
            }
        }
    }

    public void ScoreIncrease(){
        //increase score
        score++;
        print("Score " + score);
    }
}
