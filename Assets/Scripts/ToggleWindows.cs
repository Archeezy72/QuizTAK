using UnityEngine;

public class ToggleWindows : MonoBehaviour
{
    public GameObject window1; // Первое окно
    public GameObject window2; // Второе окно

    private bool isWindow1Active = true; // Флаг активности первого окна

    private void Start()
    {
        // При запуске скрипта открываем первое окно
        ToggleWindowsVisibility(true);
    }

    private void Update()
    {
        // Проверяем нажатие на спрайт мышкой или тачем на экране (для мобильных устройств)
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 clickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D collider = Physics2D.OverlapPoint(clickPosition);
            if (collider != null && collider.gameObject == gameObject)
            {
                // При нажатии на спрайт переключаем окна
                ToggleWindowsVisibility();
            }
        }
    }

    private void ToggleWindowsVisibility()
    {
        if (isWindow1Active)
        {
            // Если первое окно активно, деактивируем его и активируем второе окно
            window1.SetActive(false);
            window2.SetActive(true);
            isWindow1Active = false;
        }
        else
        {
            // Если первое окно не активно (закрыто), делаем наоборот
            window1.SetActive(true);
            window2.SetActive(false);
            isWindow1Active = true;
        }
    }

    private void ToggleWindowsVisibility(bool activateFirstWindow)
    {
        if (activateFirstWindow)
        {
            // Открываем первое окно и закрываем второе окно
            window1.SetActive(true);
            window2.SetActive(false);
            isWindow1Active = true;
        }
        else
        {
            // Открываем второе окно и закрываем первое окно
            window1.SetActive(false);
            window2.SetActive(true);
            isWindow1Active = false;
        }
    }
}
