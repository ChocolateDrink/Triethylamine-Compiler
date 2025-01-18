namespace compiler
{
	partial class TriethylamineCompiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriethylamineCompiler));
            BotTokenText = new TextBox();
            BotToken = new Label();
            ServerId = new Label();
            ServerIdText = new TextBox();
            ExecName = new Label();
            ExecNameText = new TextBox();
            CompileButton = new Button();
            Mario = new PictureBox();
            CompilationStatus = new Label();
            DebugButton = new Button();
            OpenCompiledExec = new Button();
            ((System.ComponentModel.ISupportInitialize)Mario).BeginInit();
            SuspendLayout();
            // 
            // BotTokenText
            // 
            BotTokenText.Location = new Point(12, 50);
            BotTokenText.Name = "BotTokenText";
            BotTokenText.Size = new Size(363, 27);
            BotTokenText.TabIndex = 0;
            // 
            // BotToken
            // 
            BotToken.AutoSize = true;
            BotToken.Location = new Point(12, 27);
            BotToken.Name = "BotToken";
            BotToken.Size = new Size(75, 20);
            BotToken.TabIndex = 1;
            BotToken.Text = "Bot Token";
            // 
            // ServerId
            // 
            ServerId.AutoSize = true;
            ServerId.Location = new Point(12, 101);
            ServerId.Name = "ServerId";
            ServerId.Size = new Size(69, 20);
            ServerId.TabIndex = 2;
            ServerId.Text = "Server ID";
            // 
            // ServerIdText
            // 
            ServerIdText.Location = new Point(12, 124);
            ServerIdText.Name = "ServerIdText";
            ServerIdText.Size = new Size(363, 27);
            ServerIdText.TabIndex = 3;
            // 
            // ExecName
            // 
            ExecName.AutoSize = true;
            ExecName.Location = new Point(12, 178);
            ExecName.Name = "ExecName";
            ExecName.Size = new Size(125, 20);
            ExecName.TabIndex = 4;
            ExecName.Text = "Executable Name";
            // 
            // ExecNameText
            // 
            ExecNameText.Location = new Point(12, 201);
            ExecNameText.Name = "ExecNameText";
            ExecNameText.Size = new Size(363, 27);
            ExecNameText.TabIndex = 5;
            // 
            // CompileButton
            // 
            CompileButton.Location = new Point(18, 356);
            CompileButton.Name = "CompileButton";
            CompileButton.Size = new Size(152, 36);
            CompileButton.TabIndex = 6;
            CompileButton.Text = "Compile";
            CompileButton.UseVisualStyleBackColor = true;
            CompileButton.Click += CompileButton_Click;
            // 
            // Mario
            // 
            Mario.Image = (Image)resources.GetObject("Mario.Image");
            Mario.Location = new Point(475, 12);
            Mario.Name = "Mario";
            Mario.Size = new Size(316, 216);
            Mario.TabIndex = 7;
            Mario.TabStop = false;
            // 
            // CompilationStatus
            // 
            CompilationStatus.AutoSize = true;
            CompilationStatus.Location = new Point(175, 364);
            CompilationStatus.Name = "CompilationStatus";
            CompilationStatus.Size = new Size(0, 20);
            CompilationStatus.TabIndex = 11;
            // 
            // DebugButton
            // 
            DebugButton.Location = new Point(18, 314);
            DebugButton.Name = "DebugButton";
            DebugButton.Size = new Size(152, 36);
            DebugButton.TabIndex = 12;
            DebugButton.Text = "Copy Error";
            DebugButton.UseVisualStyleBackColor = true;
            DebugButton.Visible = false;
            DebugButton.Click += DebugButton_Click;
            // 
            // OpenCompiledExec
            // 
            OpenCompiledExec.Location = new Point(18, 314);
            OpenCompiledExec.Name = "OpenCompiledExec";
            OpenCompiledExec.Size = new Size(152, 36);
            OpenCompiledExec.TabIndex = 13;
            OpenCompiledExec.Text = "Open File Location";
            OpenCompiledExec.UseVisualStyleBackColor = true;
            OpenCompiledExec.Visible = false;
            OpenCompiledExec.Click += OpenCompiledExec_Click;
            // 
            // TriethylamineCompiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 404);
            Controls.Add(OpenCompiledExec);
            Controls.Add(DebugButton);
            Controls.Add(CompilationStatus);
            Controls.Add(Mario);
            Controls.Add(CompileButton);
            Controls.Add(ExecNameText);
            Controls.Add(ExecName);
            Controls.Add(ServerIdText);
            Controls.Add(ServerId);
            Controls.Add(BotToken);
            Controls.Add(BotTokenText);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TriethylamineCompiler";
            Text = "Triethylamine Compiler";
            ((System.ComponentModel.ISupportInitialize)Mario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BotTokenText;
		private Label BotToken;
		private Label ServerId;
		private TextBox ServerIdText;
		private Label ExecName;
		private TextBox ExecNameText;
		private Button CompileButton;
		private PictureBox Mario;
		private Label CompilationStatus;
        private Button DebugButton;
        private Button OpenCompiledExec;
    }
}
