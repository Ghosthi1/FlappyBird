using UnityEngine;

public class MoveToLeft : SpawnManager
{
    public GameObject rigidbodyPipe;
    public GameObject colliderTop;
    public GameObject colliderBottom;

    public int moveSpeed = 5;


    // Update is called once per frame
    void Update()
    {
        //checks game is live
        if(gameState){
            MovePipeToLeft();
        }
        if(!gameState){
            Stop();
        }
    }

    private void MovePipeToLeft(){
        rigidbodyPipe.transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }

    private void Stop(){
        //stops pipe
        rigidbodyPipe.transform.Translate(Vector2.left * 0);
        //allow player to fall down pipe
        colliderTop.GetComponent<BoxCollider2D>().enabled = false;
        colliderBottom.GetComponent<BoxCollider2D>().enabled = false;

    }

}
