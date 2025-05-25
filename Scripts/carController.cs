using UnityEngine;
using UnityEngine.EventSystems;

public class carController : MonoBehaviour {

    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider rearRight;
    [SerializeField] WheelCollider rearLeft;

    [SerializeField] Transform frontRightTransform;
    [SerializeField] Transform frontLeftTransform;
    [SerializeField] Transform rearRightTransform;
    [SerializeField] Transform rearLeftTransform;

    public float accelaration = 50f;
    public float brakingforce = 50f;
    public float maxTurnAngle = 30f;

    public float currentAccelaration = 0f;
    public float currentBrakingForce = 0f;
    public float currentTurnAngle = 0f;
    

    public void FixedUpdate()
    {

        currentAccelaration = accelaration * SimpleInput.GetAxis("Vertical");
        if (Input.GetKey(KeyCode.Space))
            currentBrakingForce = brakingforce;
        else
            currentBrakingForce = 0f;

        frontRight.motorTorque = currentAccelaration;
        frontLeft.motorTorque = currentAccelaration;

        frontRight.brakeTorque = currentBrakingForce;
        rearRight.brakeTorque = currentBrakingForce;
        frontLeft.brakeTorque = currentBrakingForce;
        rearLeft.brakeTorque = currentBrakingForce;

        currentTurnAngle = maxTurnAngle * SimpleInput.GetAxis("Horizontal");
        frontLeft.steerAngle = currentTurnAngle;

        updateWheel(frontLeft, frontLeftTransform);
        updateWheel(frontRight, frontRightTransform);
        updateWheel(rearLeft, rearLeftTransform);
        updateWheel(rearRight, rearRightTransform);
    }

    void updateWheel(WheelCollider col, Transform trans)
    {
        Vector3 position;
        Quaternion rotation;
        col.GetWorldPose(out position, out rotation);
    }
}