using UnityEngine;

public class Move : MonoBehaviour
{

    public GameObject Goal;
    public float Speed;
    private Vector3 direction;


    void Start()
    {
        //_direction = Goal.transform.position - this.transform.position;

    }

    private void LateUpdate()
    {
        direction = Goal.transform.position - transform.position;
        transform.LookAt(Goal.transform.position);
        if (direction.magnitude > 2)
        {
            Vector3 velocity = direction.normalized * Speed * Time.deltaTime;
            transform.position = transform.position + velocity;
        }


    }
}
