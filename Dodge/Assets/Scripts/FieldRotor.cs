using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldRotor : MonoBehaviour
{
    public float rotateSpeed = 60f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, rotateSpeed * Time.deltaTime, 0f);

        Debug.Log($"델타 타임은 무슨 값일까? -> {Time.deltaTime}");
    }
}
