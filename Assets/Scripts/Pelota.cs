using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left*Time.deltaTime* 50);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 50);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * 50);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * 50);
        }
    }
}
