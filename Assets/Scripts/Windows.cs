using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Windows : MonoBehaviour
{
    [SerializeField] private string[] command;

    private InputField cmd;

    private void Start()
    {
        cmd = GetComponent<InputField>();

        //cmd.onValueChanged.AddListener(delegate { RemoveSpaces(); });
    }

    public void Enter()
    {
        //�� ������� ���������� ������������������

        if (cmd.text == command[0])
        {
            cmd.text = "�������, ������� �������� ���������� ��� ������� ������ ���� �� ����������� ������ ����������������";
        }
        else if (cmd.text == command[1])
        {
            cmd.text = "�����, ������������ � ���� ���� ��� ������";
        }
        else if (cmd.text == command[2])
        {
            cmd.text = "�����, ���������� � ���� ���������������� C#, ��� ������ � ������� ����������";
        }
        else if (cmd.text == command[3])
        {
            cmd.text = "�����, ���������� � Unity, ������� ���������� ��� ������������ Collider � Rigidbody �� Collider, ������� �������� Trigger";
        }
        else if (cmd.text == command[4])
        {
            cmd.text = "��������, ����� �����, ����������� ����������� ���������� InputField";
        }
        else
        {
            cmd.text = "notSuccess";
        }
    }

    private void RemoveSpaces()
    {
        cmd.text = cmd.text.Replace(" ", "");
    }
}