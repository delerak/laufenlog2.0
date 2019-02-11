<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.logBox = New System.Windows.Forms.RichTextBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.timeStamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LaufenlogDataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.LaufenlogDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'logBox
        '
        Me.logBox.Location = New System.Drawing.Point(27, 413)
        Me.logBox.Multiline = False
        Me.logBox.Name = "logBox"
        Me.logBox.Size = New System.Drawing.Size(790, 32)
        Me.logBox.TabIndex = 2
        Me.logBox.Text = ""
        Me.logBox.UseWaitCursor = True
        '
        'btnLog
        '
        Me.btnLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.Location = New System.Drawing.Point(823, 413)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(50, 30)
        Me.btnLog.TabIndex = 3
        Me.btnLog.Text = "&Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(879, 413)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(69, 30)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(855, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'timeStamp
        '
        Me.timeStamp.Name = "timeStamp"
        '
        'LogColumn
        '
        Me.LogColumn.Name = "LogColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 453)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "© LaufenTECH  All rights reserved"
        '
        'LaufenlogDataGridView2
        '
        Me.LaufenlogDataGridView2.AllowUserToDeleteRows = False
        Me.LaufenlogDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LaufenlogDataGridView2.Location = New System.Drawing.Point(67, 28)
        Me.LaufenlogDataGridView2.Name = "LaufenlogDataGridView2"
        Me.LaufenlogDataGridView2.ReadOnly = True
        Me.LaufenlogDataGridView2.Size = New System.Drawing.Size(300, 220)
        Me.LaufenlogDataGridView2.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 486)
        Me.Controls.Add(Me.LaufenlogDataGridView2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.logBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.LaufenlogDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents logBox As RichTextBox
    Friend WithEvents btnLog As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents timeStamp As DataGridViewTextBoxColumn
    Friend WithEvents LogColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents LaufenlogDataGridView As DataGridView
    Friend WithEvents TimestampDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LogmessageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LaufenlogDataGridView1 As DataGridView
    Friend WithEvents LaufenlogDataGridView2 As DataGridView
End Class
