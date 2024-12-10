using UnityEngine;  // Make sure to include this

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rig;

    // called once when the script is first enabled
    void Start(){
        
    }

    // called every frame
    void Update(){
        rig = GetComponent<Rigidbody2D>();
        rig.linearVelocity = Vector2.right;
    }
}


