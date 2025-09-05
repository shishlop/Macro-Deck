using System.ComponentModel;

namespace SuchByte.MacroDeck.GUI.CustomControls;

public partial class DialogForm : System.Windows.Forms.Form
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool IgnoreEscapeKey { get; set; } = false;

    public DialogForm()
    {
        InitializeComponent();
    }

    protected void SetCloseIconVisible(bool visible)
    {
        this.ControlBox = visible;
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (IgnoreEscapeKey) return base.ProcessCmdKey(ref msg, keyData);
        switch (keyData)
        {
            case Keys.Escape:
                Close();
                return true;
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }
}