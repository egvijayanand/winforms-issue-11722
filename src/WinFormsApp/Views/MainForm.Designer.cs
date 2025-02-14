﻿namespace WinFormsApp.Views;

partial class MainForm
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
		components = new System.ComponentModel.Container();
		comboBox1 = new ComboBox();
		comboBox2 = new ComboBox();
		mainViewModelBindingSource = new BindingSource(components);
		((System.ComponentModel.ISupportInitialize)mainViewModelBindingSource).BeginInit();
		SuspendLayout();
		// 
		// comboBox1
		// 
		comboBox1.FormattingEnabled = true;
		comboBox1.Location = new Point(48, 66);
		comboBox1.Name = "comboBox1";
		comboBox1.Size = new Size(182, 33);
		comboBox1.TabIndex = 0;
		// 
		// comboBox2
		// 
		comboBox2.FormattingEnabled = true;
		comboBox2.Location = new Point(48, 146);
		comboBox2.Name = "comboBox2";
		comboBox2.Size = new Size(182, 33);
		comboBox2.TabIndex = 1;
		// 
		// mainViewModelBindingSource
		// 
		mainViewModelBindingSource.DataSource = typeof(MainViewModel);
		// 
		// MainForm
		// 
		AutoScaleDimensions = new SizeF(10F, 25F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(278, 244);
		Controls.Add(comboBox2);
		Controls.Add(comboBox1);
		Name = "MainForm";
		Text = "MainForm";
		((System.ComponentModel.ISupportInitialize)mainViewModelBindingSource).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private ComboBox comboBox1;
	private ComboBox comboBox2;
	private BindingSource mainViewModelBindingSource;
}
