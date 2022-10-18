using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject p;
    private UnityEngine.Vector3 dist;
    // Start is called before the first frame update
    void Start()
    {
        dist = transform.position - p.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = p.transform.position + dist;
    }
}
