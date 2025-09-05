using System.ComponentModel;
using System.Windows.Forms;
using SuchByte.MacroDeck.GUI.CustomControls;

namespace SuchByte.MacroDeck.GUI;

public partial class ButtonEditor
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (this.actionButton != null)
        {
            this.actionButton.StateChanged -= this.OnStateChanged;
        }
        if (this.actionButtonEdited != null)
        {
            this.actionButtonEdited.StateChanged -= this.OnStateChanged;
        }
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new Container();
        btnApply = new ButtonPrimary();
        btnPreview = new RoundedButton();
        labelText = new RoundedTextBox();
        fontSize = new NumericUpDown();
        lblButtonState = new Label();
        radioButtonOff = new ButtonRadioButton();
        radioButtonOn = new ButtonRadioButton();
        panel1 = new Panel();
        panel2 = new Panel();
        label2 = new Label();
        labelAlignBottom = new ButtonRadioButton();
        labelAlignCenter = new ButtonRadioButton();
        labelAlignTop = new ButtonRadioButton();
        btnEditIcon = new PictureButton();
        btnRemoveIcon = new PictureButton();
        btnClearLabelText = new PictureButton();
        btnBackColor = new ButtonPrimary();
        btnOpenTemplateEditor = new PictureButton();
        btnAddVariable = new PictureButton();
        btnForeColor = new ButtonPrimary();
        fonts = new RoundedComboBox();
        lblCurrentState = new Label();
        lblCurrentStateLabel = new Label();
        btnOk = new ButtonPrimary();
        variablesContextMenu = new ContextMenuStrip(components);
        lblStateBinding = new Label();
        listStateBinding = new RoundedComboBox();
        btnDeleteStateBinding = new PictureButton();
        selectorPanel = new Panel();
        flowLayoutPanel1 = new FlowLayoutPanel();
        radioOnPress = new ButtonRadioButton();
        radioOnRelease = new ButtonRadioButton();
        radioOnLongPress = new ButtonRadioButton();
        radioOnLongPressRelease = new ButtonRadioButton();
        radioOnEvent = new ButtonRadioButton();
        btnRemoveHotkey = new PictureButton();
        hotkey = new RoundedTextBox();
        btnEditJson = new ButtonPrimary();
        label1 = new Label();
        buttonGUIDLabel = new TextBox();
        lblAppearance = new Label();
        panel3 = new Panel();
        lblState = new Label();
        lblKeyBinding = new Label();
        lblActions = new Label();
        panel4 = new Panel();
        ((ISupportInitialize)btnPreview).BeginInit();
        ((ISupportInitialize)fontSize).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((ISupportInitialize)btnEditIcon).BeginInit();
        ((ISupportInitialize)btnRemoveIcon).BeginInit();
        ((ISupportInitialize)btnClearLabelText).BeginInit();
        ((ISupportInitialize)btnOpenTemplateEditor).BeginInit();
        ((ISupportInitialize)btnAddVariable).BeginInit();
        ((ISupportInitialize)btnDeleteStateBinding).BeginInit();
        flowLayoutPanel1.SuspendLayout();
        ((ISupportInitialize)btnRemoveHotkey).BeginInit();
        panel3.SuspendLayout();
        SuspendLayout();
        // 
        // btnApply
        // 
        btnApply.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnApply.BorderRadius = 8;
        btnApply.Cursor = Cursors.Hand;
        btnApply.FlatStyle = FlatStyle.Flat;
        btnApply.Font = new Font("Tahoma", 9.75F);
        btnApply.ForeColor = Color.White;
        btnApply.Location = new Point(1932, 1048);
        btnApply.Margin = new Padding(9);
        btnApply.Name = "btnApply";
        btnApply.Progress = 0;
        btnApply.Size = new Size(154, 52);
        btnApply.TabIndex = 1;
        btnApply.Text = "Apply";
        btnApply.UseMnemonic = false;
        btnApply.UseVisualStyleBackColor = true;
        btnApply.Click += BtnSave_Click;
        // 
        // btnPreview
        // 
        btnPreview.BackColor = Color.FromArgb(35, 35, 35);
        btnPreview.BackgroundImageLayout = ImageLayout.Stretch;
        btnPreview.Cursor = Cursors.Hand;
        btnPreview.Font = new Font("Tahoma", 15.75F, FontStyle.Bold);
        btnPreview.ForeColor = Color.White;
        btnPreview.Location = new Point(10, 150);
        btnPreview.Margin = new Padding(9);
        btnPreview.Name = "btnPreview";
        btnPreview.Size = new Size(210, 210);
        btnPreview.SizeMode = PictureBoxSizeMode.StretchImage;
        btnPreview.TabIndex = 3;
        btnPreview.TabStop = false;
        btnPreview.Click += BtnPreview_Click;
        // 
        // labelText
        // 
        labelText.AutoScroll = true;
        labelText.BackColor = Color.FromArgb(55, 55, 55);
        labelText.Cursor = Cursors.Hand;
        labelText.Font = new Font("Tahoma", 11.25F);
        labelText.Location = new Point(9, 378);
        labelText.Margin = new Padding(9);
        labelText.Name = "labelText";
        labelText.Padding = new Padding(18, 12, 18, 12);
        labelText.Size = new Size(434, 58);
        labelText.TabIndex = 23;
        labelText.TabStop = false;
        labelText.TextChanged += LabelChanged;
        // 
        // fontSize
        // 
        fontSize.BackColor = Color.FromArgb(55, 55, 55);
        fontSize.BorderStyle = BorderStyle.FixedSingle;
        fontSize.Font = new Font("Tahoma", 11.25F);
        fontSize.ForeColor = Color.White;
        fontSize.Location = new Point(357, 637);
        fontSize.Margin = new Padding(9);
        fontSize.Maximum = new decimal(new int[] { 18, 0, 0, 0 });
        fontSize.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
        fontSize.Name = "fontSize";
        fontSize.Size = new Size(96, 39);
        fontSize.TabIndex = 10;
        fontSize.TabStop = false;
        fontSize.Value = new decimal(new int[] { 6, 0, 0, 0 });
        fontSize.ValueChanged += LabelChanged;
        // 
        // lblButtonState
        // 
        lblButtonState.Font = new Font("Tahoma", 9.75F);
        lblButtonState.Location = new Point(2, 24);
        lblButtonState.Margin = new Padding(9, 0, 9, 0);
        lblButtonState.Name = "lblButtonState";
        lblButtonState.Size = new Size(275, 49);
        lblButtonState.TabIndex = 12;
        lblButtonState.Text = "Button state";
        lblButtonState.TextAlign = ContentAlignment.MiddleLeft;
        lblButtonState.UseMnemonic = false;
        // 
        // radioButtonOff
        // 
        radioButtonOff.Checked = true;
        radioButtonOff.Cursor = Cursors.Hand;
        radioButtonOff.Font = new Font("Tahoma", 9.75F);
        radioButtonOff.Location = new Point(278, 25);
        radioButtonOff.Margin = new Padding(9);
        radioButtonOff.Name = "radioButtonOff";
        radioButtonOff.Size = new Size(108, 49);
        radioButtonOff.TabIndex = 13;
        radioButtonOff.TabStop = true;
        radioButtonOff.Text = "Off";
        radioButtonOff.UseMnemonic = false;
        radioButtonOff.UseVisualStyleBackColor = true;
        radioButtonOff.CheckedChanged += RadioButton_CheckedChanged;
        // 
        // radioButtonOn
        // 
        radioButtonOn.Cursor = Cursors.Hand;
        radioButtonOn.Font = new Font("Tahoma", 9.75F);
        radioButtonOn.Location = new Point(392, 24);
        radioButtonOn.Margin = new Padding(9);
        radioButtonOn.Name = "radioButtonOn";
        radioButtonOn.Size = new Size(108, 49);
        radioButtonOn.TabIndex = 14;
        radioButtonOn.Text = "On";
        radioButtonOn.UseMnemonic = false;
        radioButtonOn.UseVisualStyleBackColor = true;
        radioButtonOn.CheckedChanged += RadioButton_CheckedChanged;
        // 
        // panel1
        // 
        panel1.Controls.Add(lblButtonState);
        panel1.Controls.Add(radioButtonOn);
        panel1.Controls.Add(radioButtonOff);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 48);
        panel1.Margin = new Padding(9);
        panel1.Name = "panel1";
        panel1.Size = new Size(500, 74);
        panel1.TabIndex = 15;
        // 
        // panel2
        // 
        panel2.Controls.Add(label2);
        panel2.Controls.Add(labelAlignBottom);
        panel2.Controls.Add(labelAlignCenter);
        panel2.Controls.Add(labelAlignTop);
        panel2.Font = new Font("Tahoma", 9.75F);
        panel2.Location = new Point(10, 567);
        panel2.Margin = new Padding(9);
        panel2.Name = "panel2";
        panel2.Size = new Size(499, 49);
        panel2.TabIndex = 16;
        // 
        // label2
        // 
        label2.Font = new Font("Tahoma", 9.75F);
        label2.Location = new Point(0, 0);
        label2.Margin = new Padding(9, 0, 9, 0);
        label2.Name = "label2";
        label2.Size = new Size(304, 47);
        label2.TabIndex = 29;
        label2.Text = "Align label:";
        label2.TextAlign = ContentAlignment.MiddleLeft;
        label2.UseMnemonic = false;
        // 
        // labelAlignBottom
        // 
        labelAlignBottom.Checked = true;
        labelAlignBottom.Cursor = Cursors.Hand;
        labelAlignBottom.Font = new Font("Tahoma", 11.25F);
        labelAlignBottom.Location = new Point(320, 0);
        labelAlignBottom.Margin = new Padding(9);
        labelAlignBottom.Name = "labelAlignBottom";
        labelAlignBottom.Size = new Size(47, 47);
        labelAlignBottom.TabIndex = 11;
        labelAlignBottom.TabStop = true;
        labelAlignBottom.UseMnemonic = false;
        labelAlignBottom.UseVisualStyleBackColor = true;
        labelAlignBottom.CheckedChanged += LabelChanged;
        // 
        // labelAlignCenter
        // 
        labelAlignCenter.Cursor = Cursors.Hand;
        labelAlignCenter.Font = new Font("Tahoma", 11.25F);
        labelAlignCenter.Location = new Point(382, 0);
        labelAlignCenter.Margin = new Padding(9);
        labelAlignCenter.Name = "labelAlignCenter";
        labelAlignCenter.Size = new Size(47, 47);
        labelAlignCenter.TabIndex = 10;
        labelAlignCenter.UseMnemonic = false;
        labelAlignCenter.UseVisualStyleBackColor = true;
        labelAlignCenter.CheckedChanged += LabelChanged;
        // 
        // labelAlignTop
        // 
        labelAlignTop.Cursor = Cursors.Hand;
        labelAlignTop.Font = new Font("Tahoma", 11.25F);
        labelAlignTop.Location = new Point(446, 0);
        labelAlignTop.Margin = new Padding(9);
        labelAlignTop.Name = "labelAlignTop";
        labelAlignTop.Size = new Size(47, 47);
        labelAlignTop.TabIndex = 9;
        labelAlignTop.UseMnemonic = false;
        labelAlignTop.UseVisualStyleBackColor = true;
        labelAlignTop.CheckedChanged += LabelChanged;
        // 
        // btnEditIcon
        // 
        btnEditIcon.BackColor = Color.Transparent;
        btnEditIcon.BackgroundImage = Properties.Resources.Edit_Normal;
        btnEditIcon.BackgroundImageLayout = ImageLayout.Stretch;
        btnEditIcon.Cursor = Cursors.Hand;
        btnEditIcon.Font = new Font("Tahoma", 9.75F);
        btnEditIcon.ForeColor = Color.White;
        btnEditIcon.Location = new Point(238, 178);
        btnEditIcon.Margin = new Padding(9);
        btnEditIcon.Name = "btnEditIcon";
        btnEditIcon.Size = new Size(47, 47);
        btnEditIcon.TabIndex = 17;
        btnEditIcon.TabStop = false;
        btnEditIcon.Click += BtnEditIcon_Click;
        // 
        // btnRemoveIcon
        // 
        btnRemoveIcon.BackColor = Color.Transparent;
        btnRemoveIcon.BackgroundImage = Properties.Resources.Delete_Normal;
        btnRemoveIcon.BackgroundImageLayout = ImageLayout.Stretch;
        btnRemoveIcon.Cursor = Cursors.Hand;
        btnRemoveIcon.Font = new Font("Tahoma", 9.75F);
        btnRemoveIcon.ForeColor = Color.White;
        btnRemoveIcon.Location = new Point(238, 243);
        btnRemoveIcon.Margin = new Padding(9);
        btnRemoveIcon.Name = "btnRemoveIcon";
        btnRemoveIcon.Size = new Size(47, 47);
        btnRemoveIcon.TabIndex = 18;
        btnRemoveIcon.TabStop = false;
        btnRemoveIcon.Click += BtnRemoveIcon_Click;
        // 
        // btnClearLabelText
        // 
        btnClearLabelText.BackColor = Color.Transparent;
        btnClearLabelText.BackgroundImage = Properties.Resources.Delete_Normal;
        btnClearLabelText.BackgroundImageLayout = ImageLayout.Stretch;
        btnClearLabelText.Cursor = Cursors.Hand;
        btnClearLabelText.Font = new Font("Tahoma", 9.75F);
        btnClearLabelText.ForeColor = Color.White;
        btnClearLabelText.Location = new Point(462, 438);
        btnClearLabelText.Margin = new Padding(9);
        btnClearLabelText.Name = "btnClearLabelText";
        btnClearLabelText.Size = new Size(47, 47);
        btnClearLabelText.TabIndex = 19;
        btnClearLabelText.TabStop = false;
        btnClearLabelText.Click += BtnClearLabelText_Click;
        // 
        // btnBackColor
        // 
        btnBackColor.BackgroundImageLayout = ImageLayout.Stretch;
        btnBackColor.BorderRadius = 8;
        btnBackColor.Cursor = Cursors.Hand;
        btnBackColor.FlatAppearance.BorderSize = 0;
        btnBackColor.FlatStyle = FlatStyle.Flat;
        btnBackColor.Font = new Font("Tahoma", 9.75F);
        btnBackColor.ForeColor = Color.White;
        btnBackColor.Location = new Point(238, 308);
        btnBackColor.Margin = new Padding(9);
        btnBackColor.Name = "btnBackColor";
        btnBackColor.Progress = 0;
        btnBackColor.Size = new Size(47, 47);
        btnBackColor.TabIndex = 25;
        btnBackColor.UseMnemonic = false;
        btnBackColor.UseVisualStyleBackColor = false;
        btnBackColor.Click += BtnBackColor_Click;
        // 
        // btnOpenTemplateEditor
        // 
        btnOpenTemplateEditor.BackColor = Color.Transparent;
        btnOpenTemplateEditor.BackgroundImage = Properties.Resources.Arrow_Top_Right_Normal;
        btnOpenTemplateEditor.BackgroundImageLayout = ImageLayout.Stretch;
        btnOpenTemplateEditor.Cursor = Cursors.Hand;
        btnOpenTemplateEditor.Font = new Font("Tahoma", 9.75F);
        btnOpenTemplateEditor.ForeColor = Color.White;
        btnOpenTemplateEditor.Location = new Point(460, 378);
        btnOpenTemplateEditor.Margin = new Padding(9);
        btnOpenTemplateEditor.Name = "btnOpenTemplateEditor";
        btnOpenTemplateEditor.Size = new Size(47, 47);
        btnOpenTemplateEditor.TabIndex = 24;
        btnOpenTemplateEditor.TabStop = false;
        btnOpenTemplateEditor.Click += BtnOpenTemplateEditor_Click;
        // 
        // btnAddVariable
        // 
        btnAddVariable.BackColor = Color.Transparent;
        btnAddVariable.BackgroundImage = Properties.Resources.Variable_Normal;
        btnAddVariable.BackgroundImageLayout = ImageLayout.Stretch;
        btnAddVariable.Cursor = Cursors.Hand;
        btnAddVariable.Font = new Font("Tahoma", 8.25F);
        btnAddVariable.ForeColor = Color.White;
        btnAddVariable.Location = new Point(462, 495);
        btnAddVariable.Margin = new Padding(9);
        btnAddVariable.Name = "btnAddVariable";
        btnAddVariable.Size = new Size(47, 47);
        btnAddVariable.TabIndex = 22;
        btnAddVariable.TabStop = false;
        btnAddVariable.Click += BtnAddVariable_Click;
        // 
        // btnForeColor
        // 
        btnForeColor.BackgroundImageLayout = ImageLayout.Stretch;
        btnForeColor.BorderRadius = 8;
        btnForeColor.Cursor = Cursors.Hand;
        btnForeColor.FlatAppearance.BorderSize = 0;
        btnForeColor.FlatStyle = FlatStyle.Flat;
        btnForeColor.Font = new Font("Tahoma", 9.75F);
        btnForeColor.ForeColor = Color.White;
        btnForeColor.Location = new Point(464, 637);
        btnForeColor.Margin = new Padding(9);
        btnForeColor.Name = "btnForeColor";
        btnForeColor.Progress = 0;
        btnForeColor.Size = new Size(46, 46);
        btnForeColor.TabIndex = 21;
        btnForeColor.UseMnemonic = false;
        btnForeColor.UseVisualStyleBackColor = false;
        btnForeColor.Click += BtnForeColor_Click;
        // 
        // fonts
        // 
        fonts.BackColor = Color.FromArgb(65, 65, 65);
        fonts.Cursor = Cursors.Hand;
        fonts.Font = new Font("Tahoma", 9.75F);
        fonts.ForeColor = Color.White;
        fonts.Location = new Point(10, 634);
        fonts.Margin = new Padding(9, 10, 9, 10);
        fonts.Name = "fonts";
        fonts.Padding = new Padding(18, 4, 18, 4);
        fonts.Size = new Size(334, 44);
        fonts.TabIndex = 20;
        fonts.SelectedIndexChanged += LabelChanged;
        // 
        // lblCurrentState
        // 
        lblCurrentState.Font = new Font("Tahoma", 9.75F);
        lblCurrentState.Location = new Point(385, 772);
        lblCurrentState.Margin = new Padding(9, 0, 9, 0);
        lblCurrentState.Name = "lblCurrentState";
        lblCurrentState.Size = new Size(122, 49);
        lblCurrentState.TabIndex = 22;
        lblCurrentState.Text = "Off";
        lblCurrentState.TextAlign = ContentAlignment.MiddleLeft;
        lblCurrentState.UseMnemonic = false;
        // 
        // lblCurrentStateLabel
        // 
        lblCurrentStateLabel.Font = new Font("Tahoma", 9.75F);
        lblCurrentStateLabel.Location = new Point(10, 772);
        lblCurrentStateLabel.Margin = new Padding(9, 0, 9, 0);
        lblCurrentStateLabel.Name = "lblCurrentStateLabel";
        lblCurrentStateLabel.Size = new Size(357, 49);
        lblCurrentStateLabel.TabIndex = 23;
        lblCurrentStateLabel.Text = "Current state:";
        lblCurrentStateLabel.TextAlign = ContentAlignment.MiddleLeft;
        lblCurrentStateLabel.UseMnemonic = false;
        // 
        // btnOk
        // 
        btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnOk.BorderRadius = 8;
        btnOk.Cursor = Cursors.Hand;
        btnOk.FlatStyle = FlatStyle.Flat;
        btnOk.Font = new Font("Tahoma", 9.75F);
        btnOk.ForeColor = Color.White;
        btnOk.Location = new Point(1762, 1048);
        btnOk.Margin = new Padding(9);
        btnOk.Name = "btnOk";
        btnOk.Progress = 0;
        btnOk.Size = new Size(154, 52);
        btnOk.TabIndex = 25;
        btnOk.Text = "Ok";
        btnOk.UseMnemonic = false;
        btnOk.UseVisualStyleBackColor = true;
        btnOk.Click += BtnOk_Click;
        // 
        // variablesContextMenu
        // 
        variablesContextMenu.BackColor = Color.FromArgb(45, 45, 45);
        variablesContextMenu.Font = new Font("Tahoma", 9.75F);
        variablesContextMenu.ImageScalingSize = new Size(28, 28);
        variablesContextMenu.Name = "variablesContextMenu";
        variablesContextMenu.ShowImageMargin = false;
        variablesContextMenu.ShowItemToolTips = false;
        variablesContextMenu.Size = new Size(36, 4);
        // 
        // lblStateBinding
        // 
        lblStateBinding.Font = new Font("Tahoma", 9.75F);
        lblStateBinding.Location = new Point(10, 821);
        lblStateBinding.Margin = new Padding(9, 0, 9, 0);
        lblStateBinding.Name = "lblStateBinding";
        lblStateBinding.Size = new Size(494, 30);
        lblStateBinding.TabIndex = 26;
        lblStateBinding.Text = "State binding:";
        lblStateBinding.TextAlign = ContentAlignment.MiddleLeft;
        lblStateBinding.UseMnemonic = false;
        // 
        // listStateBinding
        // 
        listStateBinding.BackColor = Color.FromArgb(65, 65, 65);
        listStateBinding.Cursor = Cursors.Hand;
        listStateBinding.Font = new Font("Tahoma", 9F);
        listStateBinding.ForeColor = Color.White;
        listStateBinding.Location = new Point(10, 859);
        listStateBinding.Margin = new Padding(9);
        listStateBinding.Name = "listStateBinding";
        listStateBinding.Padding = new Padding(18, 4, 18, 4);
        listStateBinding.Size = new Size(443, 41);
        listStateBinding.TabIndex = 27;
        listStateBinding.SelectedIndexChanged += ListStateBinding_SelectedIndexChanged;
        // 
        // btnDeleteStateBinding
        // 
        btnDeleteStateBinding.BackColor = Color.Transparent;
        btnDeleteStateBinding.BackgroundImage = Properties.Resources.Delete_Normal;
        btnDeleteStateBinding.BackgroundImageLayout = ImageLayout.Stretch;
        btnDeleteStateBinding.Cursor = Cursors.Hand;
        btnDeleteStateBinding.Font = new Font("Tahoma", 9.75F);
        btnDeleteStateBinding.ForeColor = Color.White;
        btnDeleteStateBinding.Location = new Point(462, 859);
        btnDeleteStateBinding.Margin = new Padding(9);
        btnDeleteStateBinding.Name = "btnDeleteStateBinding";
        btnDeleteStateBinding.Size = new Size(47, 47);
        btnDeleteStateBinding.TabIndex = 28;
        btnDeleteStateBinding.TabStop = false;
        btnDeleteStateBinding.Click += BtnDeleteStateBinding_Click;
        // 
        // selectorPanel
        // 
        selectorPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        selectorPanel.Location = new Point(542, 142);
        selectorPanel.Margin = new Padding(9);
        selectorPanel.Name = "selectorPanel";
        selectorPanel.Size = new Size(1544, 889);
        selectorPanel.TabIndex = 29;
        // 
        // flowLayoutPanel1
        // 
        flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        flowLayoutPanel1.AutoScroll = true;
        flowLayoutPanel1.AutoScrollMargin = new Size(0, 30);
        flowLayoutPanel1.Controls.Add(radioOnPress);
        flowLayoutPanel1.Controls.Add(radioOnRelease);
        flowLayoutPanel1.Controls.Add(radioOnLongPress);
        flowLayoutPanel1.Controls.Add(radioOnLongPressRelease);
        flowLayoutPanel1.Controls.Add(radioOnEvent);
        flowLayoutPanel1.Font = new Font("Tahoma", 12F);
        flowLayoutPanel1.Location = new Point(541, 86);
        flowLayoutPanel1.Margin = new Padding(0);
        flowLayoutPanel1.Name = "flowLayoutPanel1";
        flowLayoutPanel1.Size = new Size(1535, 47);
        flowLayoutPanel1.TabIndex = 30;
        // 
        // radioOnPress
        // 
        radioOnPress.AutoSize = true;
        radioOnPress.Checked = true;
        radioOnPress.Cursor = Cursors.Hand;
        radioOnPress.Font = new Font("Tahoma", 11.25F);
        radioOnPress.Location = new Point(0, 0);
        radioOnPress.Margin = new Padding(0, 0, 10, 0);
        radioOnPress.Name = "radioOnPress";
        radioOnPress.Size = new Size(145, 37);
        radioOnPress.TabIndex = 0;
        radioOnPress.TabStop = true;
        radioOnPress.Text = "On press";
        radioOnPress.UseMnemonic = false;
        radioOnPress.UseVisualStyleBackColor = true;
        radioOnPress.CheckedChanged += RadioOnPress_CheckedChanged;
        // 
        // radioOnRelease
        // 
        radioOnRelease.AutoSize = true;
        radioOnRelease.Cursor = Cursors.Hand;
        radioOnRelease.Font = new Font("Tahoma", 11.25F);
        radioOnRelease.Location = new Point(155, 0);
        radioOnRelease.Margin = new Padding(0, 0, 10, 0);
        radioOnRelease.Name = "radioOnRelease";
        radioOnRelease.Size = new Size(166, 37);
        radioOnRelease.TabIndex = 2;
        radioOnRelease.Text = "On release";
        radioOnRelease.UseMnemonic = false;
        radioOnRelease.UseVisualStyleBackColor = true;
        radioOnRelease.CheckedChanged += RadioOnRelease_CheckedChanged;
        // 
        // radioOnLongPress
        // 
        radioOnLongPress.AutoSize = true;
        radioOnLongPress.Cursor = Cursors.Hand;
        radioOnLongPress.Font = new Font("Tahoma", 11.25F);
        radioOnLongPress.Location = new Point(331, 0);
        radioOnLongPress.Margin = new Padding(0, 0, 10, 0);
        radioOnLongPress.Name = "radioOnLongPress";
        radioOnLongPress.Size = new Size(204, 37);
        radioOnLongPress.TabIndex = 3;
        radioOnLongPress.Text = "On long press";
        radioOnLongPress.UseMnemonic = false;
        radioOnLongPress.UseVisualStyleBackColor = true;
        radioOnLongPress.CheckedChanged += RadioOnLongPress_CheckedChanged;
        // 
        // radioOnLongPressRelease
        // 
        radioOnLongPressRelease.AutoSize = true;
        radioOnLongPressRelease.Cursor = Cursors.Hand;
        radioOnLongPressRelease.Font = new Font("Tahoma", 11.25F);
        radioOnLongPressRelease.Location = new Point(545, 0);
        radioOnLongPressRelease.Margin = new Padding(0, 0, 10, 0);
        radioOnLongPressRelease.Name = "radioOnLongPressRelease";
        radioOnLongPressRelease.Size = new Size(296, 37);
        radioOnLongPressRelease.TabIndex = 4;
        radioOnLongPressRelease.Text = "On long press release";
        radioOnLongPressRelease.UseMnemonic = false;
        radioOnLongPressRelease.UseVisualStyleBackColor = true;
        radioOnLongPressRelease.CheckedChanged += RadioOnLongPressRelease_CheckedChanged;
        // 
        // radioOnEvent
        // 
        radioOnEvent.AutoSize = true;
        radioOnEvent.Cursor = Cursors.Hand;
        radioOnEvent.Font = new Font("Tahoma", 11.25F);
        radioOnEvent.Location = new Point(851, 0);
        radioOnEvent.Margin = new Padding(0, 0, 10, 0);
        radioOnEvent.Name = "radioOnEvent";
        radioOnEvent.Size = new Size(147, 37);
        radioOnEvent.TabIndex = 1;
        radioOnEvent.Text = "On event";
        radioOnEvent.UseMnemonic = false;
        radioOnEvent.UseVisualStyleBackColor = true;
        radioOnEvent.CheckedChanged += RadioOnEvent_CheckedChanged;
        // 
        // btnRemoveHotkey
        // 
        btnRemoveHotkey.BackColor = Color.Transparent;
        btnRemoveHotkey.BackgroundImage = Properties.Resources.Delete_Normal;
        btnRemoveHotkey.BackgroundImageLayout = ImageLayout.Stretch;
        btnRemoveHotkey.Cursor = Cursors.Hand;
        btnRemoveHotkey.Font = new Font("Tahoma", 9.75F);
        btnRemoveHotkey.ForeColor = Color.White;
        btnRemoveHotkey.Location = new Point(462, 1010);
        btnRemoveHotkey.Margin = new Padding(9);
        btnRemoveHotkey.Name = "btnRemoveHotkey";
        btnRemoveHotkey.Size = new Size(47, 47);
        btnRemoveHotkey.TabIndex = 20;
        btnRemoveHotkey.TabStop = false;
        btnRemoveHotkey.Click += BtnRemoveHotkey_Click;
        // 
        // hotkey
        // 
        hotkey.BackColor = Color.FromArgb(65, 65, 65);
        hotkey.Cursor = Cursors.Hand;
        hotkey.Font = new Font("Tahoma", 9F);
        hotkey.Location = new Point(10, 1006);
        hotkey.Margin = new Padding(9);
        hotkey.Name = "hotkey";
        hotkey.Padding = new Padding(61, 12, 18, 12);
        hotkey.Size = new Size(443, 50);
        hotkey.TabIndex = 0;
        hotkey.TabStop = false;
        // 
        // btnEditJson
        // 
        btnEditJson.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnEditJson.BorderRadius = 8;
        btnEditJson.Cursor = Cursors.Hand;
        btnEditJson.FlatAppearance.BorderSize = 0;
        btnEditJson.FlatStyle = FlatStyle.Flat;
        btnEditJson.Font = new Font("Tahoma", 9.75F);
        btnEditJson.ForeColor = Color.White;
        btnEditJson.Location = new Point(542, 1048);
        btnEditJson.Margin = new Padding(9);
        btnEditJson.Name = "btnEditJson";
        btnEditJson.Progress = 0;
        btnEditJson.Size = new Size(203, 52);
        btnEditJson.TabIndex = 33;
        btnEditJson.Text = "Edit JSON";
        btnEditJson.UseMnemonic = false;
        btnEditJson.UseVisualStyleBackColor = true;
        btnEditJson.Click += BtnEditJson_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        label1.Location = new Point(782, 1048);
        label1.Margin = new Padding(9, 0, 9, 0);
        label1.Name = "label1";
        label1.Size = new Size(102, 52);
        label1.TabIndex = 34;
        label1.Text = "GUID:";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // buttonGUIDLabel
        // 
        buttonGUIDLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        buttonGUIDLabel.BackColor = Color.FromArgb(45, 45, 45);
        buttonGUIDLabel.BorderStyle = BorderStyle.None;
        buttonGUIDLabel.ForeColor = Color.White;
        buttonGUIDLabel.Location = new Point(901, 1059);
        buttonGUIDLabel.Margin = new Padding(9);
        buttonGUIDLabel.Name = "buttonGUIDLabel";
        buttonGUIDLabel.ReadOnly = true;
        buttonGUIDLabel.Size = new Size(700, 28);
        buttonGUIDLabel.TabIndex = 35;
        // 
        // lblAppearance
        // 
        lblAppearance.BackColor = Color.FromArgb(35, 35, 35);
        lblAppearance.Dock = DockStyle.Top;
        lblAppearance.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
        lblAppearance.Location = new Point(0, 0);
        lblAppearance.Margin = new Padding(7, 0, 7, 0);
        lblAppearance.Name = "lblAppearance";
        lblAppearance.Size = new Size(500, 61);
        lblAppearance.TabIndex = 36;
        lblAppearance.Text = "Appearance";
        lblAppearance.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panel3
        // 
        panel3.BackColor = Color.FromArgb(35, 35, 35);
        panel3.Controls.Add(lblAppearance);
        panel3.Controls.Add(panel1);
        panel3.Location = new Point(9, 9);
        panel3.Margin = new Padding(7);
        panel3.Name = "panel3";
        panel3.Size = new Size(500, 122);
        panel3.TabIndex = 37;
        // 
        // lblState
        // 
        lblState.BackColor = Color.FromArgb(35, 35, 35);
        lblState.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
        lblState.Location = new Point(9, 710);
        lblState.Margin = new Padding(7, 0, 7, 0);
        lblState.Name = "lblState";
        lblState.Size = new Size(500, 61);
        lblState.TabIndex = 37;
        lblState.Text = "Button state";
        lblState.TextAlign = ContentAlignment.MiddleLeft;
        lblState.Click += label4_Click;
        // 
        // lblKeyBinding
        // 
        lblKeyBinding.BackColor = Color.FromArgb(35, 35, 35);
        lblKeyBinding.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
        lblKeyBinding.Location = new Point(10, 936);
        lblKeyBinding.Margin = new Padding(7, 0, 7, 0);
        lblKeyBinding.Name = "lblKeyBinding";
        lblKeyBinding.Size = new Size(499, 61);
        lblKeyBinding.TabIndex = 38;
        lblKeyBinding.Text = "Key binding";
        lblKeyBinding.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // lblActions
        // 
        lblActions.BackColor = Color.FromArgb(35, 35, 35);
        lblActions.Font = new Font("Tahoma", 11.25F, FontStyle.Bold);
        lblActions.Location = new Point(541, 9);
        lblActions.Margin = new Padding(7, 0, 7, 0);
        lblActions.Name = "lblActions";
        lblActions.Size = new Size(612, 61);
        lblActions.TabIndex = 39;
        lblActions.Text = "Actions";
        lblActions.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // panel4
        // 
        panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
        panel4.BackColor = Color.Silver;
        panel4.Location = new Point(525, 4);
        panel4.Margin = new Padding(7);
        panel4.Name = "panel4";
        panel4.Size = new Size(2, 1102);
        panel4.TabIndex = 40;
        // 
        // ButtonEditor
        // 
        AutoScaleDimensions = new SizeF(168F, 168F);
        AutoScaleMode = AutoScaleMode.Dpi;
        BackColor = Color.FromArgb(45, 45, 45);
        ClientSize = new Size(2100, 1111);
        Controls.Add(panel4);
        Controls.Add(lblActions);
        Controls.Add(lblKeyBinding);
        Controls.Add(btnRemoveHotkey);
        Controls.Add(lblStateBinding);
        Controls.Add(hotkey);
        Controls.Add(lblState);
        Controls.Add(listStateBinding);
        Controls.Add(btnDeleteStateBinding);
        Controls.Add(panel3);
        Controls.Add(btnBackColor);
        Controls.Add(lblCurrentState);
        Controls.Add(btnOpenTemplateEditor);
        Controls.Add(lblCurrentStateLabel);
        Controls.Add(buttonGUIDLabel);
        Controls.Add(btnAddVariable);
        Controls.Add(label1);
        Controls.Add(btnForeColor);
        Controls.Add(btnEditJson);
        Controls.Add(fonts);
        Controls.Add(btnClearLabelText);
        Controls.Add(panel2);
        Controls.Add(flowLayoutPanel1);
        Controls.Add(labelText);
        Controls.Add(selectorPanel);
        Controls.Add(btnEditIcon);
        Controls.Add(btnOk);
        Controls.Add(btnRemoveIcon);
        Controls.Add(btnApply);
        Controls.Add(fontSize);
        Controls.Add(btnPreview);
        Margin = new Padding(9, 10, 9, 10);
        Name = "ButtonEditor";
        Padding = new Padding(4);
        Text = "Macro Deck :: Edit button";
        Shown += ButtonEditor_Shown;
        ((ISupportInitialize)btnPreview).EndInit();
        ((ISupportInitialize)fontSize).EndInit();
        panel1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((ISupportInitialize)btnEditIcon).EndInit();
        ((ISupportInitialize)btnRemoveIcon).EndInit();
        ((ISupportInitialize)btnClearLabelText).EndInit();
        ((ISupportInitialize)btnOpenTemplateEditor).EndInit();
        ((ISupportInitialize)btnAddVariable).EndInit();
        ((ISupportInitialize)btnDeleteStateBinding).EndInit();
        flowLayoutPanel1.ResumeLayout(false);
        flowLayoutPanel1.PerformLayout();
        ((ISupportInitialize)btnRemoveHotkey).EndInit();
        panel3.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();

    }


    #endregion
    private ButtonPrimary btnApply;
    private RoundedButton btnPreview;
    private RoundedTextBox labelText;
    private NumericUpDown fontSize;
    private Label lblButtonState;
    private ButtonRadioButton radioButtonOff;
    private ButtonRadioButton radioButtonOn;
    private Panel panel1;
    private Panel panel2;
    private ButtonRadioButton labelAlignBottom;
    private ButtonRadioButton labelAlignCenter;
    private ButtonRadioButton labelAlignTop;
    private PictureButton btnEditIcon;
    private PictureButton btnRemoveIcon;
    private PictureButton btnClearLabelText;
    private RoundedComboBox fonts;
    private ButtonPrimary btnForeColor;
    private Label lblCurrentState;
    private Label lblCurrentStateLabel;
    private ButtonPrimary btnOk;
    private PictureButton btnAddVariable;
    protected ContextMenuStrip variablesContextMenu;
    private Label lblStateBinding;
    private RoundedComboBox listStateBinding;
    private PictureButton btnDeleteStateBinding;
    private Panel selectorPanel;
    private FlowLayoutPanel flowLayoutPanel1;
    private ButtonRadioButton radioOnPress;
    private ButtonRadioButton radioOnEvent;
    private PictureButton btnOpenTemplateEditor;
    private PictureButton btnRemoveHotkey;
    private RoundedTextBox hotkey;
    private ButtonRadioButton radioOnRelease;
    private ButtonRadioButton radioOnLongPress;
    private ButtonRadioButton radioOnLongPressRelease;
    private ButtonPrimary btnEditJson;
    private Label label1;
    private TextBox buttonGUIDLabel;
    private Label label2;
    private ButtonPrimary btnBackColor;
    private Label lblAppearance;
    private Panel panel3;
    private Label lblState;
    private Label lblKeyBinding;
    private Label lblActions;
    private Panel panel4;
}