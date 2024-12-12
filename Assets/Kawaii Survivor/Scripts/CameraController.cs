using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void LateUpdate(){
        Vector3 targetPosition = target.position;
        targetPosition.z = -10;

        transform.position = target.position;
    }
}
