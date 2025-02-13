using UnityEngine;

public class DusrTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem effect1;
    [SerializeField] ParticleSystem effect2;

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground"){
            effect1.Play();
            effect2.Play();
        }
    }


    void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground"){
        effect1.Stop();
        effect2.Stop();
        }
    }
}
