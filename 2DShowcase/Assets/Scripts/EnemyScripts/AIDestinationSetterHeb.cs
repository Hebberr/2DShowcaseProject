using Pathfinding;
using Unity.VisualScripting;
using UnityEngine;
public class AIDestinationSetterHeb : MonoBehaviour
{
    public Transform target;
    public float enemySightRange = 20;
    IAstarAI ai;
    void OnEnable()
    {
        target = GameObject.Find("Target").transform;
        ai = GetComponent<IAstarAI>();
        if (ai != null) ai.onSearchPath += Update;
    }
    void OnDisable()
    {
        if (ai != null) ai.onSearchPath -= Update;
    }
    void Update()
    {
        if (target != null && ai != null && Vector3.Distance(transform.position, target.position) < enemySightRange) ai.destination = target.position;
    }
}
