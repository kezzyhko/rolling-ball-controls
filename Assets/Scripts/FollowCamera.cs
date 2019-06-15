using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject objectToFollow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = this.transform.position;
        newPosition.x = objectToFollow.transform.position.x;
        newPosition.y = objectToFollow.transform.position.y;
        transform.position = newPosition;
    }
}
