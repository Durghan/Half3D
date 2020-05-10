using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // public or private reference 
    // every variable has a datatype (int, float, bool, string) 
    // every variable has a name
    // Optional 4th, is an assigned value
    public float speed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        // take the current position = new position (0,0,0)
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {                       // new Vector3(
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
