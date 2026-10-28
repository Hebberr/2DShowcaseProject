using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float health = 10;
    public float maxHealth = 10;
    public float enemyDamage = 1;
    public float enemyBulletDamage = 1;
    public float enemyExplosionDamage = 1;
    public float bossDamage = 3;
    public float healAmount = 1;
    public TMP_Text healthText;
    void Start()
    {
        healthText.text = "Health: " + health;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Exit")
        {
            if (SceneManager.GetActiveScene().name == "LevelOne")
            {
                SceneManager.LoadScene("LevelTwo");
            }
            if (SceneManager.GetActiveScene().name == "LevelTwo")
            {
                SceneManager.LoadScene("WinScreen");
            }
        }
        if (collision.gameObject.tag == "Enemy")
        {
            health -= enemyDamage;
            healthText.text = "Health: " + health;
        }
        if (collision.gameObject.tag == "EnemyBullet")
        {
            health -= enemyBulletDamage;

            healthText.text = "Health: " + health;
        }
        if (collision.gameObject.tag == "EnemyExplosion")
        {
            health -= enemyExplosionDamage;

            healthText.text = "Health: " + health;
        }
        if (collision.gameObject.tag == "Boss")
        {
            health -= bossDamage;
            healthText.text = "Health: " + health;
        }
        if (collision.gameObject.tag == "HpPack" && health < maxHealth)
        {
            health += healAmount;
            healthText.text = "Health: " + health;
            Destroy(collision.gameObject);
        }
        if (health < 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
            if (collision.gameObject.tag == "Enemy")
            {
                health -= enemyDamage;
                healthText.text = "Health: " + health;
            }
            if (collision.gameObject.tag == "EnemyBullet")
            {
                health -= enemyBulletDamage;

                healthText.text = "Health: " + health;
            }
            if (collision.gameObject.tag == "Boss")
            {
                health -= bossDamage;
                healthText.text = "Health: " + health;
            }
            if (collision.gameObject.tag == "HpPack" && health < maxHealth)
            {
                health += healAmount;
                healthText.text = "Health: " + health;
                Destroy(collision.gameObject);
            }
            if (health < 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }