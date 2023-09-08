using Plugins.DataService;
using UnityEngine;
using UnityEngine.UI;

public class SliderDataController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Slider _slider;

    #region MonoBehaviour

    private void OnValidate()
    {
        _slider ??= GetComponent<Slider>();
    }

    private void Awake()
    {
        _slider.value = DataService.Load("slider", 0f);
    }

    private void OnDestroy()
    {
        DataService.Save(_slider.value, "slider");
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        DataService.Save(_slider.value, "slider");
    }

    private void OnApplicationFocus(bool hasFocus)
    {
        DataService.Save(_slider.value, "slider");
    }

    #endregion
}
