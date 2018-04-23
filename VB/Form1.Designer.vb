Imports Microsoft.VisualBasic
Imports System
Namespace UseLinkEvents
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.printingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
			Me.link1 = New DevExpress.XtraPrinting.Link(Me.components)
			Me.button1 = New System.Windows.Forms.Button()
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' printingSystem1
			' 
			Me.printingSystem1.Links.AddRange(New Object() { Me.link1})
			' 
			' link1
			' 
			Me.link1.CustomPaperSize = New System.Drawing.Size(0, 0)
			Me.link1.PrintingSystem = Me.printingSystem1
			Me.link1.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
'			Me.link1.CreateDetailHeaderArea += New DevExpress.XtraPrinting.CreateAreaEventHandler(Me.link1_CreateDetailHeaderArea);
'			Me.link1.CreateDetailArea += New DevExpress.XtraPrinting.CreateAreaEventHandler(Me.link1_CreateDetailArea);
'			Me.link1.CreateMarginalHeaderArea += New DevExpress.XtraPrinting.CreateAreaEventHandler(Me.link1_CreateMarginalHeaderArea);
'			Me.link1.CreateDetailFooterArea += New DevExpress.XtraPrinting.CreateAreaEventHandler(Me.link1_CreateDetailFooterArea);
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(76, 95)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(141, 82)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Show Preview"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 264)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.printingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private printingSystem1 As DevExpress.XtraPrinting.PrintingSystem
		Private WithEvents link1 As DevExpress.XtraPrinting.Link
		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace

