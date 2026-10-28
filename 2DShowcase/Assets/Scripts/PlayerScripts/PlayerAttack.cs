using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    public int pAmmo = 12;
    public TMP_Text ammoText;
    public int ammoPackAmount;
    void Start()
    {
        ammoText.text = "Energy: " + pAmmo;
    }
    public float bulletSpeed = 10;
    public GameObject bullet;
    public GameObject meleeAttack;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "AmmoPack")
        {
            pAmmo += ammoPackAmount;
            ammoText.text = "Energy: " + pAmmo;
            Destroy(collision.gameObject);
        }
    }
    public void OnAttack()
    {
        if (pAmmo > 0 && Time.timeScale == 1)
        {
            GameObject shot = Instantiate(bullet, transform.position, Quaternion.identity);
            Destroy(shot, 5);
            Vector3 mousePos = Mouse.current.position.ReadValue();
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            mousePos.z = 0;
            Vector2 shootDir = mousePos - transform.position;
            shootDir.Normalize();
            shot.GetComponent<Rigidbody2D>().linearVelocity = shootDir * bulletSpeed;
            pAmmo--;
            ammoText.text = "Energy: " + pAmmo;
        }
        else
        {
            //GameObject swing = Instantiate(meleeAttack, transform.position, Quaternion.identity);
            //Destroy(swing, 0.1f); 
        }
    }
}
