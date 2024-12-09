using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float speed = 2f; // Speed at which the obstacle moves

    void Update(){
        // Move the obstacle to the left
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        // Destroy the obstacle if it moves off-screen
        if (transform.position.x < Camera.main.transform.position.x - 10f){
            Destroy(gameObject);
        }
    }
}