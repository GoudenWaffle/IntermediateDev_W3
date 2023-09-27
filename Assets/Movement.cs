using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public HingeJoint2D RightThigh;
    public HingeJoint2D LeftThigh;
    public HingeJoint2D RightCalf;
    public HingeJoint2D LeftCalf;

    private JointMotor2D RightThighMotorRef;
    private JointMotor2D LeftThighMotorRef;
    private JointMotor2D RightCalfMotorRef;
    private JointMotor2D LeftCalfMotorRef;

    public float hingeSpeed = 40;

    // Start is called before the first frame update
    void Start()
    {
        RightThighMotorRef = RightThigh.motor; // goingf to right thigna nd assign
        LeftThighMotorRef = LeftThigh.motor;
        RightCalfMotorRef = RightCalf.motor;
        LeftCalfMotorRef = LeftCalf.motor;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey(KeyCode.Q))//if Q is pressed
        {
            RightThigh.useMotor = true;
            LeftThigh.useMotor = true;
            RightThighMotorRef.motorSpeed = -hingeSpeed;
            LeftThighMotorRef.motorSpeed = hingeSpeed;
            RightThigh.motor = RightThighMotorRef;
            LeftThigh.motor = LeftThighMotorRef;
        }
       else if(Input.GetKey(KeyCode.W))
        {
            RightThigh.useMotor = true;
            LeftThigh.useMotor = true;
            RightThighMotorRef.motorSpeed = hingeSpeed;
            LeftThighMotorRef.motorSpeed = - hingeSpeed;
            RightThigh.motor = RightThighMotorRef;
            LeftThigh.motor = LeftThighMotorRef;
        }
        else
        {
            RightThigh.useMotor = false;
            LeftThigh.useMotor = false;
        }
        if (Input.GetKey(KeyCode.O))//if Q is pressed
        {
            RightCalf.useMotor = true;
            LeftCalf.useMotor = true;
            RightCalfMotorRef.motorSpeed = -hingeSpeed;
            LeftCalfMotorRef.motorSpeed = hingeSpeed;
            RightCalf.motor = RightCalfMotorRef;
            LeftCalf.motor = LeftCalfMotorRef;
        }
        else if (Input.GetKey(KeyCode.P))
        {
            RightCalf.useMotor = true;
            LeftCalf.useMotor = true;
            RightCalfMotorRef.motorSpeed = hingeSpeed;
            LeftCalfMotorRef.motorSpeed = -hingeSpeed;
            RightCalf.motor = RightCalfMotorRef;
            LeftCalf.motor = LeftCalfMotorRef;
        }
        else
        {
            RightCalf.useMotor = false;
            LeftCalf.useMotor = false;
        }
    }

























}
