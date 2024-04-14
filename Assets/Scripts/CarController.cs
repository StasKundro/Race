using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public float moveSpeed;
    public float targetMoveSpeed;
    public float speedIncreaseRate;
    public float maxMoveSpeed;
    public AudioSource audioSource;
    public TMP_Text speedText;
    public float maxXLimit = 5f; // ������������ �������� �� ��� X
    public float smoothMovement = 2f; // �������� �������� �������� ������ � �����
    public float rotationAngle = 5f;
    private float currentRotation = 0f;
    public float swayAmount = 0.05f; // ��������� �����������
    public float swaySpeed = 1f; // �������� �����������
    public GameObject cam;

    public void Start()
    {
        moveSpeed = 20; 
        PlayerPrefs.SetFloat("MoveSpeed", moveSpeed);
    }

    void Update()
    {
        float pitch = audioSource.pitch;

        // ��� ������� ������� W ����������� targetMoveSpeed � ���������� Pitch
        if (Input.GetKeyDown(KeyCode.W) && pitch >= 1.7f && targetMoveSpeed < maxMoveSpeed)
        {
            targetMoveSpeed += 20;
            PlayerPrefs.SetFloat("MoveSpeed", moveSpeed);

            // ���������� Pitch �� 0.7
            audioSource.pitch = 0.7f;
        }

        float horizontalInput = Input.GetAxis("Horizontal");
        MoveObject(horizontalInput);
    }

    private void MoveObject(float horizontalInput)
    {
        // ������� �������� ������ ��� �����
        float newX = Mathf.Clamp(transform.position.x + horizontalInput * moveSpeed * Time.deltaTime * smoothMovement, -maxXLimit, maxXLimit);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        if (horizontalInput != 0)
        {
            currentRotation = Mathf.Lerp(currentRotation, horizontalInput * rotationAngle, Time.deltaTime * 10);
            transform.rotation = Quaternion.Euler(0f, currentRotation, 0f);
        }
        else
        {
            currentRotation = Mathf.Lerp(currentRotation, 0f, Time.deltaTime * 10);
            transform.rotation = Quaternion.Euler(0f, currentRotation, 0f);
        }
    }

    void FixedUpdate()
    {
        moveSpeed = PlayerPrefs.GetFloat("MoveSpeed", moveSpeed);

        // ����������� moveSpeed �� ���� ���������� �������� ��������
        if (moveSpeed < targetMoveSpeed)
        {
            moveSpeed += speedIncreaseRate * Time.deltaTime;
            PlayerPrefs.SetFloat("MoveSpeed", moveSpeed);

            // ����������� Pitch ����� ��������� � ����������� �� moveSpeed
            float pitch = Mathf.Lerp(0.7f, 1.7f, (moveSpeed - 10f) / (targetMoveSpeed - 10f));
            audioSource.pitch = pitch;
        }
        speedText.text = Mathf.Round(moveSpeed).ToString();

        Camera.main.fieldOfView = Mathf.Lerp(Camera.main.fieldOfView, 60f + (moveSpeed/20), Time.deltaTime * 5f);
        // ����������� �� ��� Y
        float swayY = Mathf.Sin(Time.time * swaySpeed) * swayAmount;
        // ����������� �� ��� X
        float swayX = Mathf.Sin(Time.time * swaySpeed * 0.7f) * swayAmount;
        // ����������� �� ��� Z
        float swayZ = Mathf.Sin(Time.time * swaySpeed * 1.3f) * swayAmount;

        cam.transform.rotation = Quaternion.Euler(swayX, currentRotation + swayY, swayZ);
    }
}