using UnityEngine;

public class CleanUp : MonoBehaviour
{
    private int leftEdge = -10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < leftEdge){
            Destroy(gameObject);
        }
    }
}
