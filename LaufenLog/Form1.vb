'This program is copyright 2018 Daniel Laufenberg, All rights reserved.

Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim log_message As String = logBox.Text()

        Dim timestamp As Date = Now


        ' timestamp.ToString("Y")


        If (String.IsNullOrWhiteSpace(logBox.Text)) Then
            MessageBox.Show("You must enter something to log.",
                            "Invalid log entry.")

        Else

            Try

                MessageBox.Show(timestamp)


                LaufenlogTableAdapter.Insert(timestamp, log_message)

                logBox.Clear()
            Catch ex As Exception
                MessageBox.Show("An unknown error occurred",
                             "Error")
            End Try


        End If

    End Sub

    Private Sub laufenlogDataSetTableAdapters()
        Throw New NotImplementedException()
    End Sub

    Private Sub logBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles logBox.KeyPress
        Dim logString As String = logBox.Text()
        Dim time As DateTime = DateTime.Now


        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then


            If (String.IsNullOrWhiteSpace(logBox.Text)) Then
                MessageBox.Show("You must enter something to log.",
                            "Invalid log entry.")

            Else

                Try
                    LaufenlogTableAdapter.Insert(time, logString)
                    logBox.Clear()
                Catch ex As Exception
                    MessageBox.Show("An unknown error occurred",
                             "Error")
                End Try
            End If
        End If


    End Sub

    Private Sub logView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub logBox_TextChanged(sender As Object, e As EventArgs) Handles logBox.TextChanged

    End Sub

    Private Sub LaufenlogBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.LaufenlogBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LaufenlogDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LaufenlogDataSet.laufenlog' table. You can move, or remove it, as needed.
        Me.LaufenlogTableAdapter.Fill(Me.LaufenlogDataSet.laufenlog)

    End Sub

    Private Sub LaufenlogBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.LaufenlogBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LaufenlogDataSet)

    End Sub
End Class
