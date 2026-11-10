using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    private bool isChasing = false;
    [SerializeField]private Transform cat;

    // void Start()
    // {
    //     GameObject catObject = GameObject.FindGameObjectWithTag("Cat");
    //     cat = catObject.transform;
    //     StartChasing();
    // }

    void Update()
    {
        if (isChasing && cat != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, cat.position, speed * Time.deltaTime);
        }
    }

    public void StartChasing()
    {
        isChasing = true;
    }

    public void StopChasing()
    {
        isChasing = false;
    }

}
