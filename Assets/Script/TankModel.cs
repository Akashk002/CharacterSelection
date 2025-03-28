using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel
{
    TankController tankController;
    public float movementSpeed, rotaionSpeed;
    public TankType tankType;
    public Material color;
    public void SetController(TankController _tankController)
    {
        this.tankController = _tankController;
    }

    public TankModel(float MovementSpeed,float RotaionSpeed, TankType _tankType, Material _color)
    {
        movementSpeed = MovementSpeed;
        rotaionSpeed = RotaionSpeed;
        tankType = _tankType;
        color = _color;
    }
}
