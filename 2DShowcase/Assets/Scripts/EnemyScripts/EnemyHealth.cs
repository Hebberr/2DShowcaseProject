using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class EnemyHealth : MonoBehaviour
{
    public float eHealth = 10;
    public float bulletDamage = 1;
    public float explosionDamage = 1;
    public float enemyExplosionDamage = 0;
    public GameObject Exit;
    //Ammo
    public GameObject ammoPack;
    public float ammoChance = 100 / 3;
    public int minAmmoAmount = 1;
    public int maxAmmoAmount = 3;
    //HpPack
    public GameObject hpPack;
    public float hpPackChance = 25;
    public int minHpPackAmount = 1;
    public int maxHpPackAmount = 3;
    //Val
    public GameObject valuable;
    public float valChance = 100;
    public int minValAmount = 2;
    public int maxValAmount = 7;
    //VeryVal
    public GameObject veryValuable;
    public float veryValChance = 25;
    public int minVeryValAmount = 1;
    public int maxVeryValAmount = 4;
    //LegendaryVal
    public GameObject legendaryValue;
    public float legendaryValChance = 5;
    public int minLegendaryValAmount = 1;
    public int maxLegendaryValAmount = 2;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyExplosion")
        {
            eHealth -= enemyExplosionDamage;
        }
        if (collision.gameObject.tag == "Bullet")
        {
            eHealth -= bulletDamage;
        }
        if (collision.gameObject.tag == "Explosion")
        {
            eHealth -= explosionDamage;
        }
        if (eHealth < 1)
        {
            if (gameObject.tag == "Boss")
            {
                Exit = GameObject.Find("Exit");
                Exit.GetComponent<TilemapCollider2D>().isTrigger = true;
            }
            //Ammo
            float rand = Random.Range(1, 99);
            if (rand < ammoChance)
            {
                int vAmount = Random.Range(minAmmoAmount, maxAmmoAmount);
                for (int i = 0; i < vAmount; i++)
                {

                    GameObject ammoDrop = Instantiate(ammoPack, transform.position, Quaternion.identity);
                    ammoDrop.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
            }
            //HpPack
            rand = Random.Range(1, 99);
            if (rand < hpPackChance)
            {
                int vAmount = Random.Range(minHpPackAmount, maxHpPackAmount);
                for (int i = 0; i < vAmount; i++)
                {

                    GameObject hpDrop = Instantiate(hpPack, transform.position, Quaternion.identity);
                    hpDrop.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
            }
            //Val
            rand = Random.Range(1, 99);
            if (rand < valChance)
            {
                int vAmount = Random.Range(minValAmount, maxValAmount);
                for (int i = 0; i < vAmount; i++)
                {
                    GameObject val = Instantiate(valuable, transform.position, Quaternion.identity);
                    val.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
            }
            //VeryVal
            rand = Random.Range(1, 99);
            if (rand < veryValChance)
            {
                int vAmount = Random.Range(minVeryValAmount, maxVeryValAmount);
                for (int i = 0; i < vAmount; i++)
                {
                    GameObject vValuable = Instantiate(veryValuable, transform.position, Quaternion.identity);
                    vValuable.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
            }
            //LegendaryVal
            rand = Random.Range(1, 99);
            if (rand < legendaryValChance)
            {
                int vAmount = Random.Range(minLegendaryValAmount, maxLegendaryValAmount);
                for (int i = 0; i < vAmount; i++)
                {
                    GameObject legendaryTreasure = Instantiate(legendaryValue, transform.position, Quaternion.identity);
                    legendaryTreasure.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
            }
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemyExplosion")
        {
            eHealth -= enemyExplosionDamage;
        }
        if (collision.gameObject.tag == "Bullet")
        {
            eHealth -= bulletDamage;
        }
        if (collision.gameObject.tag == "Explosion")
        {
            eHealth -= explosionDamage;
        }
        if (eHealth < 1)
        {
            if (gameObject.tag == "Boss")
            {
                Exit = GameObject.Find("Exit");
                Exit.GetComponent<TilemapCollider2D>().isTrigger = true;
            }
            //Ammo
            float rand = Random.Range(1, 99);
            if (rand < ammoChance)
            {
                int vAmount = Random.Range(minAmmoAmount, maxAmmoAmount);
                for (int i = 0; i < vAmount; i++)
                {

                    GameObject ammoDrop = Instantiate(ammoPack, transform.position, Quaternion.identity);
                    ammoDrop.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
            }
            //HpPack
            rand = Random.Range(1, 99);
            if (rand < hpPackChance)
            {
                int vAmount = Random.Range(minHpPackAmount, maxHpPackAmount);
                for (int i = 0; i < vAmount; i++)
                {

                    GameObject hpDrop = Instantiate(hpPack, transform.position, Quaternion.identity);
                    hpDrop.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
            }
            //Val
            rand = Random.Range(1, 99);
            if (rand < valChance)
            {
                int vAmount = Random.Range(minValAmount, maxValAmount);
                for (int i = 0; i < vAmount; i++)
                {
                    GameObject val = Instantiate(valuable, transform.position, Quaternion.identity);
                    val.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
            }
            //VeryVal
            rand = Random.Range(1, 99);
            if (rand < veryValChance)
            {
                int vAmount = Random.Range(minVeryValAmount, maxVeryValAmount);
                for (int i = 0; i < vAmount; i++)
                {
                    GameObject vValuable = Instantiate(veryValuable, transform.position, Quaternion.identity);
                    vValuable.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
            }
            //LegendaryVal
            rand = Random.Range(1, 99);
            if (rand < legendaryValChance)
            {
                int vAmount = Random.Range(minLegendaryValAmount, maxLegendaryValAmount);
                for (int i = 0; i < vAmount; i++)
                {
                    GameObject legendaryTreasure = Instantiate(legendaryValue, transform.position, Quaternion.identity);
                    legendaryTreasure.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                }
            }
            Destroy(gameObject);
        }
    }
}