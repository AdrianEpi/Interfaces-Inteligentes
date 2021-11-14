using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class describes Empujar functionality.
/// </summary>
public class Empujar : MonoBehaviour {
    private GameObject player;
    public float distance = 20f;
    public float force = 100f;
    private Rigidbody m_Rigidbody;

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>
    void Start() {
        player = GameObject.FindGameObjectWithTag("MyCharacter");
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update() {
        if (Vector3.Distance(transform.position, player.transform.position) < distance && Input.GetKey(KeyCode.Z)) {
            Vector3 moveDir = transform.position - player.transform.position;
            m_Rigidbody.AddForce(moveDir * force);
        }        
    }
}
