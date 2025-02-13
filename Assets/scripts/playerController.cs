using System;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float BoostSpeed = 5f;
     [SerializeField] float BaseSpeed = 13f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove == true){
            RotatePlayer();
            RespondToBoost();
        }
    }

    public void DisableControls(){
        canMove = false;
    }

    void RespondToBoost()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            surfaceEffector2D.speed = BaseSpeed + BoostSpeed;
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
            surfaceEffector2D.speed = BaseSpeed - BoostSpeed;
        }
        else{
            surfaceEffector2D.speed = BaseSpeed;
        }
    }

    void RotatePlayer(){

                
                if(Input.GetKey(KeyCode.LeftArrow)){
                    rb2d.AddTorque(torqueAmount);
                }
                else if(Input.GetKey(KeyCode.RightArrow)){
                    rb2d.AddTorque(torqueAmount*(-1));
                }
    }
}
