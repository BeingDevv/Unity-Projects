using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject Follow;
        void LateUpdate()
    {
        transform.position = Follow.transform.position + new Vector3 (0, 0, -20);
    }
}
