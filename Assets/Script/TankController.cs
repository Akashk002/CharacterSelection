using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController 
{
    TankModel tankModel;
    TankView tankView;

   public TankController(TankModel _tankModel, TankView _tankView)
    {
        this.tankModel = _tankModel;
        this.tankView = _tankView;
        tankView.SetController(this);
        tankModel.SetController(this);

        GameObject.Instantiate(tankView.gameObject);
    }
}
