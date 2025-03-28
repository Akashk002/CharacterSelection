using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    TankController tankController;
    float movement,rotaion;
    public Rigidbody rb;

    private void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(this.transform);
        cam.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 3, this.transform.position.z - 5);
    }
    private void Update()
    {
        Movement();
    }

    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
        rotaion = Input.GetAxis("Horizontal");
        if(movement != 0)
        tankController.Move(movement,tankController.GetTankModel().movementSpeed);
        if(rotaion != 0)
        tankController.Rotate(rotaion, tankController.GetTankModel().rotaionSpeed);
    }

    public void SetController(TankController _tankController)
    {
        this.tankController = _tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return rb;
    }
}
