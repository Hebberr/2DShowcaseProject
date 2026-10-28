using UnityEngine;

public class BulletCollision : MonoBehaviour
{
    public GameObject Explosion;
    public float ExplosionLife = 0.1f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Valuable" && collision.gameObject.tag != "VeryValuable" && collision.gameObject.tag != "LegendaryValue" && collision.gameObject.tag != "HpPack" && collision.gameObject.tag != "AmmoPack" && collision.gameObject.tag != "Bullet" && collision.gameObject.tag != "EnemyBullet" && collision.gameObject.tag != "Explosion" && collision.gameObject.tag != "EnemyExplosion")
        {
            GameObject Blast = Instantiate(Explosion, transform.position, Quaternion.identity);
            Destroy(Blast, ExplosionLife);
            Destroy(gameObject);
        }
    }
}
