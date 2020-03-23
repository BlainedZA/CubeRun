using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour

{

    public AudioSource levelUpSound;

    public float levelUpDelay = 1f;

    public PlayerMovement movement;



    void Start()
    {
        levelUpSound = GetComponent<AudioSource>();
        movement.enabled = false;
        levelUpSound.Play();
    }


    public void LoadNextLevel ()
    {
        Invoke("LevelEnd", levelUpDelay);
    }

    void LevelEnd ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
