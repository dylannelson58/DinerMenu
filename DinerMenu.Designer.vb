<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DinerMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DescriptionofFoodLabel = New System.Windows.Forms.Label()
        Me.SpecialofthedayLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SaladButton
        '
        Me.SaladButton.Location = New System.Drawing.Point(110, 298)
        Me.SaladButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(97, 58)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "Salad"
        Me.ToolTip1.SetToolTip(Me.SaladButton, "Displays the Salad Description")
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Location = New System.Drawing.Point(212, 298)
        Me.FishButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(97, 58)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "Fish"
        Me.ToolTip1.SetToolTip(Me.FishButton, "Displays the Fish Special")
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'SoupButton
        '
        Me.SoupButton.Location = New System.Drawing.Point(9, 298)
        Me.SoupButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(97, 58)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "Soup"
        Me.ToolTip1.SetToolTip(Me.SoupButton, "Displays the Soup Description")
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(494, 298)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(97, 58)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exits the Menu")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 45)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "- Dylan's Diner -"
        '
        'DescriptionofFoodLabel
        '
        Me.DescriptionofFoodLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionofFoodLabel.Location = New System.Drawing.Point(9, 87)
        Me.DescriptionofFoodLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DescriptionofFoodLabel.Name = "DescriptionofFoodLabel"
        Me.DescriptionofFoodLabel.Size = New System.Drawing.Size(580, 124)
        Me.DescriptionofFoodLabel.TabIndex = 5
        '
        'SpecialofthedayLabel
        '
        Me.SpecialofthedayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecialofthedayLabel.Location = New System.Drawing.Point(227, 52)
        Me.SpecialofthedayLabel.Name = "SpecialofthedayLabel"
        Me.SpecialofthedayLabel.Size = New System.Drawing.Size(171, 23)
        Me.SpecialofthedayLabel.TabIndex = 6
        '
        'DinerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.SpecialofthedayLabel)
        Me.Controls.Add(Me.DescriptionofFoodLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "DinerMenu"
        Me.Text = "Diner"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents SoupButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label1 As Label
    Friend WithEvents DescriptionofFoodLabel As Label
    Friend WithEvents SpecialofthedayLabel As Label
End Class
