using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalScroll : MonoBehaviour {

    [SerializeField] float scrollRate = .2f;

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.Translate(new Vector2(0f, scrollRate * Time.deltaTime));
    }
}
