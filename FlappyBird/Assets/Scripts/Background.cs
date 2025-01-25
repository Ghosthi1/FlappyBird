using UnityEngine;

public class Background : CollosionDetector
{
    public GameObject backGround;
    private int speed = 3;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameState){
            backGround.transform.Translate(Vector2.left * speed * Time.deltaTime);
            if(backGround.transform.position.x < -37){
                backGround.transform.position = new Vector3(0,0,0);
            }
        }


        if(!gameState){
            backGround.transform.Translate(Vector2.left * 0);
        }

    }

}
