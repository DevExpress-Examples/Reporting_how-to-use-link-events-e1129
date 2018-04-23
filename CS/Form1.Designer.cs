namespace UseLinkEvents {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printingSystem1 = new DevExpress.XtraPrinting.PrintingSystem(this.components);
            this.link1 = new DevExpress.XtraPrinting.Link(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).BeginInit();
            this.SuspendLayout();
            // 
            // printingSystem1
            // 
            this.printingSystem1.Links.AddRange(new object[] {
            this.link1});
            // 
            // link1
            // 
            this.link1.CustomPaperSize = new System.Drawing.Size(0, 0);
            this.link1.PrintingSystem = this.printingSystem1;
            this.link1.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            this.link1.CreateDetailHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.link1_CreateDetailHeaderArea);
            this.link1.CreateDetailArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.link1_CreateDetailArea);
            this.link1.CreateMarginalHeaderArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.link1_CreateMarginalHeaderArea);
            this.link1.CreateDetailFooterArea += new DevExpress.XtraPrinting.CreateAreaEventHandler(this.link1_CreateDetailFooterArea);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Preview";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.printingSystem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPrinting.PrintingSystem printingSystem1;
        private DevExpress.XtraPrinting.Link link1;
        private System.Windows.Forms.Button button1;
    }
}

