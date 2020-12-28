using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    private Transform ThisTransform = null;

    // Rotation Speed
    public Vector3 RotateAxis = Vector3.zero;

    // Start is called before the first frame update
    void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ThisTransform.Rotate(RotateAxis.x * Time.deltaTime, RotateAxis.y * Time.deltaTime, RotateAxis.z * Time.deltaTime);
    }
}
