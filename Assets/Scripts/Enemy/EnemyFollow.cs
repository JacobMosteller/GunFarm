using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour{

    public float speed = 3f;
    private Transform target;

   
    private void Upadate() {
        if (target != null) {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(target.position, target.position, step);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "player") {

        }
    }

    private void OnTriggerExit2D(Collider2D other)  {
        if (other.gameObject.tag == "player") {
            target = null;
        }
    }
}
