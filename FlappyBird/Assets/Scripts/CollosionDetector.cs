using System;
using UnityEngine;

public class CollosionDetector : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col){
        string tagString = col.gameObject.tag;
        //compaers the tag from the collision to determine output
        switch (tagString){
            case "Pipe":
                print("End");
                break;
            case "Ground":
                print("Ground");
                break;
            case "Score":
                print("Score");
                break;
        }
    }

}
