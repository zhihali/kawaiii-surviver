using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement: MonoBehaviour
{
    [Header("Element")]
    private Player player;
    [Header("Settings")]
    [SerializeField] private float moveSpeed;

    void Start()
    {
        player = FindFirstObjectByType<Player>();

        if (player == null){
            Debug.LogWarning("No player found");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update(){
    // Calculate the direction to the player
    Vector2 direction = (player.transform.position - transform.position).normalized;

    // Check the distance to the player
    float distanceToPlayer = Vector2.Distance(player.transform.position, transform.position);

    // If close enough, stop moving
    if (distanceToPlayer > 0.1f) // Adjust threshold as needed
    {
        Vector2 targetPosition = (Vector2)transform.position + direction * moveSpeed * Time.deltaTime;
        transform.position = targetPosition;
    }
    }

}
