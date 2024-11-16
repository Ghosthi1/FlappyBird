using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class SpawnManager : MonoBehaviour
{
    private int leftEdge = -10;
    public GameObject pipe;
    private float whenSpawnPipe = 3.5f;
    private int maxPipes = 3;
    private List<GameObject> clones = new List<GameObject>(); 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        CleanUp();
        CreateClones();
    }

    public void SpawnPipe(){
        //checks if a pipe exists if not make one 
        if(CountPipes() == 0){
            GameObject intclone = Instantiate(pipe, new Vector2(10f,0.02f),Quaternion.identity);
            //adds it to list of clones
            clones.Add(intclone);
        }
    }

    public void CreateClones(){
        //if a pipe has moved far enough and theres not to many spawn more
        if(clones[0].transform.position.x < whenSpawnPipe && CountPipes() < maxPipes && CountPipes() > 0){
            GameObject clone = Instantiate(pipe, new Vector2(10f,0.02f),Quaternion.identity);
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
            if (clones[i].transform.position.x < leftEdge || CountPipes() > maxPipes)
            {
                Destroy(clones[i]); // Destroy the pipe
                clones.RemoveAt(i); // Remove the reference from the list
            }
        }
    }

}