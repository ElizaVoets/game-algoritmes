using UnityEngine;

public class FloodFill : MonoBehaviour
{
    [SerializeField] private Color replaceColor = Color.red;

    public Color ReplaceColor => replaceColor;

    public void StartFloodFill(ColorGrid colorGrid, int startX, int startY, Color newColor)
    {
        if (colorGrid == null) return;

        if (startX < 0 || startX >= colorGrid.Width || startY < 0 || startY >= colorGrid.Height) return;

        Color targetColor = colorGrid.GetPixel(startX, startY);
        FloodFillArea(colorGrid, startX, startY, targetColor, newColor);
    }

    // opdracht: laat deze method werken
    private void FloodFillArea(ColorGrid colorGrid, int x, int y, Color targetColor, Color replacementColor)
    {
        if (x >= colorGrid.Width || x < 0 || y < 0 || y >= colorGrid.Height)
        {
            return;
        }

        Color currentColor = colorGrid.GetPixel(x, y);
        if (currentColor != targetColor)
        {
            return;
        }
        if (currentColor == replacementColor)
        {
            return;
        }

        colorGrid.SetPixel(replacementColor, x, y);
        FloodFillArea(colorGrid, x - 1, y, targetColor, replacementColor);
        FloodFillArea(colorGrid, x + 1, y, targetColor, replacementColor);
        FloodFillArea(colorGrid, x, y - 1, targetColor, replacementColor);
        FloodFillArea(colorGrid, x, y + 1, targetColor, replacementColor);
    }

}