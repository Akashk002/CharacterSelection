using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    TankController tankController;
    public float movementSpeed, rotaionSpeed;
    public void SetController(TankController _tankController)
    {
        this.tankController = _tankController;
    }

    public TankModel(float MovementSpeed,float RotaionSpeed)
    {
        movementSpeed = MovementSpeed;
        rotaionSpeed = RotaionSpeed;
    }
}
