using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    public float speed = 5f;
    private Rigidbody2D _rigid;
    public float _distance = .6f;
    public float _jumpPower = 6f;
    public LayerMask _layermask;

    private void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        _rigid.velocity = new Vector2(x* speed, _rigid.velocity.y);
        Jump();
    }

    public void Jump()
    {
        RaycastHit2D hit = Physics2D.BoxCast(transform.position, Vector2.one, 0, Vector2.down, _distance,_layermask);
        if(hit && Input.GetKeyDown(KeyCode.Space))
        {
            _rigid.AddForce(Vector2.up * _jumpPower, ForceMode2D.Impulse);
        }
    }
    
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector2.down);
    }
}
