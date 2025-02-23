<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        BtnBrowse = New Button()
        Label1 = New Label()
        TxtFileName = New TextBox()
        Label4 = New Label()
        CoBoxSheet = New ComboBox()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnBrowse
        ' 
        BtnBrowse.BackColor = SystemColors.ButtonFace
        BtnBrowse.Location = New Point(744, 333)
        BtnBrowse.Name = "BtnBrowse"
        BtnBrowse.Size = New Size(44, 29)
        BtnBrowse.TabIndex = 1
        BtnBrowse.Text = "..."
        BtnBrowse.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 336)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 20)
        Label1.TabIndex = 2
        Label1.Text = "File Name"
        ' 
        ' TxtFileName
        ' 
        TxtFileName.Location = New Point(94, 333)
        TxtFileName.Name = "TxtFileName"
        TxtFileName.Size = New Size(644, 27)
        TxtFileName.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 374)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 6
        Label4.Text = "Sheets"
        ' 
        ' CoBoxSheet
        ' 
        CoBoxSheet.FormattingEnabled = True
        CoBoxSheet.Location = New Point(94, 374)
        CoBoxSheet.Name = "CoBoxSheet"
        CoBoxSheet.Size = New Size(151, 28)
        CoBoxSheet.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(3, 1)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(795, 322)
        DataGridView1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CoBoxSheet)
        Controls.Add(Label4)
        Controls.Add(TxtFileName)
        Controls.Add(Label1)
        Controls.Add(BtnBrowse)
        Controls.Add(DataGridView1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Read Excel.xlsx"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtFileName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CoBoxSheet As ComboBox
    Friend WithEvents DataGridView1 As DataGridView

End Class
