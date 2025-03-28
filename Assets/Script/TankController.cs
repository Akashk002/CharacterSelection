using UnityEngine;

public class TankController 
{
    TankModel tankModel;
    TankView tankView;
    Rigidbody rb;

    public TankController(TankModel _tankModel, TankView _tankView)
    {
        tankModel = _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);
        rb = tankView.GetRigidbody();
        tankView.SetController(this);
        tankModel.SetController(this);
    }

    internal void Move(float movement , float moveSpeed)
    {
        rb.velocity = tankView.transform.forward * movement * moveSpeed * Time.deltaTime * 200;
    }

    internal void Rotate(float rotaion , float rotationSpeed)
    {
        Vector3 vector = new Vector3(0f, rotaion * rotationSpeed,0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
