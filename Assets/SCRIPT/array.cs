using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string funnySentence = "";
        int count = 0;

        while (count < 7)
        {
            int randomIndex = Random.Range(0, words.Length);
            funnySentence += words[randomIndex] + " ";
            count++;
        }
       Debug.Log(funnySentence.Trim()); 
        
    }
}


