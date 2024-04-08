using UnityEngine;

public class ToggleWindows : MonoBehaviour
{
    public GameObject window1; // ������ ����
    public GameObject window2; // ������ ����

    private bool isWindow1Active = true; // ���� ���������� ������� ����

    private void Start()
    {
        // ��� ������� ������� ��������� ������ ����
        ToggleWindowsVisibility(true);
    }

    private void Update()
    {
        // ��������� ������� �� ������ ������ ��� ����� �� ������ (��� ��������� ���������)
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(clickPosition);
            if (collider != null && collider.gameObject == gameObject)
            {
                // ��� ������� �� ������ ����������� ����
                ToggleWindowsVisibility();
            }
        }
    }

    private void ToggleWindowsVisibility()
    {
        if (isWindow1Active)
        {
            // ���� ������ ���� �������, ������������ ��� � ���������� ������ ����
            window1.SetActive(false);
            window2.SetActive(true);
            isWindow1Active = false;
        }
        else
        {
            // ���� ������ ���� �� ������� (�������), ������ ��������
            window1.SetActive(true);
            window2.SetActive(false);
            isWindow1Active = true;
        }
    }

    private void ToggleWindowsVisibility(bool activateFirstWindow)
    {
        if (activateFirstWindow)
        {
            // ��������� ������ ���� � ��������� ������ ����
            window1.SetActive(true);
            window2.SetActive(false);
            isWindow1Active = true;
        }
        else
        {
            // ��������� ������ ���� � ��������� ������ ����
            window1.SetActive(false);
            window2.SetActive(true);
            isWindow1Active = false;
        }
    }
}
