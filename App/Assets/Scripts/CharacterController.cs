using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float moveSpeed;
    public Transform Orientation;

    float horizoneInput;
    float verticalInput;
    Vector3 moveDirec;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;

    }
    
    // Update is called once per frame
    void Update()
    {
        SetInput();
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (UIManager.instance.panelSelect.gameObject.activeSelf == false)
            {
                UIManager.instance.panelSelect.SetActive(true);
                UIManager.isLockAllControl = true;
                UIManager.instance.txtESC.gameObject.SetActive(false);
            }
            else
            {
                UIManager.instance.panelSelect.SetActive(false);
                UIManager.isLockAllControl = false;
                UIManager.instance.txtESC.gameObject.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            PropsManager.instance.ChangeWallColor();
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            PropsManager.instance.ChangeCeilingColor();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            PropsManager.instance.TurnLight();
        }
    }
    private void FixedUpdate()
    {
        if(!UIManager.isLockAllControl)
            MoveCharacter();
    }
    private void SetInput()
    {
        horizoneInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    private void MoveCharacter()
    {
        moveDirec = Orientation.forward * verticalInput + Orientation.right * horizoneInput;
        rb.AddForce(moveDirec.normalized * moveSpeed * 15f ,ForceMode.Force);
    }
}
