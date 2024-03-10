Public Class Form1
    Private RegistroActual As Single, flag As Byte
    Private miConexion As New OleDb.OleDbConnection, miAdapter As OleDb.OleDbDataAdapter
    Private miComandoABM As OleDb.OleDbCommandBuilder, miDataSet As New DataSet

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnAceptar.Enabled = False
        miConexion.ConnectionString = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=D:\strah\prog\Evaluacion\Evaluacion\bin\Debug\database.mdb"
        miConexion.Open()
        miAdapter = New OleDb.OleDbDataAdapter("Select * from Tabla1 order by CodProd", miConexion)
        miAdapter.Fill(miDataSet, "dtTabla1")
        miComandoABM = New OleDb.OleDbCommandBuilder(miAdapter)
        miConexion.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim Registro As DataRow
        Dim a As Single, b As Single, c As Single
        a = Val(TxtCodPro.Text)
        b = Val(TxtStock.Text)
        c = Val(TxtCant.Text)
        Registro = miDataSet.Tables("dtTabla1").Rows(a)
        If flag = 0 Then
            Registro("Stock") = b + c
        Else
            Registro("Stock") = b - c
        End If

        miConexion.Open()
        Me.miAdapter.Update(Me.miDataSet.Tables("dtTabla1"))
        miConexion.Close()
        cargar(a)
    End Sub
    Private Sub txtCodPro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodPro.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtCodPro_TextChanged(sender As Object, e As EventArgs) Handles TxtCodPro.TextChanged
        If TxtCodPro.Text <> "" Then
            cargar(TxtCodPro.Text)
        End If
    End Sub

    Private Sub TxtCant_TextChanged(sender As Object, e As EventArgs) Handles TxtCant.TextChanged
        If flag = 1 Then
            Dim a, b, c, d As Single
            a = Val(TxtCant.Text)
            b = Val(TxtPreUni.Text)
            TxtSubTotal.Text = a * b
            c = Val(TxtSubTotal.Text)
            TxtIva.Text = (c * 21) / 100
            d = Val(TxtIva.Text)
            TxtTotal.Text = c + d
        End If



    End Sub
    Private Sub txtCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCant.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub BtnVender_Click(sender As Object, e As EventArgs) Handles BtnVender.Click
        flag = 1
        BtnComprar.Enabled = True
        BtnVender.Enabled = False
        BtnAceptar.Enabled = True
        TxtIva.Enabled = True
        TxtSubTotal.Enabled = True
        TxtTotal.Enabled = True
        TxtPreUni.Enabled = True
        TxtDet.Enabled = True
        cargar(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnComprar.Click
        flag = 0
        BtnVender.Enabled = True
        BtnComprar.Enabled = False
        BtnAceptar.Enabled = True
        TxtIva.Enabled = False
        TxtSubTotal.Enabled = False
        TxtTotal.Enabled = False
        TxtPreUni.Enabled = False
        TxtDet.Enabled = False
        cargar(0)
    End Sub
    Private Sub cargar(ByVal Nregistro As Single)
        TxtCodPro.Text = miDataSet.Tables("dtTabla1").Rows(Nregistro).Item("CodProd").ToString
        TxtDet.Text = miDataSet.Tables("dtTabla1").Rows(Nregistro).Item("Detalle").ToString
        TxtStock.Text = miDataSet.Tables("dtTabla1").Rows(Nregistro).Item("Stock").ToString
        TxtPreUni.Text = miDataSet.Tables("dtTabla1").Rows(Nregistro).Item("PreUni").ToString
    End Sub

End Class
