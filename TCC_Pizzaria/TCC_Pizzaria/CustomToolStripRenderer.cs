using System.Drawing;
using System.Windows.Forms;

public class CustomToolStripRenderer : ToolStripProfessionalRenderer
{
    Color customColor = ColorTranslator.FromHtml("#335db0");
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        if (e.Item.Selected)
        {
            // Define a cor de fundo do item selecionado
            e.Graphics.FillRectangle(new SolidBrush(customColor), e.Item.Bounds);
        }
        else
        {
            base.OnRenderMenuItemBackground(e);
        }
    }
}
