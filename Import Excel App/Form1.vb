Imports ExcelDataReader
Imports System.IO

Public Class Form1
    Dim tables As DataTableCollection
    Private Sub BtnBrowse_Click(sender As Object, e As EventArgs) Handles BtnBrowse.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"}
            If ofd.ShowDialog() = DialogResult.OK Then
                TxtFileName.Text = ofd.FileName
                ' excel net vb file
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance)
                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    ' vb net read excel file to datatable
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                        ' vb.net read excel file into datatable
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                 .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                 .UseHeaderRow = True}})
                        tables = result.Tables
                        CoBoxSheet.Items.Clear()
                        For Each table As DataTable In tables
                            CoBoxSheet.Items.Add(table.TableName)
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub

    Private Sub CoBoxSheet_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CoBoxSheet.SelectedIndexChanged
        Dim dt As DataTable = tables(CoBoxSheet.SelectedItem.ToString())
        DataGridView1.DataSource = dt
    End Sub
End Class
