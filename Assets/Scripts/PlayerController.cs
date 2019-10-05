using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float speed = 1;
    
    private Rigidbody2D _rigidbody;

    private void Awake(){
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update(){

        if (Input.GetMouseButtonDown(0)) {
            _rigidbody.velocity = Vector2.up * speed;
        }
    }
    
}
