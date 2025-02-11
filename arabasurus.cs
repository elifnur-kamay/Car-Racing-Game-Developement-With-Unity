using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arabasurus : MonoBehaviour
{
    public WheelCollider sagon, solon, sagarka, solarka;
    public float motorhýzý,donmehýzý;
    public Joystick tus;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        solarka.motorTorque = motorhýzý * tus.Vertical;
        sagarka.motorTorque = motorhýzý * tus.Vertical;
        sagon.steerAngle = donmehýzý * tus.Horizontal;
        solon.steerAngle = donmehýzý * tus.Horizontal;
    }
}
