using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HOMEWORK : MonoBehaviour
{
    void Start()
    {
        int random;

        while (true)
        {
            random = Random.Range(1, 21);

            if (random == 5)
            {
                Debug.Log(random);
                continue;
            }
            else if (random == 15)
            {
                break;
            }
        }
    }
}
