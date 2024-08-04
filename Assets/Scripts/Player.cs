using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int xbound, ybound = 0;

    public GameObject Goal;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randompos = new Vector3(Random.Range(-xbound, xbound + 1), Random.Range(-ybound, ybound + 1), 0);
        transform.position  = randompos;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            int newy = (int)transform.position.y + 1;
            transform.position = new Vector3(transform.position.x, newy, transform.position.z);
        }
        if(Input.GetKeyDown(KeyCode.S)){
            transform.position = new Vector3((int)transform.position.x, transform.position.y - 1, 0);
        }
        if(Input.GetKeyDown(KeyCode.A)){
            transform.position = new Vector3((int)transform.position.x - 1, transform.position.y, 0);
        }
        if(Input.GetKeyDown(KeyCode.D)){
            transform.position = new Vector3((int)transform.position.x + 1, transform.position.y, 0);
        }

        if(Goal.transform.position == transform.position){
            Debug.Log("Goal achieved..!!");
        }
    }
}
