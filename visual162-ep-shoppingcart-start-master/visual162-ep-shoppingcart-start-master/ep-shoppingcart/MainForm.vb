Public Class MainForm


    Private PanelH As Boolean = True
    Private PanelM As Boolean = False
    Private PanelC As Boolean = False
    Private PanelA As Boolean = False


    Private CantHL1 As Integer = 0
    Private CantHL2 As Integer = 0
    Private CantHL3 As Integer = 0
    Private CantHL4 As Integer = 0

    Private CantML1 As Integer = 0
    Private CantML2 As Integer = 0
    Private CantML3 As Integer = 0
    Private CantML4 As Integer = 0

    Private CantCL1 As Integer = 0
    Private CantCL2 As Integer = 0
    Private CantCL3 As Integer = 0
    Private CantCL4 As Integer = 0

    Private CantAL1 As Integer = 0
    Private CantAL2 As Integer = 0
    Private CantAL3 As Integer = 0
    Private CantAL4 As Integer = 0

    Private Total As Integer = 0


    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTituloprenda1.Click

    End Sub

    Private Sub tblNavigation_Paint(sender As Object, e As PaintEventArgs) Handles tblNavigation.Paint

    End Sub

    Private Sub tblProdSmall_Paint(sender As Object, e As PaintEventArgs) Handles tblProdSmall.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbproducto1.Click
        Me.pbproducto1 = New System.Windows.Forms.PictureBox()






    End Sub

    Private Sub TblTallaLista_Paint(sender As Object, e As PaintEventArgs) Handles TblTallaLista.Paint

    End Sub

    Private Sub btnHombres_Click(sender As Object, e As EventArgs) Handles btnHombres.Click


        btnHombres.ForeColor = Color.AliceBlue
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnaccesorios.ForeColor = Color.Black




        lblTituloprenda1.Text = "Cotton Linen V - Neck Jumper"
        lblPrecioGrande.Text = "$95"

        lblTituloprenda1.Text = "Eng Poplin Shirt"
        lblPrecioGrande.Text = "$85"




    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click



        lblTituloprenda1.Text = "Cotton Linen V - Neck Jumper"
        lblPrecioGrande.Text = "$95"

        lblTituloprenda1.Text = "Nicola Blues "
        lblPrecioGrande.Text = "$120"







    End Sub

    Private Sub btnMujeres_Click(sender As Object, e As EventArgs) Handles btnMujeres.Click

        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.AliceBlue
        btnCalzado.ForeColor = Color.Black
        btnaccesorios.ForeColor = Color.Black




    End Sub

    Private Sub btnCalzado_Click(sender As Object, e As EventArgs) Handles btnCalzado.Click



        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.AliceBlue
        btnaccesorios.ForeColor = Color.Black

    End Sub

    Private Sub btnaccesorios_Click(sender As Object, e As EventArgs) Handles btnaccesorios.Click


        btnHombres.ForeColor = Color.Black
        btnMujeres.ForeColor = Color.Black
        btnCalzado.ForeColor = Color.Black
        btnaccesorios.ForeColor = Color.AliceBlue

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class