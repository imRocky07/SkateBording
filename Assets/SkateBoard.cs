using UnityEngine;

public class SkateBoard : MonoBehaviour
{
    [SerializeField] ParticleSystem Snow;


    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground"){
            Snow.Play();
    }
        }
    void OnCollisionExit2D(Collision2D other) {
     if (other.gameObject.tag == "Ground")
        {
            Snow.Stop();
        }    
    }
}