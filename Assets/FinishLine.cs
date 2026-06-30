using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float Delay = 1f;
    [SerializeField] ParticleSystem Finish;

     void Restart(){
             SceneManager.LoadScene(0);
        }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Finish.Play();
            GetComponent<AudioSource>().Play();
            Invoke("Restart", Delay);
            Debug.Log("Level Completed!");
        }
       
        }     
}
