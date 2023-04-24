using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private float _MoveSpeed = 10f;
    private float _RotationSpeed = 50f;
    private float _MinVerticalAngle = -90f;
    private float _MaxVerticalAngle = 90f;

    private float _rotationV;
    private float _rotationH;
    private float _initTotationH;
    private GameObject character;


    private float camAngleH;
    private float camAngleV;
    private float camAngleH0;
    private float camSensX = 2;
    private float camSensY = 2;

    private Vector3 camOffset;
    void Start()
    {
        character = GameObject.Find("Character");
        camOffset = this.transform.position - character.transform.position;
        _initTotationH = transform.eulerAngles.y;
    }

    
    void LateUpdate()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");


        camAngleH += mx * camSensX * Time.timeScale;
        camAngleV -= my * camSensY * Time.timeScale;

        this.transform.position = character.transform.position+Quaternion.Euler(0, camAngleH - camAngleH0, 0) * camOffset;
        Rotate();
    }

    private void Move()
    {
        bool shiftPressed = Input.GetKey(KeyCode.LeftShift);
        float multiplier = shiftPressed ? 2f : 1f;

        Vector3 direction = transform.forward * Input.GetAxis("Vertical") +
                            transform.right * Input.GetAxis("Horizontal");
        direction.y = 0f;

        transform.position += _MoveSpeed * multiplier * Time.deltaTime * direction.normalized;
    }

    private void Rotate()
    {
        float mouseX = Input.GetAxis("Mouse X") * _RotationSpeed*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _RotationSpeed*Time.deltaTime;

        _rotationH += mouseX;
        _rotationV += -mouseY;
        _rotationV=Mathf.Clamp(_rotationV, _MinVerticalAngle, _MaxVerticalAngle);

        transform.rotation = Quaternion.Euler(_rotationV, _rotationH + _initTotationH, 0f);
        character.transform.rotation = Quaternion.Euler(_rotationV, _rotationH + _initTotationH, 0f);
    }
}
