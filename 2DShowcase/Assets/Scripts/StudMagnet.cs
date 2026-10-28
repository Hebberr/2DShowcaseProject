using UnityEngine;

public class StudMagnet : MonoBehaviour
{
    public GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }
    void Update()
    {
        Vector3 pullDir = player.transform.position - transform.position;
        GetComponent<Rigidbody2D>().linearVelocity = pullDir;
    }
}
