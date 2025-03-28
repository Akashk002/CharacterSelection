using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
   public TankSpawner tankSpawner;

   public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankType.Green);
        gameObject.SetActive(false);
    }   
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankType.Blue);
        gameObject.SetActive(false);
    } 
    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankType.Red);
        gameObject.SetActive(false);
    }

}
