using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{

    public float stepSize;
    private Vector3 scaleSize, yTransform, xTransform;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1, 1, 1);
        yTransform = new Vector3(0, stepSize, 0);
        xTransform = new Vector3(stepSize, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        yTransform = new Vector3(0, stepSize, 0);
        xTransform = new Vector3(stepSize, 0, 0);

        if (Input.GetKey("up"))
        {
            transform.localScale += yTransform * Time.deltaTime;
        }

        if (Input.GetKey("down"))
        {
            transform.localScale -= yTransform * Time.deltaTime;
        }
        if (Input.GetKey("left"))
        {
            transform.localScale += xTransform * Time.deltaTime;
        }

        if (Input.GetKey("right"))
        {
            transform.localScale -= xTransform * Time.deltaTime;
        }
    }
}
