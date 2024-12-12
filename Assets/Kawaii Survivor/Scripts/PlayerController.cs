using UnityEngine; 

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rig;
    [SerializeField] private MobileJoystick playerJoystick;
    [SerializeField] private float moveSpeed;

    // called once when the script is first enabled
    void Start(){
        rig = GetComponent<Rigidbody2D>();
        rig.linearVelocity = Vector2.right;
    }

    private void FixedUpdate(){
        rig.linearVelocity = playerJoystick.GetMoveVector() * moveSpeed * Time.deltaTime;
    }
}


