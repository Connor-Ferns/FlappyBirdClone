using Unity.VisualScripting;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5f;
    private Animator animator;
    private Rigidbody2D rb;
    private GameObject gameManager;
    void Awake(){
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager");
    }

    void Update(){
        animator.Play("BirdFlapping");

        if(Input.GetKeyDown(KeyCode.Space)){
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
            rb.AddForceY(jumpForce, ForceMode2D.Impulse);
        }
    }

    public void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.CompareTag("Hit")){
            Debug.Log("DEATH");
            gameManager.GetComponent<DeathScreen>().showDeathScreen();
        }
    }
}
