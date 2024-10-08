using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;  
    
    public void SetTarget(Transform newTarget) => target = newTarget;
    
    void LateUpdate()
    {
        if (target == null) return; 

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(target);
    }
}