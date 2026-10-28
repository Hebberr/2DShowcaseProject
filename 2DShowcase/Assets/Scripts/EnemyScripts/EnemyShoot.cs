using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject bullet;
    public float bulletSpeed =  5;
    public float bulletLife = 5;
    public float shootDelay = 3;
    public float enemyRange = 10;
    GameObject Player;
    float timer = 0;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        timer += Time.deltaTime;
        Vector2 shootDir = Player.transform.position - transform.position;
        if (timer > shootDelay && shootDir.magnitude < enemyRange)
        {
            shootDir.Normalize();
            timer = 0;
                GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
                Destroy(shot, bulletLife);
                shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * bulletSpeed;
        }

    }
}
