using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject Bullet;
    public float BulletSpeed=100f;
    private bool _isShooting;
    public float movespeed = 10f;
    public float rotatespeed = 75f;
    private float _vinput;
    private float _hinput;
    private Rigidbody _rb;
    public float JumpVelocity=5f;
    private bool _isJumping;
    public float DistanceToGround=0.1f;
    public LayerMask GroundLayer;
    private CapsuleCollider _col;
    // Start is called before the first frame update
    void Start()
    {
        _col=GetComponent<CapsuleCollider>();
        _rb=GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        if(_isShooting){
            GameObject newBullet=Instantiate(Bullet,this.transform.position+new Vector3(1,0,0),this.transform.rotation);
            Rigidbody BulletRB=newBullet.GetComponent<Rigidbody>();
            BulletRB.velocity=this.transform.forward*BulletSpeed;
            _isShooting=false;
        }
        Vector3 rotation=Vector3.up*_hinput;
        Quaternion anglerot=Quaternion.Euler(rotation*Time.fixedDeltaTime);
        _rb.MovePosition(this.transform.position+this.transform.forward*_vinput*Time.fixedDeltaTime);
        _rb.MoveRotation(_rb.rotation*anglerot);
        if(IsGrounded() && _isJumping){
            _rb.AddForce(Vector3.up*JumpVelocity,ForceMode.Impulse);
            _isJumping=false;
        }
    }
    private bool IsGrounded(){
        Vector3 capsuleBottom=new Vector3(_col.bounds.center.x,_col.bounds.min.y,_col.bounds.center.z);
        bool grounded=Physics.CheckCapsule(_col.bounds.center,capsuleBottom,DistanceToGround,GroundLayer,QueryTriggerInteraction.Ignore);
        return grounded;
    }

    // Update is called once per frame
    void Update()
    {
        _isShooting|=Input.GetMouseButtonDown(0);
        _isJumping|=Input.GetKeyDown(KeyCode.Space);
        _vinput=Input.GetAxis("Vertical")*movespeed;
        _hinput=Input.GetAxis("Horizontal")*rotatespeed;
        this.transform.Translate(Vector3.forward*_vinput*Time.deltaTime);
        this.transform.Rotate(Vector3.up*_hinput*Time.deltaTime);
    }
}
