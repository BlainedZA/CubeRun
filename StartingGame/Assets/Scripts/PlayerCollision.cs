using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    private DeathManager dm;

    void Awake()
    {
        dm = GameObject.FindObjectOfType<DeathManager>();
    }

    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
            dm.IncreaseDeaths();
        }
    }


}
