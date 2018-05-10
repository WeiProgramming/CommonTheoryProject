'SDSU CS 540 Software Internationalization
'resX FILE BUILDER UTILITY (SUPPORTS EMBEDDED IMAGE RESOURCES)

'Imports System
Imports System.IO
Imports System.Resources
'Imports System.Drawing

Public Class Form1
    Inherits System.Windows.Forms.Form

    Dim stringResourceFile As New FileStream("strings.txt", FileMode.Open, FileAccess.Read)
    Dim stringReader As New StreamReader(stringResourceFile)

    Dim imageResourceFile As New FileStream("images.txt", FileMode.Open, FileAccess.Read)
    Dim imageReader As New StreamReader(imageResourceFile)

    Dim resXFile As New ResXResourceWriter("tempResX.resX")

    Dim stringInternalName As String
    Dim stringValue As String

    Dim imageInternalName As String
    Dim imageExternalName As String
    Dim imageValue As Image

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents displayImageInternalName As System.Windows.Forms.Label
    Friend WithEvents displayImageValue As System.Windows.Forms.PictureBox
    Friend WithEvents displayStringInternalName As System.Windows.Forms.Label
    Friend WithEvents displayStringValue As System.Windows.Forms.Label
    Friend WithEvents addNextStringButton As System.Windows.Forms.Button
    Friend WithEvents addNextImageButton As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.displayStringInternalName = New System.Windows.Forms.Label()
        Me.displayImageInternalName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.addNextStringButton = New System.Windows.Forms.Button()
        Me.displayStringValue = New System.Windows.Forms.Label()
        Me.displayImageValue = New System.Windows.Forms.PictureBox()
        Me.addNextImageButton = New System.Windows.Forms.Button()
        CType(Me.displayImageValue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(96, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INTERNAL NAME"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(304, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "VALUE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "STRING RESOURCES"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(752, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "IMAGE RESOURCES"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayStringInternalName
        '
        Me.displayStringInternalName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.displayStringInternalName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayStringInternalName.Location = New System.Drawing.Point(96, 80)
        Me.displayStringInternalName.Name = "displayStringInternalName"
        Me.displayStringInternalName.Size = New System.Drawing.Size(192, 32)
        Me.displayStringInternalName.TabIndex = 8
        Me.displayStringInternalName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayImageInternalName
        '
        Me.displayImageInternalName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.displayImageInternalName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayImageInternalName.Location = New System.Drawing.Point(664, 80)
        Me.displayImageInternalName.Name = "displayImageInternalName"
        Me.displayImageInternalName.Size = New System.Drawing.Size(192, 32)
        Me.displayImageInternalName.TabIndex = 17
        Me.displayImageInternalName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(664, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 24)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "INTERNAL NAME"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(872, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 24)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "IMAGE"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'addNextStringButton
        '
        Me.addNextStringButton.Location = New System.Drawing.Point(16, 232)
        Me.addNextStringButton.Name = "addNextStringButton"
        Me.addNextStringButton.Size = New System.Drawing.Size(264, 32)
        Me.addNextStringButton.TabIndex = 14
        Me.addNextStringButton.Text = "ADD NEXT STRING TO .RESX FILE"
        '
        'displayStringValue
        '
        Me.displayStringValue.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.displayStringValue.Font = New System.Drawing.Font("Gungsuh", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayStringValue.Location = New System.Drawing.Point(304, 80)
        Me.displayStringValue.Name = "displayStringValue"
        Me.displayStringValue.Size = New System.Drawing.Size(192, 32)
        Me.displayStringValue.TabIndex = 15
        Me.displayStringValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayImageValue
        '
        Me.displayImageValue.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.displayImageValue.Location = New System.Drawing.Point(896, 80)
        Me.displayImageValue.Name = "displayImageValue"
        Me.displayImageValue.Size = New System.Drawing.Size(144, 144)
        Me.displayImageValue.TabIndex = 16
        Me.displayImageValue.TabStop = False
        '
        'addNextImageButton
        '
        Me.addNextImageButton.Location = New System.Drawing.Point(296, 232)
        Me.addNextImageButton.Name = "addNextImageButton"
        Me.addNextImageButton.Size = New System.Drawing.Size(264, 32)
        Me.addNextImageButton.TabIndex = 18
        Me.addNextImageButton.Text = "ADD NEXT IMAGE TO .RESX FILE"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1112, 273)
        Me.Controls.Add(Me.addNextImageButton)
        Me.Controls.Add(Me.displayImageValue)
        Me.Controls.Add(Me.displayStringValue)
        Me.Controls.Add(Me.addNextStringButton)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.displayImageInternalName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.displayStringInternalName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "SDSU CS 540 RESX FILE BUILDER UTILITY (SUPPORTS EMBEDDED IMAGE RESOURCES)"
        CType(Me.displayImageValue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addNextStringButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addNextStringButton.Click
        If stringReader.Peek() > -1 Then
            stringInternalName = stringReader.ReadLine()
            displayStringInternalName.Text = stringInternalName
            stringValue = stringReader.ReadLine()
            displayStringValue.Text = stringValue
            resXFile.AddResource(stringInternalName, stringValue)
        Else
            addNextStringButton.Enabled = False
            addNextStringButton.Visible = False
            stringReader.Close()
            stringResourceFile.Close()
            If addNextImageButton.Enabled = False Then
                GetOutOfDodge()
            End If
        End If
    End Sub

    Private Sub addNextImageButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addNextImageButton.Click
        If imageReader.Peek() > -1 Then
            imageInternalName = imageReader.ReadLine()
            displayImageInternalName.Text = imageInternalName
            imageExternalName = imageReader.ReadLine()
            imageValue = Image.FromFile(imageExternalName)
            displayImageValue.Image = imageValue
            resXFile.AddResource(imageInternalName, imageValue)
        Else
            addNextImageButton.Enabled = False
            addNextImageButton.Visible = False
            imageReader.Close()
            imageResourceFile.Close()
            If addNextStringButton.Enabled = False Then
                GetOutOfDodge()
            End If
        End If
    End Sub

    Private Sub GetOutOfDodge()
        resXFile.Generate()
        resXFile.Close()
        End
    End Sub

End Class
