using UnityEngine;

public class EnemyBulletCollision : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject Energy;
    public float ExplosionLife = 0.5f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Valuable" && collision.gameObject.tag != "VeryValuable" && collision.gameObject.tag != "LegendaryValue" && collision.gameObject.tag != "HpPack" && collision.gameObject.tag != "AmmoPack" && collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "Enemy" && collision.gameObject.tag != "EnemyBullet" && collision.gameObject.tag != "Boss" && collision.gameObject.tag != "EnemyExplosion" && collision.gameObject.tag != "Explosion")
        {
            GameObject Blast = Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(Blast, ExplosionLife);
            GameObject energyPack = Instantiate(Energy, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
