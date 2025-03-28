using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;
    public List<Tank> tankList;
    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    // Update is called once per frame
    void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[0].movementSpeed,tankList[0].rotaionSpeed,tankList[0].tankType,tankList[0].color);
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
