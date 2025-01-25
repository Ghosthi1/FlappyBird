using UnityEngine;

public class JumpPlayer : CollosionDetector
{

    public Rigidbody2D rigidbodyBird;
    public int jumpHeight = 300;
    public GameObject SpawnManager;
    public static bool gameINT = true;
    public GameObject IntroUI;
    public AudioSource jumpNoise;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameINT = true;
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
                jumpNoise.Play();
            }
            //allows the first button press to begin the game
            else if(gameINT){
                //checks if game start been done 
                gameINT = false;

                IntroUI.SetActive(false);

                //starts the game
                StartPressed();  

                //unfreezes the y axis 
                rigidbodyBird.constraints = RigidbodyConstraints2D.FreezePositionX;
                rigidbodyBird.AddForce(transform.up * jumpHeight, ForceMode2D.Force); 

                //alows spawning of pipes 
                SpawnManager.SetActive(true);  

                jumpNoise.Play();
            }
        }
     
    }


}
