using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
    public List<Tank> tankList;

    // Update is called once per frame
    public void CreateTank(TankType tankType)
    {
        TankModel tankModel = new TankModel(tankList[(int)tankType].movementSpeed,tankList[(int)tankType].rotaionSpeed,tankList[(int)tankType].tankType,tankList[(int)tankType].color);
        TankController tankController = new TankController(tankModel,tankView);
    }

    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotaionSpeed;
        public TankType tankType;
        public Material color;
    }
}
