namespace CalculatorGUI
{
   partial class CalculatorGUIForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose( bool disposing )
      {
         if ( disposing && ( components != null ) )
         {
            components.Dispose();
         }
         base.Dispose( disposing );
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.exitBtn = new System.Windows.Forms.Button();
            this.quotient = new System.Windows.Forms.Button();
            this.reverseString = new System.Windows.Forms.Button();
            this.noWhiteSpace = new System.Windows.Forms.Button();
            this.minMax = new System.Windows.Forms.Button();
            this.logX = new System.Windows.Forms.Button();
            this.log10 = new System.Windows.Forms.Button();
            this.sqRoot = new System.Windows.Forms.Button();
            this.quad = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Location = new System.Drawing.Point(0, 222);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(316, 50);
            this.exitBtn.TabIndex = 32;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // quotient
            // 
            this.quotient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quotient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quotient.Location = new System.Drawing.Point(209, 172);
            this.quotient.Margin = new System.Windows.Forms.Padding(0);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(107, 50);
            this.quotient.TabIndex = 28;
            this.quotient.Text = "Quotient";
            this.quotient.UseVisualStyleBackColor = false;
            this.quotient.Click += new System.EventHandler(this.quotient_Click);
            // 
            // reverseString
            // 
            this.reverseString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.reverseString.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reverseString.Location = new System.Drawing.Point(106, 172);
            this.reverseString.Margin = new System.Windows.Forms.Padding(0);
            this.reverseString.Name = "reverseString";
            this.reverseString.Size = new System.Drawing.Size(103, 50);
            this.reverseString.TabIndex = 27;
            this.reverseString.Text = "Reverse String";
            this.reverseString.UseVisualStyleBackColor = false;
            this.reverseString.Click += new System.EventHandler(this.reverseString_Click);
            // 
            // noWhiteSpace
            // 
            this.noWhiteSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.noWhiteSpace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.noWhiteSpace.Location = new System.Drawing.Point(0, 172);
            this.noWhiteSpace.Margin = new System.Windows.Forms.Padding(0);
            this.noWhiteSpace.Name = "noWhiteSpace";
            this.noWhiteSpace.Size = new System.Drawing.Size(112, 50);
            this.noWhiteSpace.TabIndex = 26;
            this.noWhiteSpace.Text = "No Whitespace";
            this.noWhiteSpace.UseVisualStyleBackColor = false;
            this.noWhiteSpace.Click += new System.EventHandler(this.noWhiteSpace_Click);
            // 
            // minMax
            // 
            this.minMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.minMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minMax.Location = new System.Drawing.Point(209, 122);
            this.minMax.Margin = new System.Windows.Forms.Padding(0);
            this.minMax.Name = "minMax";
            this.minMax.Size = new System.Drawing.Size(107, 50);
            this.minMax.TabIndex = 24;
            this.minMax.Text = "Min and Max";
            this.minMax.UseVisualStyleBackColor = false;
            this.minMax.Click += new System.EventHandler(this.minMax_Click);
            // 
            // logX
            // 
            this.logX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logX.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logX.Location = new System.Drawing.Point(106, 122);
            this.logX.Margin = new System.Windows.Forms.Padding(0);
            this.logX.Name = "logX";
            this.logX.Size = new System.Drawing.Size(103, 50);
            this.logX.TabIndex = 23;
            this.logX.Text = "Log base x";
            this.logX.UseVisualStyleBackColor = false;
            this.logX.Click += new System.EventHandler(this.logX_Click);
            // 
            // log10
            // 
            this.log10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.log10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.log10.Location = new System.Drawing.Point(0, 122);
            this.log10.Margin = new System.Windows.Forms.Padding(0);
            this.log10.Name = "log10";
            this.log10.Size = new System.Drawing.Size(106, 50);
            this.log10.TabIndex = 22;
            this.log10.Text = "Log base 10";
            this.log10.UseVisualStyleBackColor = false;
            this.log10.Click += new System.EventHandler(this.log10_Click);
            // 
            // sqRoot
            // 
            this.sqRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.sqRoot.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sqRoot.Location = new System.Drawing.Point(209, 72);
            this.sqRoot.Margin = new System.Windows.Forms.Padding(0);
            this.sqRoot.Name = "sqRoot";
            this.sqRoot.Size = new System.Drawing.Size(107, 50);
            this.sqRoot.TabIndex = 20;
            this.sqRoot.Text = "Square Root";
            this.sqRoot.UseVisualStyleBackColor = false;
            this.sqRoot.Click += new System.EventHandler(this.sqRoot_Click);
            // 
            // quad
            // 
            this.quad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.quad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.quad.Location = new System.Drawing.Point(106, 72);
            this.quad.Margin = new System.Windows.Forms.Padding(0);
            this.quad.Name = "quad";
            this.quad.Size = new System.Drawing.Size(103, 50);
            this.quad.TabIndex = 19;
            this.quad.Text = "Quadratic Roots";
            this.quad.UseVisualStyleBackColor = false;
            this.quad.Click += new System.EventHandler(this.quad_Click);
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.power.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.power.Location = new System.Drawing.Point(0, 72);
            this.power.Margin = new System.Windows.Forms.Padding(0);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(106, 50);
            this.power.TabIndex = 18;
            this.power.Text = "Power";
            this.power.UseVisualStyleBackColor = false;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(0, 19);
            this.input.Multiline = true;
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(169, 35);
            this.input.TabIndex = 17;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(191, 19);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 33;
            // 
            // CalculatorGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(317, 270);
            this.Controls.Add(this.result);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.reverseString);
            this.Controls.Add(this.noWhiteSpace);
            this.Controls.Add(this.minMax);
            this.Controls.Add(this.logX);
            this.Controls.Add(this.log10);
            this.Controls.Add(this.sqRoot);
            this.Controls.Add(this.quad);
            this.Controls.Add(this.power);
            this.Controls.Add(this.input);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CalculatorGUIForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Button exitBtn;
      private System.Windows.Forms.Button quotient;
      private System.Windows.Forms.Button reverseString;
      private System.Windows.Forms.Button noWhiteSpace;
      private System.Windows.Forms.Button minMax;
      private System.Windows.Forms.Button logX;
      private System.Windows.Forms.Button log10;
      private System.Windows.Forms.Button sqRoot;
      private System.Windows.Forms.Button quad;
      private System.Windows.Forms.Button power;
      private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label result;
    }
}

