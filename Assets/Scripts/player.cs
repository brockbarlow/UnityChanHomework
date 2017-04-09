using UnityEngine;

public class player : MonoBehaviour
{
    public Animator anim;
    public float xSpeed;
    public float zSpeed;

    private float m_InputH;
    private float m_InputV;
    private Rigidbody m_rb;
    private bool m_run;

    public void Start()
    {
        anim = this.GetComponent<Animator>();
        this.m_rb = this.GetComponent<Rigidbody>();
        this.m_run = false;
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift)) { this.m_run = true; }
        else { this.m_run = false; }

        this.m_InputH = Input.GetAxisRaw("Horizontal");
        this.m_InputV = Input.GetAxisRaw("Vertical");

        this.anim.SetFloat("inputH", this.m_InputH);
        this.anim.SetFloat("inputV", this.m_InputV);
        this.anim.SetBool("run", this.m_run);

        var moveX = this.m_InputH * this.xSpeed * Time.deltaTime;
        var moveZ = this.m_InputV * this.zSpeed * Time.deltaTime;

        if (moveZ <= 0f) { moveX = 0f; }
        else if (this.m_run) { moveX *= 3f; moveZ *= 3f; }

        this.m_rb.velocity = new Vector3(moveX, 0f, moveZ);
    }
}