using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBehavorUpDown : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform targetA;
    public Transform targetB;
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetA.position, step);
        if (transform.position == targetA.position) 
        {
            transform.position = Vector3.MoveTowards(transform.position, targetB.position, step);
        }
        
    }
}
