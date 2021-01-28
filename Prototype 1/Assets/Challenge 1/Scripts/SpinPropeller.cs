using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    public GameObject Propeller;
    private float propellerSpeed=20.0f;
    private float propellerRotation=5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * propellerRotation * propellerSpeed);
    }
}
