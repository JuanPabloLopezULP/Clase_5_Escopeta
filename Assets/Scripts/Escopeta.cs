using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escopeta : MonoBehaviour
{
    private Camera cam;
    private GameObject go;
    private Transform ubicacionPelota;

    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        transform.position = cam.transform.position;
        go = GameObject.FindGameObjectWithTag("Pelota");
        ubicacionPelota = go.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posRelativa = ubicacionPelota.position - transform.position;
        transform.rotation = Quaternion.LookRotation(posRelativa);
    }
}
