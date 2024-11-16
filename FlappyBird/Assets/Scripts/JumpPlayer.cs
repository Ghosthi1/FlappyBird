using UnityEngine;

public class JumpPlayer : MonoBehaviour
{

    public Rigidbody2D rigidbodyBird;
    public int jumpHeight = 50;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Detects if mouse button 1 is pressed 
        if(Input.GetButtonDown("Fire1")){
            rigidbodyBird.AddForce(transform.up * jumpHeight, ForceMode2D.Force);
        }
    }
}
