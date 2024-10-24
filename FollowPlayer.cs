using UnityEngine;
public class FollowPlayer : MonoBehaviour
{
    void Start()
    {
        
    } 
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    void LateUpdate()
    {
        // Elta player
        transform.position = player.transform.position + offset;
    }
}
