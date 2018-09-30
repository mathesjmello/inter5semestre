using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float MoveSpeed;

    CharacterController CharController;
    [SerializeField]  AnimationCurve JumpFallOf;
    [SerializeField]  float JumpMod;
    bool IsJumping;

	// Use this for initialization
	void Start () {
        CharController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        PlayerMovment();
        BasicRun();
    }

    void PlayerMovment()
    {
        float HInput = Input.GetAxis("Horizontal") * MoveSpeed ;
        float VInput = Input.GetAxis("Vertical") * MoveSpeed ;

        Vector3 FMovment = transform.forward * VInput;
        Vector3 RMovment = transform.right * HInput;

        CharController.SimpleMove(FMovment + RMovment);

        JumpImput();
    }

    void JumpImput()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !IsJumping)
        {
            IsJumping = true;
            StartCoroutine(JumpEvent());
        }
    }

    IEnumerator JumpEvent()
    {
        float timeInAir = 0;

        CharController.slopeLimit = 90;

        do
        {
            float jumpForce = JumpFallOf.Evaluate(timeInAir);
            CharController.Move(Vector3.up * jumpForce * JumpMod * Time.deltaTime);
            timeInAir += Time.deltaTime;
            yield return null;
        }
        while (!CharController.isGrounded && CharController.collisionFlags != CollisionFlags.Above);

        CharController.slopeLimit = 45;
        IsJumping = false;
    }

    void BasicRun()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            MoveSpeed  = 12;
        }else
        {
            MoveSpeed = 6;
        }
    }
}
