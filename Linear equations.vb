Public Class Linearequations
    Dim fract As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        fract = (TextBox1.Text * TextBox4.Text) - (TextBox2.Text * TextBox3.Text)
        Resultx.Text = ((TextBox5.Text * TextBox4.Text) - (TextBox6.Text * TextBox3.Text)) / fract
        Resulty.Text = ((TextBox1.Text * TextBox6.Text) - (TextBox2.Text * TextBox5.Text)) / fract

        If Resultx.Text = "NaN" Then
            Resultx.Text = "Indeterminate"
        End If

        If Resulty.Text = "NaN" Then
            Resulty.Text = "Indeterminate"
        End If

        If Resultx.Text = "∞" Then
            Resultx.Text = "Infinite solution"
        End If

        If Resulty.Text = "∞" Then
            Resulty.Text = "Infinite solution"
        End If
    End Sub

    Private Sub ScientificActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificActualToolStripMenuItem.Click
        Me.Close()
        Scientific.Show()
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Me.Close()
        Normal.Show()
    End Sub

    Private Sub UnitOfMeasureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnitOfMeasureToolStripMenuItem.Click
        Me.Close()
        FunctionConverter.Show()
    End Sub

    Private Sub FormulasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulasToolStripMenuItem.Click
        Formulas.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Linearequations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class