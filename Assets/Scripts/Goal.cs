using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{   
    public int xbound, ybound = 0;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randompos = new Vector3(Random.Range(-xbound, xbound + 1), Random.Range(-ybound, ybound + 1), 0);
        transform.position  = randompos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
