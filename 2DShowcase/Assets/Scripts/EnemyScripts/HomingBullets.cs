using UnityEngine;

public class HomingBullets : MonoBehaviour
{
    public float bulletSpeed = 5;
    public float courseCorrectionDelay = 3;
    public float homingRange = 10;
    GameObject Player;
    float timer = 0;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        timer += Time.deltaTime;
        Vector3 shootDir = Player.transform.position - transform.position;
        Debug.Log(shootDir);
        if (timer > courseCorrectionDelay && shootDir.magnitude < homingRange)
        {
            bulletSpeed *= 1.01f;
            shootDir.Normalize();
            timer = 0;
            GetComponent<Rigidbody2D>().linearVelocity = shootDir * bulletSpeed;
        }

    }
}
