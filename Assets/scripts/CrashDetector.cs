using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem FinishEffect;
    [SerializeField] AudioClip crashSFX;

    bool hasCrash = false;

   void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Ground" && !hasCrash){
            hasCrash = true;
            FindAnyObjectByType<playerController>().DisableControls();
            Debug.Log("Gameover");
            FinishEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene",loadDelay);

            
        }
   }

   void ReloadScene(){
        SceneManager.LoadScene(0);
    }
}
