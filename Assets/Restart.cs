using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField] float Delay = 0.5f;
    [SerializeField] ParticleSystem Bump;
     [SerializeField] AudioClip Hit;
    bool Crash = false;
    void RestartS()
    {
           SceneManager.LoadScene(0);
    }
    void OnTriggerEnter2D(Collider2D other)
       {
        if (other.tag == "Ground")
        {
            Crash = true;
            GetComponent<PlayerScript>().StopControl();
            GetComponent<AudioSource>().PlayOneShot(Hit);
            Bump.Play();
            Debug.Log("Ouch! Hit my head");
            Invoke("RestartS", Delay);
        }
    }
}
