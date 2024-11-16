using UnityEngine;

public class MoveToLeft : MonoBehaviour
{
    public GameObject rigidbodyPipe;


    public int moveSpeed = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePipeToLeft();


    }

    private void MovePipeToLeft(){
        rigidbodyPipe.transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

    }
}
