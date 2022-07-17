Imports JSON_Manager.Models
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmMarginAdjuster
    Dim configLines As String()
    Dim IndividualDifferences As New List(Of IndividualDifference)
    Dim IndividualDifferencesString As String = ""

    Private Sub btnAttachConfig_Click(sender As Object, e As EventArgs) Handles btnConfigJson.Click
        If ofd.ShowDialog = DialogResult.OK Then
            txtConfigJson.Text = ofd.FileName
        End If
    End Sub

    Private Sub btnAttachFurnId_Click(sender As Object, e As EventArgs) Handles btnFurnIdJson.Click
        If fbd.ShowDialog = DialogResult.OK Then
            txtFurnIdJson.Text = fbd.SelectedPath
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        Dim fileContents() As String = {}
        Try
            If String.IsNullOrEmpty(txtConfigJson.Text) Then
                MsgBox("Attach a json file to proceed.")
                btnConfigJson.Focus()
                Exit Sub
            ElseIf String.IsNullOrEmpty(txtFurnIdJson.Text) Then
                MsgBox("Attach a furnid folder to proceed.")
                btnConfigJson.Focus()
                Exit Sub
            ElseIf nudValue.Value <= 0 Then
                MsgBox("Provide a difference (%): value to proceed.")
                nudValue.Focus()
                Exit Sub
            End If

            fileContents = IO.File.ReadAllLines(txtConfigJson.Text)
            Dim searchStringFurniId As String = """furniId"": "
            Dim searchStringSellPrice As String = """sellPrice"": "
            Dim searchStringBuyPrice As String = """buyPrice"": "
            IndividualDifferences = New List(Of IndividualDifference)
            IndividualDifferencesString = ""
            Dim nums() As String = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, "."}
            'Loop through config.json
            For i = 0 To fileContents.Length - 1
                'Search for occurance of furniId
                If fileContents(i).Contains(searchStringFurniId) Then
                    Dim lineContents = fileContents(i)
                    Dim j As Integer = lineContents.IndexOf(searchStringFurniId) + searchStringFurniId.Length - 1
                    'Get the value for furniId
                    Dim furniId = lineContents.Substring(j, lineContents.Length - j).Replace(",", "")
                    If Not IsNumeric(furniId) Then
                        If MsgBox("Non numeric value encountered: " & furniId & vbNewLine &
                                  "Do you want to proceed?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                            Exit Sub
                        End If
                    Else
                        'Get latest snapshot
                        Dim snapshot As snapshots = GetSnapShot(CInt(furniId))
                        If snapshot IsNot Nothing Then
                            Dim sellPrice As Double = 0
                            Dim buyPrice As Double = 0
                            Dim buyPriceIndex = 0, sellPriceIndex As Integer = 0

                            If fileContents.Length >= i + 3 Then
                                'loop through config.json starting from the current furniId
                                For k = i To i + 2
                                    'Get sellPrice
                                    If fileContents(k).Contains(searchStringSellPrice) Then
                                        sellPriceIndex = k
                                        Dim l As Integer = fileContents(k).IndexOf(searchStringSellPrice) +
                                            searchStringSellPrice.Length - 1
                                        sellPrice = fileContents(k).Substring(
                                            l, fileContents(k).Length - l).Replace(",", "")
                                    End If
                                    'Get buyPrice
                                    If fileContents(k).Contains(searchStringBuyPrice) Then
                                        buyPriceIndex = k
                                        Dim l As Integer = fileContents(k).IndexOf(searchStringBuyPrice) +
                                            searchStringBuyPrice.Length - 1
                                        buyPrice = fileContents(k).Substring(
                                            l, fileContents(k).Length - l).Replace(",", "")
                                    End If
                                Next
                            End If

                            'Calculate cheapestPrice's is Difference
                            Dim priceMargin As Integer = sellPrice -
                                ((nudValue.Value / 100) * sellPrice)
                            If priceMargin >= buyPrice Then
                                Module1.buyPrice = buyPrice
                                Module1.sellPrice = sellPrice
                                frmDialogue.txtAveragePrice.Text = snapshot.averagePrice
                                frmDialogue.txtCheapestPrice.Text = snapshot.cheapestPrice
                                frmDialogue.txtfurniName.Text = snapshot.furniName
                                frmDialogue.nudIndividual.Value = nudValue.Value
                                frmDialogue.ShowDialog()
                                If Module1.buyPrice > -1 Then
                                    'Set new sellPrice and buyPrice
                                    Dim x As Integer = fileContents(buyPriceIndex).IndexOf(searchStringBuyPrice) +
                                        searchStringBuyPrice.Length - 1
                                    Dim y As Integer = fileContents(sellPriceIndex).IndexOf(searchStringSellPrice) +
                                        searchStringSellPrice.Length - 1
                                    fileContents(buyPriceIndex) = fileContents(buyPriceIndex).Substring(0, x) & " " & Module1.buyPrice & ","
                                    fileContents(sellPriceIndex) = fileContents(sellPriceIndex).Substring(0, y) & " " & Module1.sellPrice & ","
                                    'Store new IndividualDifference
                                    If Module1.individual <> nudValue.Value Then
                                        IndividualDifferences.Add(
                                            New IndividualDifference() With {
                                                .furniId = furniId,
                                                .IndividualPercent = Module1.individual
                                            }
                                        )
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            Next

            MsgBox("Operation Completed!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        configLines = fileContents
        'Convert to json object
        IndividualDifferencesString = JsonConvert.SerializeObject(IndividualDifferences, Formatting.Indented)
    End Sub

    Private Function GetSnapShot(num As Integer) As snapshots

        If String.IsNullOrEmpty(txtFurnIdJson.Text) Then
            btnConfigJson.Focus()
            Throw New Exception("Attach a furnid folder to proceed.")
        End If
        Dim fileName As String = txtFurnIdJson.Text & "\room\" & num & ".json"
        If Not IO.File.Exists(fileName) Then
            fileName = txtFurnIdJson.Text & "\wall\" & num & ".json"
            If Not IO.File.Exists(fileName) Then
                Throw New Exception("File not found." & vbNewLine & "Locations checked:" & vbNewLine &
                                    txtFurnIdJson.Text & "\room\" & num & ".json" & vbNewLine &
                                    txtFurnIdJson.Text & "\wall\" & num & ".json")
            End If

        End If

        Dim fileContentsFurnId As String = My.Computer.FileSystem.ReadAllText(fileName)

        'Get the nearest timestamp
        Dim js = JObject.Parse(fileContentsFurnId)
        Dim snapshots = js("snapshots")
        Dim index As Integer = 0
        Dim Count As Integer = snapshots.Children.Count
        If Count = 0 Then
            Throw New Exception(fileName & " has no snapshots")
        End If
        For i = 0 To Count - 1
            If snapshots.Children.ElementAt(i) IsNot Nothing Then
                Dim val = (snapshots.Children.ElementAt(i).SelectToken("timestamp"))
                Dim val2 = (snapshots.Children.ElementAt(index).SelectToken("timestamp"))
                If CLng(val) > CLng(val2) Then
                    index = i
                End If
            End If
        Next

        Return New snapshots() With {
            .averagePrice = snapshots.Children.ElementAt(index).SelectToken("averagePrice"),
            .cheapestOfferId = snapshots.Children.ElementAt(index).SelectToken("cheapestOfferId"),
            .cheapestPrice = snapshots.Children.ElementAt(index).SelectToken("cheapestPrice"),
            .offerCount = snapshots.Children.ElementAt(index).SelectToken("offerCount"),
            .timestamp = snapshots.Children.ElementAt(index).SelectToken("timestamp"),
            .furniName = js.SelectToken("furniName")
        }
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'IndividualDifferencesString = JsonConvert.SerializeObject(IndividualDifferences, Formatting.Indented)
            If configLines.Length = 0 Then
                Throw New Exception("Nothing to save")
            End If

            If IndividualDifferencesString.Length > 0 Then
                sfd.Title = "Save margindifference.json"
                sfd.FileName = "margindifference.json"
                If sfd.ShowDialog = DialogResult.OK Then
                    IO.File.WriteAllText(sfd.FileName, IndividualDifferencesString)
                    MsgBox("Saved Individual Differences")
                End If
            End If
            sfd.Title = "Save config.json"
            sfd.FileName = "config.json"
            If sfd.ShowDialog = DialogResult.OK Then
                IO.File.WriteAllLines(sfd.FileName, configLines)
                MsgBox("Saved Config")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
