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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.workshopListBox = New System.Windows.Forms.ListBox()
        Me.locationListBox = New System.Windows.Forms.ListBox()
        Me.costListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalCostLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(178, 321)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 46)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Add Workshop"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(280, 321)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 46)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(392, 321)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 46)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(497, 321)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 46)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'workshopListBox
        '
        Me.workshopListBox.FormattingEnabled = True
        Me.workshopListBox.ItemHeight = 15
        Me.workshopListBox.Items.AddRange(New Object() {"Handling Stress", "Time Managment", "Supervision Skills", "Negotiation", "How To Interview"})
        Me.workshopListBox.Location = New System.Drawing.Point(152, 128)
        Me.workshopListBox.Name = "workshopListBox"
        Me.workshopListBox.Size = New System.Drawing.Size(139, 124)
        Me.workshopListBox.TabIndex = 4
        '
        'locationListBox
        '
        Me.locationListBox.FormattingEnabled = True
        Me.locationListBox.ItemHeight = 15
        Me.locationListBox.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.locationListBox.Location = New System.Drawing.Point(331, 128)
        Me.locationListBox.Name = "locationListBox"
        Me.locationListBox.Size = New System.Drawing.Size(136, 124)
        Me.locationListBox.TabIndex = 5
        '
        'costListBox
        '
        Me.costListBox.FormattingEnabled = True
        Me.costListBox.ItemHeight = 15
        Me.costListBox.Location = New System.Drawing.Point(497, 128)
        Me.costListBox.Name = "costListBox"
        Me.costListBox.Size = New System.Drawing.Size(142, 124)
        Me.costListBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total Cost:"
        '
        'totalCostLabel
        '
        Me.totalCostLabel.AutoSize = True
        Me.totalCostLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalCostLabel.Location = New System.Drawing.Point(375, 274)
        Me.totalCostLabel.Name = "totalCostLabel"
        Me.totalCostLabel.Size = New System.Drawing.Size(2, 17)
        Me.totalCostLabel.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Pick a Workshop"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(331, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pick a Location"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(497, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "List of Costs"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.totalCostLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.costListBox)
        Me.Controls.Add(Me.locationListBox)
        Me.Controls.Add(Me.workshopListBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Workshop Selector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents workshopListBox As ListBox
    Friend WithEvents locationListBox As ListBox
    Friend WithEvents costListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents totalCostLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
