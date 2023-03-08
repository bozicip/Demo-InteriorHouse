using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    private bool canControlthisDoor = false;
    private Animator doorAnim;
    private bool isOpen = false;
    void Start()
    {
        doorAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canControlthisDoor)
        {
            isOpen = !isOpen;
            doorAnim.SetBool("isOpen", isOpen);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Viewer")
        {
            UIManager.instance.ShowDoorNotice(true);
            canControlthisDoor = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Viewer")
        {
            UIManager.instance.ShowDoorNotice(false);
            canControlthisDoor = false;
        }
    }
}
