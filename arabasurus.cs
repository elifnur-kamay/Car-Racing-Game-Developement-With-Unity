using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arabasurus : MonoBehaviour
{
    public WheelCollider sagon, solon, sagarka, solarka;
    public float motorh�z�,donmeh�z�;
    public Joystick tus;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        solarka.motorTorque = motorh�z� * tus.Vertical;
        sagarka.motorTorque = motorh�z� * tus.Vertical;
        sagon.steerAngle = donmeh�z� * tus.Horizontal;
        solon.steerAngle = donmeh�z� * tus.Horizontal;
    }
}
