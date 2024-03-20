using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backLeft;
    [SerializeField] float acceleration = 500f;
    [SerializeField] float breakingForce = 300f;
    [SerializeField] float maxTurnAngle = 30f;
    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform backRightTransform;
    [SerializeField] Transform backLeftTransform;




    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;



    private void FixedUpdate() {

        currentAcceleration = acceleration * Input.GetAxis("Vertical");

        if(Input.GetKey(KeyCode.Space))
        currentBreakForce = breakingForce;
        else 
            currentBreakForce = 0f;


        frontRight.motorTorque = currentAcceleration;
        frontLeft.motorTorque = currentAcceleration;


        frontRight.brakeTorque = currentBreakForce;
        backRight.brakeTorque = currentBreakForce;
        frontLeft.brakeTorque = currentBreakForce;
        backLeft.brakeTorque = currentBreakForce;


        currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
        frontLeft.steerAngle = currentTurnAngle;
        frontRight.steerAngle = currentTurnAngle;


        UpdateWheel(frontLeft, frontLeftTransform);
        UpdateWheel(frontLeft, frontRightTransform);
        UpdateWheel(frontLeft, backLeftTransform);
        UpdateWheel(frontLeft, backRightTransform);

    }



    void UpdateWheel(WheelCollider col, Transform trans){
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);

        trans.position = position;
        trans.rotation = rotation;




    }

}
