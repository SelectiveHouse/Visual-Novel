using TMPro;

public class TextArchitect
{
    private TextMeshProUGUI tmpProUI;
    private TextMeshPro tmpProWorld;

    public TMP_Text tmpPro => tmpProUI != null ? tmpProUI : tmpProWorld;

    public string currentText => tmpPro.text;
    public string targetText { get; private set; } = string.Empty;
    public string preText { get; private set; } = string.Empty;
    private int preTextLength = 0;

    public string fullTargetText => preText + targetText;


}
