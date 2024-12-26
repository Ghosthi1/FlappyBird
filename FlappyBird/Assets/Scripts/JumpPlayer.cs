using UnityEngine;

public class JumpPlayer : CollosionDetector
{

    public Rigidbody2D rigidbodyBird;
    public int jumpHeight = 300;
    public CollosionDetector collosionDetectorRefrence;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        Jump();  
    }

    private void Jump(){
        
        //Detects if mouse button 1 is pressed and checks that game has not ended 
        if(Input.GetButtonDown("Fire1")){
            if(gameState){
                rigidbodyBird.AddForce(transform.up * jumpHeight, ForceMode2D.Force);   
            }
            //allows the first button press to begin the game
            else{
                //starts the game
                collosionDetectorRefrence.StartPressed();  
                //unfreezes the y axis 
                rigidbodyBird.constraints = RigidbodyConstraints2D.FreezePositionX;
                rigidbodyBird.AddForce(transform.up * jumpHeight, ForceMode2D.Force);   
            }
        }
     
    }
}
