using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    TankController tankController;
    
    public void SetController(TankController _tankController)
    {
        this.tankController = _tankController;
    }
}
