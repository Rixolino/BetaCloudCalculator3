﻿Public Class Answer
    Private Sub Answer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Scientific.TextBox1.Text & Scientific.oplabel.Text & Scientific.TextBox2.Text & " = " & Scientific.TextBox3.Text

        If Scientific.TextBox1.Text & Scientific.TextBox2.Text & Scientific.TextBox3.Text = "" Then
            TextBox1.Enabled = False
            TextBox1.Text = "You need to insert value before you copy the answer"
        End If
        If Scientific.TextBox2.Text = "" Then
            TextBox1.Enabled = False
            TextBox1.Text = "You must insert the second value before you proceed!"
        End If
        If Scientific.TextBox1.Text = "" Then
            TextBox1.Enabled = False
            TextBox1.Text = "You must insert the first value before you proceed!"
        End If
        If Scientific.TextBox2.Text = "fact" Then
            TextBox1.Text = Scientific.TextBox2.Text & "(" & Scientific.TextBox1.Text & ")" & " = " & Scientific.TextBox3.Text
        End If
        If Scientific.TextBox2.Text = "sqrt" Then
            TextBox1.Text = Scientific.TextBox2.Text & "(" & Scientific.TextBox1.Text & ")" & " = " & Scientific.TextBox3.Text
        End If
        If Scientific.TextBox2.Text = "cbrt" Then
            TextBox1.Text = Scientific.TextBox2.Text & "(" & Scientific.TextBox1.Text & ")" & " = " & Scientific.TextBox3.Text
        End If
        If Scientific.TextBox3.Text = "∞" Then
            TextBox1.Text = Scientific.TextBox1.Text & Scientific.oplabel.Text & Scientific.TextBox2.Text & " = " & "Impossible to divide by zero" & " (" & Scientific.TextBox3.Text & ")"
        End If
        If Scientific.functions.Text = "RAD => DEG" Then
            TextBox1.Enabled = True
            TextBox1.Text = Scientific.functions.Text & "(" & Scientific.TextBox1.Text & ")" & " = " & Scientific.TextBox3.Text
        End If
        If Scientific.functions.Text = "DEG => RAD" Then
            TextBox1.Enabled = True
            TextBox1.Text = Scientific.functions.Text & "(" & Scientific.TextBox1.Text & ")" & " = " & Scientific.TextBox3.Text
        End If
        If Scientific.functions.Text = "DEG => GRAD" Then
            TextBox1.Enabled = True
            TextBox1.Text = Scientific.functions.Text & "(" & Scientific.TextBox1.Text & ")" & " = " & Scientific.TextBox3.Text
        End If
        If Scientific.functions.Text = "RAD => GRAD" Then
            TextBox1.Enabled = True
            TextBox1.Text = Scientific.functions.Text & "(" & Scientific.TextBox1.Text & ")" & " = " & Scientific.TextBox3.Text
        End If
        If Scientific.functions.Text = "GRAD => DEG" Then
            TextBox1.Enabled = True
            TextBox1.Text = Scientific.functions.Text & "(" & Scientific.TextBox1.Text & ")" & " = " & Scientific.TextBox3.Text
        End If
        If Scientific.functions.Text = "GRAD => RAD" Then
            TextBox1.Enabled = True
            TextBox1.Text = Scientific.functions.Text & "(" & Scientific.TextBox1.Text & ")" & " = " & Scientific.TextBox3.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class