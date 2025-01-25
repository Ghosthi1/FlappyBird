using UnityEngine;

public class Audiomanager : JumpPlayer
{
    public AudioSource menupress;
    public AudioSource hit;
    private bool playonce = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameState && !gameINT && playonce){
            hit.Play();
            playonce = false;
        }
    }

    public void playMenuPress(){
        menupress.Play();
    }
}
