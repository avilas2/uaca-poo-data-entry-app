﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_userid = New System.Windows.Forms.TextBox()
        Me.lb_userid = New System.Windows.Forms.Label()
        Me.lb_userFirstName = New System.Windows.Forms.Label()
        Me.txt_userFirstName = New System.Windows.Forms.TextBox()
        Me.lb_userLastName = New System.Windows.Forms.Label()
        Me.txt_userLastName = New System.Windows.Forms.TextBox()
        Me.txt_userAge = New System.Windows.Forms.TextBox()
        Me.lb_userAge = New System.Windows.Forms.Label()
        Me.lb_userSkill = New System.Windows.Forms.Label()
        Me.txt_userSkill = New System.Windows.Forms.TextBox()
        Me.btn_userSubmit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_exportXML = New System.Windows.Forms.Button()
        Me.btn_getUsers = New System.Windows.Forms.Button()
        Me.btn_exportCSV = New System.Windows.Forms.Button()
        Me.btn_exportXLSX = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_userid
        '
        Me.txt_userid.Location = New System.Drawing.Point(127, 39)
        Me.txt_userid.Name = "txt_userid"
        Me.txt_userid.Size = New System.Drawing.Size(215, 22)
        Me.txt_userid.TabIndex = 0
        '
        'lb_userid
        '
        Me.lb_userid.AutoSize = True
        Me.lb_userid.Location = New System.Drawing.Point(34, 39)
        Me.lb_userid.Name = "lb_userid"
        Me.lb_userid.Size = New System.Drawing.Size(55, 17)
        Me.lb_userid.TabIndex = 1
        Me.lb_userid.Text = "User ID"
        '
        'lb_userFirstName
        '
        Me.lb_userFirstName.AutoSize = True
        Me.lb_userFirstName.Location = New System.Drawing.Point(34, 78)
        Me.lb_userFirstName.Name = "lb_userFirstName"
        Me.lb_userFirstName.Size = New System.Drawing.Size(76, 17)
        Me.lb_userFirstName.TabIndex = 3
        Me.lb_userFirstName.Text = "First Name"
        '
        'txt_userFirstName
        '
        Me.txt_userFirstName.Location = New System.Drawing.Point(127, 78)
        Me.txt_userFirstName.Name = "txt_userFirstName"
        Me.txt_userFirstName.Size = New System.Drawing.Size(215, 22)
        Me.txt_userFirstName.TabIndex = 2
        '
        'lb_userLastName
        '
        Me.lb_userLastName.AutoSize = True
        Me.lb_userLastName.Location = New System.Drawing.Point(357, 81)
        Me.lb_userLastName.Name = "lb_userLastName"
        Me.lb_userLastName.Size = New System.Drawing.Size(76, 17)
        Me.lb_userLastName.TabIndex = 5
        Me.lb_userLastName.Text = "Last Name"
        '
        'txt_userLastName
        '
        Me.txt_userLastName.Location = New System.Drawing.Point(439, 78)
        Me.txt_userLastName.Name = "txt_userLastName"
        Me.txt_userLastName.Size = New System.Drawing.Size(215, 22)
        Me.txt_userLastName.TabIndex = 4
        '
        'txt_userAge
        '
        Me.txt_userAge.Location = New System.Drawing.Point(127, 119)
        Me.txt_userAge.Name = "txt_userAge"
        Me.txt_userAge.Size = New System.Drawing.Size(113, 22)
        Me.txt_userAge.TabIndex = 6
        '
        'lb_userAge
        '
        Me.lb_userAge.AutoSize = True
        Me.lb_userAge.Location = New System.Drawing.Point(37, 123)
        Me.lb_userAge.Name = "lb_userAge"
        Me.lb_userAge.Size = New System.Drawing.Size(33, 17)
        Me.lb_userAge.TabIndex = 7
        Me.lb_userAge.Text = "Age"
        '
        'lb_userSkill
        '
        Me.lb_userSkill.AutoSize = True
        Me.lb_userSkill.Location = New System.Drawing.Point(281, 122)
        Me.lb_userSkill.Name = "lb_userSkill"
        Me.lb_userSkill.Size = New System.Drawing.Size(33, 17)
        Me.lb_userSkill.TabIndex = 9
        Me.lb_userSkill.Text = "Skill"
        '
        'txt_userSkill
        '
        Me.txt_userSkill.Location = New System.Drawing.Point(371, 118)
        Me.txt_userSkill.Name = "txt_userSkill"
        Me.txt_userSkill.Size = New System.Drawing.Size(113, 22)
        Me.txt_userSkill.TabIndex = 8
        '
        'btn_userSubmit
        '
        Me.btn_userSubmit.Location = New System.Drawing.Point(40, 180)
        Me.btn_userSubmit.Name = "btn_userSubmit"
        Me.btn_userSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btn_userSubmit.TabIndex = 10
        Me.btn_userSubmit.Text = "Submit"
        Me.btn_userSubmit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(820, 408)
        Me.DataGridView1.TabIndex = 11
        '
        'btn_exportXML
        '
        Me.btn_exportXML.Location = New System.Drawing.Point(782, 210)
        Me.btn_exportXML.Name = "btn_exportXML"
        Me.btn_exportXML.Size = New System.Drawing.Size(75, 23)
        Me.btn_exportXML.TabIndex = 12
        Me.btn_exportXML.Text = "XML"
        Me.btn_exportXML.UseVisualStyleBackColor = True
        '
        'btn_getUsers
        '
        Me.btn_getUsers.Location = New System.Drawing.Point(40, 210)
        Me.btn_getUsers.Name = "btn_getUsers"
        Me.btn_getUsers.Size = New System.Drawing.Size(110, 23)
        Me.btn_getUsers.TabIndex = 13
        Me.btn_getUsers.Text = "Get Users"
        Me.btn_getUsers.UseVisualStyleBackColor = True
        '
        'btn_exportCSV
        '
        Me.btn_exportCSV.Location = New System.Drawing.Point(701, 210)
        Me.btn_exportCSV.Name = "btn_exportCSV"
        Me.btn_exportCSV.Size = New System.Drawing.Size(75, 23)
        Me.btn_exportCSV.TabIndex = 14
        Me.btn_exportCSV.Text = "CSV"
        Me.btn_exportCSV.UseVisualStyleBackColor = True
        '
        'btn_exportXLSX
        '
        Me.btn_exportXLSX.Location = New System.Drawing.Point(620, 210)
        Me.btn_exportXLSX.Name = "btn_exportXLSX"
        Me.btn_exportXLSX.Size = New System.Drawing.Size(75, 23)
        Me.btn_exportXLSX.TabIndex = 15
        Me.btn_exportXLSX.Text = "Excel"
        Me.btn_exportXLSX.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 685)
        Me.Controls.Add(Me.btn_exportXLSX)
        Me.Controls.Add(Me.btn_exportCSV)
        Me.Controls.Add(Me.btn_getUsers)
        Me.Controls.Add(Me.btn_exportXML)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_userSubmit)
        Me.Controls.Add(Me.lb_userSkill)
        Me.Controls.Add(Me.txt_userSkill)
        Me.Controls.Add(Me.lb_userAge)
        Me.Controls.Add(Me.txt_userAge)
        Me.Controls.Add(Me.lb_userLastName)
        Me.Controls.Add(Me.txt_userLastName)
        Me.Controls.Add(Me.lb_userFirstName)
        Me.Controls.Add(Me.txt_userFirstName)
        Me.Controls.Add(Me.lb_userid)
        Me.Controls.Add(Me.txt_userid)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_userid As TextBox
    Friend WithEvents lb_userid As Label
    Friend WithEvents lb_userFirstName As Label
    Friend WithEvents txt_userFirstName As TextBox
    Friend WithEvents lb_userLastName As Label
    Friend WithEvents txt_userLastName As TextBox
    Friend WithEvents txt_userAge As TextBox
    Friend WithEvents lb_userAge As Label
    Friend WithEvents lb_userSkill As Label
    Friend WithEvents txt_userSkill As TextBox
    Friend WithEvents btn_userSubmit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_exportXML As Button
    Friend WithEvents btn_getUsers As Button
    Friend WithEvents btn_exportCSV As Button
    Friend WithEvents btn_exportXLSX As Button
End Class
