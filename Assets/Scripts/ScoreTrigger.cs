using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Player")){
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<ScoreManager>().AddPoint();
        }
    }
}
