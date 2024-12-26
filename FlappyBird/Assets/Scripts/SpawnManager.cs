using UnityEngine;
using System.Collections.Generic;

public class SpawnManager : CollosionDetector
{
    private int leftEdge = -10;
    public GameObject pipe;
    private float whenSpawnPipe = 3.5f;
    private int maxPipes = 4;
    private List<GameObject> clones = new List<GameObject>(); 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        //checks if game is still going
        if(gameState){
            CleanUp();
            CreateClones();
        }
    }

    public void SpawnPipe(){
        //checks if a pipe exists if not make one 
        if(CountPipes() == 0){
            GameObject intclone = Instantiate(pipe, new Vector2(10f,Random.Range(-4f, 2f)),Quaternion.identity);
            //adds it to list of clones
            clones.Add(intclone);
        }
    }

    public void CreateClones(){
        //if a pipe has moved far enough and theres not to many spawn more
        if(clones[CountPipes()- 1].transform.position.x < whenSpawnPipe && CountPipes() < maxPipes){
            GameObject clone = Instantiate(pipe, new Vector2(10f,Random.Range(-4f, 2f)),Quaternion.identity);
            //adds it to list of clones
            clones.Add(clone);
        } 
    }

    private int CountPipes(){
        //retuns the length of pipes which is how many objects there are 
        return clones.Count;
    }

    public void CleanUp(){
        // Iterate backward to safely remove items from the list
        for (int i = clones.Count - 1; i >= 0; i--)
        {
            // Check if the pipe has gone past the left edge or if there are too many pipes
            if (clones[i].transform.position.x < leftEdge)
            {
                Destroy(clones[i]); // Destroy the pipe
                clones.RemoveAt(i); // Remove the reference from the list
            }
        }
    }


}