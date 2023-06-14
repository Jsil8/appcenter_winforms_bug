namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            diffViewer1 = new DiffPlex.WindowsForms.Controls.DiffViewer();
            SuspendLayout();
            // 
            // diffViewer1
            // 
            diffViewer1.BorderColor = Color.Empty;
            diffViewer1.BorderWidth = new Padding(0);
            diffViewer1.ChangeTypeForeColor = Color.FromArgb(128, 128, 128);
            diffViewer1.CollapseUnchangedSectionsToggleTitle = "_Collapse unchanged sections";
            diffViewer1.ContextLinesMenuItemsTitle = "_Lines for context";
            diffViewer1.DeletedBackColor = Color.FromArgb(64, 216, 32, 32);
            diffViewer1.DeletedForeColor = Color.Empty;
            diffViewer1.FontFamilyNames = "Segoe UI";
            diffViewer1.FontSize = 12D;
            diffViewer1.FontStretch = System.Windows.FontStretch.FromOpenTypeStretch(5);
            diffViewer1.FontWeight = 400;
            diffViewer1.HeaderBackColor = Color.FromArgb(12, 128, 128, 128);
            diffViewer1.HeaderForeColor = Color.FromArgb(128, 128, 128);
            diffViewer1.HeaderHeight = 0D;
            diffViewer1.IgnoreCase = false;
            diffViewer1.IgnoreUnchanged = false;
            diffViewer1.IgnoreWhiteSpace = true;
            diffViewer1.ImaginaryBackColor = Color.FromArgb(24, 128, 128, 128);
            diffViewer1.InlineModeToggleTitle = "_Unified view";
            diffViewer1.InsertedBackColor = Color.Empty;
            diffViewer1.InsertedForeColor = Color.Empty;
            diffViewer1.IsFontItalic = false;
            diffViewer1.IsSideBySide = true;
            diffViewer1.LineNumberForeColor = Color.FromArgb(64, 128, 160);
            diffViewer1.LineNumberWidth = 60;
            diffViewer1.LinesContext = 1;
            diffViewer1.Location = new Point(253, 122);
            diffViewer1.Name = "diffViewer1";
            diffViewer1.NewText = null;
            diffViewer1.NewTextHeader = null;
            diffViewer1.OldText = null;
            diffViewer1.OldTextHeader = null;
            diffViewer1.SideBySideModeToggleTitle = "_Split view";
            diffViewer1.Size = new Size(150, 150);
            diffViewer1.SplitterBackColor = Color.FromArgb(64, 128, 128, 128);
            diffViewer1.SplitterBorderColor = Color.FromArgb(64, 128, 128, 128);
            diffViewer1.SplitterBorderWidth = new Padding(0);
            diffViewer1.SplitterWidth = 5D;
            diffViewer1.TabIndex = 0;
            diffViewer1.UnchangedBackColor = Color.Empty;
            diffViewer1.UnchangedForeColor = Color.Empty;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(diffViewer1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private DiffPlex.WindowsForms.Controls.DiffViewer diffViewer1;
    }
}