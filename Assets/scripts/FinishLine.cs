using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 2f;
    [SerializeField] ParticleSystem FinishEffect;
   void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player"){
            FinishEffect.Play();
            Invoke("ReloadScene",loadDelay);
            GetComponent<AudioSource>().Play();
        }
    }

    void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
