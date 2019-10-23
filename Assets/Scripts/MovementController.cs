using UnityEngine;

public class MovementController : MonoBehaviour{

    public float speed;
    void Update(){
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
