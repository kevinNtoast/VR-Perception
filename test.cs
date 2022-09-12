using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private Vector3 initialScale, rotationRate;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //setting the scale to initial scale
        rotationRate = new Vector3(0.0f, rotationSpeed, 0.0f);
        transform.localScale = new Vector3(Random.Range(0.1f, 1.5f), 1, Random.Range(0.1f, 1.5f));
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationRate = new Vector3(0.0f, rotationSpeed, 0.0f);
        transform.eulerAngles += rotationRate*Time.deltaTime;
    }
}
