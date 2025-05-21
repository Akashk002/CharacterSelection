using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ParticleSystem explosion;
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.GetComponent<TankView>())
        {
            GameObject bullet =  Instantiate(explosion.gameObject, transform.position, Quaternion.identity);

            Destroy(bullet,2);
            CameraShake.Instance.Shake();
            Destroy(gameObject);
        }
    }

}
