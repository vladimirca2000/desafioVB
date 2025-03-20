Imports DesafioVB.Business.Interfaces.Services
Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.CossCutting
Imports DesafioVB.CossCutting.DesafioVB.Common
Imports FluentValidation
Imports DesafioVB.Entities.Notifications
Imports DesafioVB.Business.Services
Imports Microsoft.Extensions.Logging
Imports DesafioVB.Entities.Interfaces.Repositories
Imports DesafioVB.Entities
Imports ClosedXML.Excel
Imports System.IO

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private ReadOnly _transacaoService As ITransacaoService
    'Private ReadOnly transacaoRepository As ITransacaoRepository

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        lblTransacaoSelecionada = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        nudValorTransacao = New NumericUpDown()
        mtbNumeroCartao = New MaskedTextBox()
        cmbStatusTransacao = New ComboBox()
        txtDescricaoTransacao = New TextBox()
        dtpDataTransacao = New DateTimePicker()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TxtIdTransacao = New TextBox()
        Label2 = New Label()
        btnLimpar = New Button()
        btnDeletar = New Button()
        btnSalvar = New Button()
        dgvTransacoes = New DataGridView()
        Panel3 = New Panel()
        mtbFiltroData = New MaskedTextBox()
        cmbFiltroStatus = New ComboBox()
        nudFiltroValor = New NumericUpDown()
        mtbFiltroCartao = New MaskedTextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        BtnBuscarTransacoes = New Button()
        NudPaginaca = New NumericUpDown()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        btnExportarParaExcel = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(nudValorTransacao, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTransacoes, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(nudFiltroValor, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NudPaginaca, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSteelBlue
        Panel1.Controls.Add(lblTransacaoSelecionada)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(0, -2)
        Panel1.Margin = New Padding(0)
        Panel1.MaximumSize = New Size(1264, 63)
        Panel1.MinimumSize = New Size(1264, 63)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1264, 63)
        Panel1.TabIndex = 0
        ' 
        ' lblTransacaoSelecionada
        ' 
        lblTransacaoSelecionada.AutoSize = True
        lblTransacaoSelecionada.Font = New Font("Segoe UI", 25.0F)
        lblTransacaoSelecionada.ForeColor = Color.MediumBlue
        lblTransacaoSelecionada.Location = New Point(234, 12)
        lblTransacaoSelecionada.MaximumSize = New Size(250, 46)
        lblTransacaoSelecionada.MinimumSize = New Size(250, 46)
        lblTransacaoSelecionada.Name = "lblTransacaoSelecionada"
        lblTransacaoSelecionada.Size = New Size(250, 46)
        lblTransacaoSelecionada.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 25.0F)
        Label1.ForeColor = Color.MediumPurple
        Label1.Location = New Point(47, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 46)
        Label1.TabIndex = 1
        Label1.Text = "Transação :"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(nudValorTransacao)
        Panel2.Controls.Add(mtbNumeroCartao)
        Panel2.Controls.Add(cmbStatusTransacao)
        Panel2.Controls.Add(txtDescricaoTransacao)
        Panel2.Controls.Add(dtpDataTransacao)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(TxtIdTransacao)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(47, 108)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(477, 411)
        Panel2.TabIndex = 2
        ' 
        ' nudValorTransacao
        ' 
        nudValorTransacao.DecimalPlaces = 2
        nudValorTransacao.Font = New Font("Segoe UI", 9.0F)
        nudValorTransacao.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        nudValorTransacao.Location = New Point(222, 91)
        nudValorTransacao.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        nudValorTransacao.Name = "nudValorTransacao"
        nudValorTransacao.Size = New Size(200, 23)
        nudValorTransacao.TabIndex = 1
        nudValorTransacao.TextAlign = HorizontalAlignment.Right
        ' 
        ' mtbNumeroCartao
        ' 
        mtbNumeroCartao.Location = New Point(222, 32)
        mtbNumeroCartao.Mask = "0000 0000 0000 0000"
        mtbNumeroCartao.Name = "mtbNumeroCartao"
        mtbNumeroCartao.Size = New Size(200, 23)
        mtbNumeroCartao.TabIndex = 0
        ' 
        ' cmbStatusTransacao
        ' 
        cmbStatusTransacao.FormattingEnabled = True
        cmbStatusTransacao.Location = New Point(222, 347)
        cmbStatusTransacao.Name = "cmbStatusTransacao"
        cmbStatusTransacao.Size = New Size(200, 23)
        cmbStatusTransacao.TabIndex = 4
        ' 
        ' txtDescricaoTransacao
        ' 
        txtDescricaoTransacao.Location = New Point(222, 212)
        txtDescricaoTransacao.Multiline = True
        txtDescricaoTransacao.Name = "txtDescricaoTransacao"
        txtDescricaoTransacao.Size = New Size(200, 97)
        txtDescricaoTransacao.TabIndex = 3
        ' 
        ' dtpDataTransacao
        ' 
        dtpDataTransacao.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dtpDataTransacao.Format = DateTimePickerFormat.Short
        dtpDataTransacao.Location = New Point(222, 152)
        dtpDataTransacao.Name = "dtpDataTransacao"
        dtpDataTransacao.Size = New Size(200, 23)
        dtpDataTransacao.TabIndex = 2
        dtpDataTransacao.Value = New Date(2025, 3, 18, 21, 49, 55, 0)
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F)
        Label6.Location = New Point(30, 345)
        Label6.Name = "Label6"
        Label6.Size = New Size(146, 21)
        Label6.TabIndex = 4
        Label6.Text = "Status da Transação"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F)
        Label5.Location = New Point(99, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 21)
        Label5.TabIndex = 3
        Label5.Text = "Descrição"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F)
        Label4.Location = New Point(40, 154)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 21)
        Label4.TabIndex = 2
        Label4.Text = "Data da Transação"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F)
        Label3.Location = New Point(36, 88)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 21)
        Label3.TabIndex = 1
        Label3.Text = "Valor da Transação"
        ' 
        ' TxtIdTransacao
        ' 
        TxtIdTransacao.Location = New Point(76, 269)
        TxtIdTransacao.Name = "TxtIdTransacao"
        TxtIdTransacao.Size = New Size(100, 23)
        TxtIdTransacao.TabIndex = 4
        TxtIdTransacao.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F)
        Label2.Location = New Point(36, 30)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 21)
        Label2.TabIndex = 0
        Label2.Text = "Número do Cartão"
        ' 
        ' btnLimpar
        ' 
        btnLimpar.BackColor = Color.White
        btnLimpar.Cursor = Cursors.Hand
        btnLimpar.Font = New Font("Segoe UI", 16.0F)
        btnLimpar.ForeColor = Color.Black
        btnLimpar.Location = New Point(424, 525)
        btnLimpar.MaximumSize = New Size(100, 50)
        btnLimpar.MinimumSize = New Size(50, 0)
        btnLimpar.Name = "btnLimpar"
        btnLimpar.Size = New Size(100, 46)
        btnLimpar.TabIndex = 7
        btnLimpar.Text = "Limpar"
        btnLimpar.UseVisualStyleBackColor = False
        ' 
        ' btnDeletar
        ' 
        btnDeletar.BackColor = Color.Red
        btnDeletar.Cursor = Cursors.Hand
        btnDeletar.Font = New Font("Segoe UI", 16.0F)
        btnDeletar.ForeColor = Color.White
        btnDeletar.Location = New Point(234, 525)
        btnDeletar.MaximumSize = New Size(100, 50)
        btnDeletar.MinimumSize = New Size(50, 0)
        btnDeletar.Name = "btnDeletar"
        btnDeletar.Size = New Size(100, 46)
        btnDeletar.TabIndex = 6
        btnDeletar.Text = "Deletar"
        btnDeletar.UseVisualStyleBackColor = False
        ' 
        ' btnSalvar
        ' 
        btnSalvar.BackColor = Color.Green
        btnSalvar.Cursor = Cursors.Hand
        btnSalvar.Font = New Font("Segoe UI", 16.0F)
        btnSalvar.ForeColor = Color.White
        btnSalvar.Location = New Point(47, 525)
        btnSalvar.MaximumSize = New Size(100, 50)
        btnSalvar.MinimumSize = New Size(50, 0)
        btnSalvar.Name = "btnSalvar"
        btnSalvar.Size = New Size(100, 46)
        btnSalvar.TabIndex = 5
        btnSalvar.Text = "Salvar"
        btnSalvar.UseVisualStyleBackColor = False
        ' 
        ' dgvTransacoes
        ' 
        dgvTransacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransacoes.Location = New Point(565, 108)
        dgvTransacoes.Name = "dgvTransacoes"
        dgvTransacoes.ReadOnly = True
        dgvTransacoes.Size = New Size(654, 411)
        dgvTransacoes.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(mtbFiltroData)
        Panel3.Controls.Add(cmbFiltroStatus)
        Panel3.Controls.Add(nudFiltroValor)
        Panel3.Controls.Add(mtbFiltroCartao)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(565, 574)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(654, 74)
        Panel3.TabIndex = 19
        ' 
        ' mtbFiltroData
        ' 
        mtbFiltroData.Location = New Point(145, 37)
        mtbFiltroData.Mask = "00/00/0000"
        mtbFiltroData.Name = "mtbFiltroData"
        mtbFiltroData.Size = New Size(150, 23)
        mtbFiltroData.TabIndex = 11
        ' 
        ' cmbFiltroStatus
        ' 
        cmbFiltroStatus.FormattingEnabled = True
        cmbFiltroStatus.Location = New Point(481, 38)
        cmbFiltroStatus.Name = "cmbFiltroStatus"
        cmbFiltroStatus.Size = New Size(150, 23)
        cmbFiltroStatus.TabIndex = 12
        ' 
        ' nudFiltroValor
        ' 
        nudFiltroValor.DecimalPlaces = 2
        nudFiltroValor.Font = New Font("Segoe UI", 9.0F)
        nudFiltroValor.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        nudFiltroValor.Location = New Point(481, 7)
        nudFiltroValor.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        nudFiltroValor.Name = "nudFiltroValor"
        nudFiltroValor.Size = New Size(150, 23)
        nudFiltroValor.TabIndex = 10
        nudFiltroValor.TextAlign = HorizontalAlignment.Right
        ' 
        ' mtbFiltroCartao
        ' 
        mtbFiltroCartao.Location = New Point(145, 6)
        mtbFiltroCartao.Mask = "0000 0000 0000 0000"
        mtbFiltroCartao.Name = "mtbFiltroCartao"
        mtbFiltroCartao.Size = New Size(150, 23)
        mtbFiltroCartao.TabIndex = 9
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(334, 42)
        Label12.Name = "Label12"
        Label12.Size = New Size(111, 15)
        Label12.TabIndex = 3
        Label12.Text = "Status da Transação"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(340, 14)
        Label11.Name = "Label11"
        Label11.Size = New Size(105, 15)
        Label11.TabIndex = 2
        Label11.Text = "Valor da Transação"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(22, 40)
        Label10.Name = "Label10"
        Label10.Size = New Size(87, 15)
        Label10.TabIndex = 1
        Label10.Text = "Data Transação"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(20, 14)
        Label9.Name = "Label9"
        Label9.Size = New Size(89, 15)
        Label9.TabIndex = 0
        Label9.Text = "Número Cartão"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.CreditCard
        PictureBox1.Image = My.Resources.Resources.CreditCard
        PictureBox1.Location = New Point(47, 613)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(46, 35)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 16.0F)
        Label7.Location = New Point(99, 613)
        Label7.Name = "Label7"
        Label7.Size = New Size(425, 30)
        Label7.TabIndex = 21
        Label7.Text = "XYZ Administradora de Cartões de Crédito"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.LightSteelBlue
        Label8.Location = New Point(0, 662)
        Label8.Margin = New Padding(0)
        Label8.MaximumSize = New Size(1264, 20)
        Label8.MinimumSize = New Size(1264, 20)
        Label8.Name = "Label8"
        Label8.Size = New Size(1264, 20)
        Label8.TabIndex = 22
        Label8.Text = "Desavio VB  - By Vladimir Carlos Alves"
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BtnBuscarTransacoes
        ' 
        BtnBuscarTransacoes.BackColor = Color.SlateGray
        BtnBuscarTransacoes.Cursor = Cursors.Hand
        BtnBuscarTransacoes.Font = New Font("Segoe UI", 16.0F)
        BtnBuscarTransacoes.ForeColor = Color.Transparent
        BtnBuscarTransacoes.Location = New Point(930, 529)
        BtnBuscarTransacoes.MaximumSize = New Size(180, 38)
        BtnBuscarTransacoes.MinimumSize = New Size(180, 38)
        BtnBuscarTransacoes.Name = "BtnBuscarTransacoes"
        BtnBuscarTransacoes.Size = New Size(180, 38)
        BtnBuscarTransacoes.TabIndex = 14
        BtnBuscarTransacoes.Text = "Buscar Dados"
        BtnBuscarTransacoes.TextAlign = ContentAlignment.TopCenter
        BtnBuscarTransacoes.UseVisualStyleBackColor = False
        ' 
        ' NudPaginaca
        ' 
        NudPaginaca.Font = New Font("Segoe UI", 16.0F)
        NudPaginaca.Location = New Point(854, 531)
        NudPaginaca.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        NudPaginaca.MaximumSize = New Size(70, 0)
        NudPaginaca.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NudPaginaca.MinimumSize = New Size(70, 0)
        NudPaginaca.Name = "NudPaginaca"
        NudPaginaca.Size = New Size(70, 36)
        NudPaginaca.TabIndex = 13
        NudPaginaca.TextAlign = HorizontalAlignment.Center
        NudPaginaca.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 16.0F)
        Label13.Location = New Point(738, 533)
        Label13.Name = "Label13"
        Label13.Size = New Size(110, 30)
        Label13.TabIndex = 23
        Label13.Text = "Paginação"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(565, 90)
        Label14.Name = "Label14"
        Label14.Size = New Size(268, 15)
        Label14.TabIndex = 24
        Label14.Text = "Lista de Transações - Duplo clique para selecionar"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(565, 556)
        Label15.Name = "Label15"
        Label15.Size = New Size(34, 15)
        Label15.TabIndex = 25
        Label15.Text = "Filtro"
        ' 
        ' btnExportarParaExcel
        ' 
        btnExportarParaExcel.BackColor = Color.Blue
        btnExportarParaExcel.Font = New Font("Segoe UI", 16.0F)
        btnExportarParaExcel.ForeColor = Color.White
        btnExportarParaExcel.Location = New Point(1139, 529)
        btnExportarParaExcel.MaximumSize = New Size(80, 38)
        btnExportarParaExcel.MinimumSize = New Size(80, 38)
        btnExportarParaExcel.Name = "btnExportarParaExcel"
        btnExportarParaExcel.Size = New Size(80, 38)
        btnExportarParaExcel.TabIndex = 26
        btnExportarParaExcel.Text = "Excel"
        btnExportarParaExcel.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1264, 681)
        Controls.Add(btnExportarParaExcel)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(NudPaginaca)
        Controls.Add(BtnBuscarTransacoes)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(Panel3)
        Controls.Add(btnDeletar)
        Controls.Add(btnLimpar)
        Controls.Add(dgvTransacoes)
        Controls.Add(btnSalvar)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MaximumSize = New Size(1280, 720)
        MinimumSize = New Size(1280, 720)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "XYZ Administradora de Cartões de Crédito"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(nudValorTransacao, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTransacoes, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(nudFiltroValor, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(NudPaginaca, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Public Sub New(transacaoService As ITransacaoService, logger As ILogger(Of TransacaoService))

        InitializeComponent()

        Dim notification As INotification = New MessageBoxNotification()
        _transacaoService = transacaoService
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbStatusTransacao.DataSource = StatusTransacaoEnum.GetNames(GetType(StatusTransacaoEnum))


        cmbFiltroStatus.Items.Clear()
        cmbFiltroStatus.Items.Add("")
        cmbFiltroStatus.Items.AddRange([Enum].GetNames(GetType(StatusTransacaoEnum)))
        cmbFiltroStatus.SelectedIndex = 0

        AtualizarGrid()



        dgvTransacoes.Columns("IdTransacao").Visible = False

        dgvTransacoes.Columns("ValorTransacao").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        dgvTransacoes.Columns("IdTransacao").HeaderText = "Transação"
        dgvTransacoes.Columns("NumeroCartao").HeaderText = "Número do Cartão"
        dgvTransacoes.Columns("StatusTransacao").HeaderText = "Status"
        dgvTransacoes.Columns("ValorTransacao").HeaderText = "Valor da Transação"
        dgvTransacoes.Columns("Descricao").HeaderText = "Descrição"
        dgvTransacoes.Columns("DataTransacao").HeaderText = "Data Transação"
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Public WithEvents lblTransacaoSelecionada As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgvTransacoes As DataGridView
    Friend WithEvents TxtIdTransacao As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescricaoTransacao As TextBox
    Friend WithEvents dtpDataTransacao As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnLimpar As Button
    Friend WithEvents btnDeletar As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents cmbStatusTransacao As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnBuscarTransacoes As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblStatusTransacaoSelecionado As Label
    Friend WithEvents lblValorTransacaoSelecionado As Label
    Friend WithEvents nudValorTransacao As NumericUpDown
    Friend WithEvents mtbNumeroCartao As MaskedTextBox
    Friend WithEvents NudPaginaca As NumericUpDown

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        If String.IsNullOrEmpty(TxtIdTransacao.Text) Then
            ' Adicionar nova transação
            Dim numeroCartaoSemEspacos = mtbNumeroCartao.Text.Replace(" ", "")
            Dim statusTransacaoEnum As StatusTransacaoEnum = CType([Enum].Parse(GetType(StatusTransacaoEnum), cmbStatusTransacao.Text), StatusTransacaoEnum)
            Dim createTransacao As New InputTransacaoDTO With {
            .NumeroCartao = numeroCartaoSemEspacos,
            .ValorTransacao = nudValorTransacao.Value,
            .DataTransacao = dtpDataTransacao.Value,
            .Descricao = txtDescricaoTransacao.Text,
            .StatusTransacao = statusTransacaoEnum
            }

            Dim validator = New TransacaoFilterDTOValidator()
            Dim results = validator.Validate(createTransacao)

            If Not results.IsValid Then
                Dim validationErrors = String.Join(Environment.NewLine, results.Errors.Select(Function(err) err.ErrorMessage))
                MessageBox.Show(validationErrors, "Erros de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            _transacaoService.Add(createTransacao)

            LimparCampos()
            AtualizarGrid()
        Else
            Dim numeroCartaoSemEspacos = mtbNumeroCartao.Text.Replace(" ", "")
            Dim statusTransacaoEnum As StatusTransacaoEnum = CType([Enum].Parse(GetType(StatusTransacaoEnum), cmbStatusTransacao.Text), StatusTransacaoEnum)
            Dim updateTransacao As New InputTransacaoDTO With {
            .IdTransacao = Integer.Parse(TxtIdTransacao.Text),
            .NumeroCartao = numeroCartaoSemEspacos,
            .ValorTransacao = nudValorTransacao.Value,
            .DataTransacao = dtpDataTransacao.Value,
            .Descricao = txtDescricaoTransacao.Text,
            .StatusTransacao = statusTransacaoEnum
            }

            Dim validator = New TransacaoFilterDTOValidator()
            Dim results = validator.Validate(updateTransacao)

            If Not results.IsValid Then
                Dim validationErrors = String.Join(Environment.NewLine, results.Errors.Select(Function(err) err.ErrorMessage))
                MessageBox.Show(validationErrors, "Erros de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            _transacaoService.Update(updateTransacao)

            LimparCampos()
            AtualizarGrid()
        End If

    End Sub

    Protected Sub LimparCampos()
        lblTransacaoSelecionada.Text = ""
        TxtIdTransacao.Text = ""
        mtbNumeroCartao.Text = ""
        nudValorTransacao.Value = 0
        dtpDataTransacao.Value = DateTime.Now
        txtDescricaoTransacao.Text = ""
        cmbStatusTransacao.SelectedIndex = 0
    End Sub

    Protected Sub AtualizarGrid()
        Dim transacoes = _transacaoService.GetAllPaginado(NudPaginaca.Value, 10)
        dgvTransacoes.DataSource = transacoes

    End Sub

    Private Sub dgvTransacoes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransacoes.CellContentDoubleClick
        Dim idTransacao = dgvTransacoes.CurrentRow.Cells(0).Value

        Dim transacao = _transacaoService.GetById(idTransacao)


        TxtIdTransacao.Text = transacao.IdTransacao.ToString
        mtbNumeroCartao.Text = transacao.NumeroCartao
        nudValorTransacao.Value = transacao.ValorTransacao
        dtpDataTransacao.Value = transacao.DataTransacao
        txtDescricaoTransacao.Text = transacao.Descricao
        cmbStatusTransacao.SelectedItem = transacao.StatusTransacao.ToString

        lblTransacaoSelecionada.Text = transacao.IdTransacao.ToString

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label

    Private Sub dgvTransacoes_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransacoes.CellContentClick

    End Sub

    Private Sub btnLimpar_Click(sender As Object, e As EventArgs) Handles btnLimpar.Click

        LimparCampos()
        AtualizarGrid()

        mtbFiltroCartao.Text = ""
        mtbFiltroData.Text = ""
        cmbFiltroStatus.SelectedIndex = 0
        nudFiltroValor.Value = 0

    End Sub

    Private Sub btnDeletar_Click(sender As Object, e As EventArgs) Handles btnDeletar.Click
        If String.IsNullOrEmpty(TxtIdTransacao.Text) Then
            MsgBox("Selecione uma transação para excluir.", MsgBoxStyle.Critical, "Atenção")
            Exit Sub
        End If

        Dim result As Integer = MessageBox.Show("Deseja realmente excluir a transação selecionada?", "Excluir Transação", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Dim idTransacao = Integer.Parse(TxtIdTransacao.Text)
            _transacaoService.Delete(idTransacao)
            MsgBox("Transação excluída com sucesso!", MsgBoxStyle.Information, "Sucesso")
            LimparCampos()
            AtualizarGrid()
        End If

    End Sub
    Friend WithEvents mtbFiltroCartao As MaskedTextBox
    Friend WithEvents cmbFiltroStatus As ComboBox
    Friend WithEvents nudFiltroValor As NumericUpDown
    Friend WithEvents mtbFiltroData As MaskedTextBox
    Friend WithEvents Label15 As Label

    Private Sub BtnBuscarTransacoes_Click(sender As Object, e As EventArgs) Handles BtnBuscarTransacoes.Click
        Dim validator = New TransacaoFilterDTOValidator()
        Dim transacaoFiltro = validator.ValidarFiltros(mtbFiltroData.Text, nudFiltroValor.Value.ToString(), cmbFiltroStatus.Text, mtbFiltroCartao.Text)

        If transacaoFiltro Is Nothing Then

            MsgBox("Nenhum filtro aplicado. Procedendo sem filtros.", MsgBoxStyle.Information, "Informação")

            Dim transacoes = _transacaoService.GetAllPaginado(NudPaginaca.Value, 10)
            dgvTransacoes.DataSource = transacoes
            Return
        Else

            Dim dataTransacao As DateTime? = Nothing
            If Not String.IsNullOrWhiteSpace(mtbFiltroData.Text) AndAlso mtbFiltroData.Text <> "  /  /" Then
                If DateTime.TryParseExact(mtbFiltroData.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, Nothing) Then
                    dataTransacao = DateTime.ParseExact(mtbFiltroData.Text, "dd/MM/yyyy", Nothing)
                Else
                    MsgBox("Data inválida. Por favor, insira uma data no formato dd/MM/yyyy.", MsgBoxStyle.Exclamation, "Erro")
                    Return
                End If
            End If



            Dim valorTransacao As Decimal? = Nothing
            If nudFiltroValor.Value > 0 Then
                valorTransacao = nudFiltroValor.Value
            End If

            Dim statusTransacao As StatusTransacaoEnum? = Nothing
            If Not String.IsNullOrEmpty(cmbFiltroStatus.Text) Then
                statusTransacao = CType([Enum].Parse(GetType(StatusTransacaoEnum), cmbFiltroStatus.Text), StatusTransacaoEnum)
            End If

            Dim numeroCartao As String = mtbFiltroCartao.Text.Replace(" ", "")

            Dim transacoesFiltradas = _transacaoService.GetByFilters(dataTransacao, valorTransacao, statusTransacao, numeroCartao, NudPaginaca.Value, 10)
            dgvTransacoes.DataSource = transacoesFiltradas
        End If





    End Sub

    Friend WithEvents btnExportarParaExcel As Button

    Private Sub btnExportarParaExcel_Click(sender As Object, e As EventArgs) Handles btnExportarParaExcel.Click
        Dim caminhoPasta As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim nomeArquivo As String = "transacoes" & DateTime.Now.ToString("_yyyy-MM-dd_HHmm") & ".xlsx"
        Dim caminhoArquivo As String = Path.Combine(caminhoPasta, nomeArquivo)
        ExportarDataGridViewParaExcel(Me.dgvTransacoes, caminhoArquivo)
        MessageBox.Show("Exportação concluída com sucesso!", "Exportar para Excel", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub



    Public Sub ExportarDataGridViewParaExcel(dataGridView As DataGridView, caminhoArquivo As String)
        Dim workbook As New XLWorkbook()
        Dim worksheet = workbook.Worksheets.Add("Transacoes")


        For col As Integer = 0 To dataGridView.Columns.Count - 1
            worksheet.Cell(1, col + 1).Value = dataGridView.Columns(col).HeaderText
        Next

        For row As Integer = 0 To dataGridView.Rows.Count - 1
            For col As Integer = 0 To dataGridView.Columns.Count - 1
                Dim cellValue = dataGridView.Rows(row).Cells(col).Value
                If cellValue IsNot Nothing Then
                    If dataGridView.Columns(col).HeaderText = "Valor da Transação" Then
                        worksheet.Cell(row + 2, col + 1).Value = Convert.ToDecimal(cellValue)
                        worksheet.Cell(row + 2, col + 1).Style.NumberFormat.Format = "#,##0.00"
                    ElseIf dataGridView.Columns(col).HeaderText = "Data Transação" Then
                        worksheet.Cell(row + 2, col + 1).Value = Convert.ToDateTime(cellValue)
                        worksheet.Cell(row + 2, col + 1).Style.DateFormat.Format = "dd/MM/yyyy"
                    Else
                        worksheet.Cell(row + 2, col + 1).Value = cellValue.ToString()
                    End If
                End If
            Next
        Next


        Using stream As New FileStream(caminhoArquivo, FileMode.Create, FileAccess.Write)
            workbook.SaveAs(stream)
        End Using
    End Sub
End Class
