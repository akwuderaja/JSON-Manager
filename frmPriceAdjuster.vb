Imports Newtonsoft.Json

Public Class frmPriceAdjuster
    Dim lines As String()

    Private Sub btnAttach_Click(sender As Object, e As EventArgs) Handles btnAttach.Click
        If ofd.ShowDialog = DialogResult.OK Then
            txtFileName.Text = ofd.FileName
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Try
            If String.IsNullOrEmpty(ofd.FileName) Then
                MsgBox("Attach a json file to proceed.")
                btnAttach.Focus()
                Exit Sub
            ElseIf nudValue.Value <= 0 Then
                MsgBox("Provide an adjustment value to proceed.")
                nudValue.Focus()
                Exit Sub
            End If
            Dim fileContents() As String
            fileContents = IO.File.ReadAllLines(ofd.FileName)
            Dim searchString1 As String = "buyPrice"
            Dim searchString As String = """buyPrice"": "
            Dim nums() As String = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "."}
            For i = 0 To fileContents.Length - 1
                If fileContents(i).Contains(searchString) Then
                    Dim lineContents = fileContents(i)
                    Dim j As Integer = lineContents.IndexOf(searchString) + searchString.Length - 1
                    'Dim val = lineContents.Substring(j, lineContents.Length - 1 - j)
                    Dim val = lineContents.Substring(j, lineContents.Length - j).Replace(",", "")
                    If Not IsNumeric(val) Then
                        MsgBox("Non numeric value encountered: " & val)
                    Else
                        Dim num As Integer = CInt(val)

                        If num > 2 Then
                            num = num - ((nudValue.Value / 100) * num)
                            fileContents(i) = lineContents.Substring(0, j) & " " & num & ","
                        End If
                    End If
                End If
            Next

            lines = fileContents
            MsgBox("Operation Completed!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnProcess_ClickOld(sender As Object, e As EventArgs)
        Try
            If String.IsNullOrEmpty(ofd.FileName) Then
                MsgBox("Attach a json file to proceed.")
                btnAttach.Focus()
                Exit Sub
            End If
            Dim fileContents As String
            fileContents = My.Computer.FileSystem.ReadAllText(ofd.FileName)

            'Dim jClasses As List(Of jsonClass) = JsonConvert.DeserializeObject(Of jsonClass)(fileContents)
            Dim jClasses = JsonConvert.DeserializeObject(value:=fileContents)
            For i = 0 To jClasses.Count - 1
                Dim item = jClasses(i)
                'MsgBox(item.Name & "|" & item.Value)
                If TypeOf (item.Value) Is JsonArrayAttribute Then
                    For j = 0 To item.Value.Count - 1
                        Dim subItem = item.Value(j)
                        MsgBox(subItem.Name & "|" & subItem.Value)
                        If TypeOf (subItem.Value) Is JsonArrayAttribute Then
                            If TypeOf (item.Value) Is JsonArrayAttribute Then
                                For k = 0 To item.Value.Count - 1
                                    Dim subSubItem = item.Value(k)
                                    MsgBox(subSubItem.Name & "|" & subSubItem.Value)
                                    If TypeOf (subSubItem.Value) Is JsonArrayAttribute Then

                                    End If
                                Next
                            End If
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Class jsonClass
        Public Property furniId As Integer
        Public Property buyPrice As Integer
        Public Property sellPrice As Integer
    End Class

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If lines.Length = 0 Then
                MsgBox("Nothing to save")
                Exit Sub
            End If

            If sfd.ShowDialog = DialogResult.OK Then
                IO.File.WriteAllLines(sfd.FileName, lines)
                MsgBox("Saved")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
