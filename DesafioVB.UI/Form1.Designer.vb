Imports DesafioVB.CossCutting.DesafioVB.DTOs
Imports DesafioVB.Business.Interfaces.Services
Imports DesafioVB.Entities.DesafioVB.Entities
Imports DesafioVB.CossCutting
Imports DesafioVB.CossCutting.DesafioVB.Common

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private ReadOnly _transacaoService As ITransacaoService

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
        btnSelecionarFiltro = New Button()
        Panel3 = New Panel()
        lblStatusTransacaoSelecionado = New Label()
        lblValorTransacaoSelecionado = New Label()
        lblDataTransacaoSelecionada = New Label()
        lblFiltroCartaoSelecionado = New Label()
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
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(nudValorTransacao, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTransacoes, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
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
        btnLimpar.Location = New Point(298, 525)
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
        btnDeletar.Location = New Point(173, 525)
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
        dgvTransacoes.TabIndex = 3
        ' 
        ' btnSelecionarFiltro
        ' 
        btnSelecionarFiltro.BackColor = Color.Blue
        btnSelecionarFiltro.Cursor = Cursors.Hand
        btnSelecionarFiltro.Font = New Font("Segoe UI", 16.0F)
        btnSelecionarFiltro.ForeColor = Color.Transparent
        btnSelecionarFiltro.Location = New Point(424, 525)
        btnSelecionarFiltro.MaximumSize = New Size(100, 50)
        btnSelecionarFiltro.MinimumSize = New Size(50, 0)
        btnSelecionarFiltro.Name = "btnSelecionarFiltro"
        btnSelecionarFiltro.Size = New Size(100, 46)
        btnSelecionarFiltro.TabIndex = 8
        btnSelecionarFiltro.Text = "Filtro"
        btnSelecionarFiltro.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(lblStatusTransacaoSelecionado)
        Panel3.Controls.Add(lblValorTransacaoSelecionado)
        Panel3.Controls.Add(lblDataTransacaoSelecionada)
        Panel3.Controls.Add(lblFiltroCartaoSelecionado)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(565, 530)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(654, 74)
        Panel3.TabIndex = 19
        ' 
        ' lblStatusTransacaoSelecionado
        ' 
        lblStatusTransacaoSelecionado.AutoSize = True
        lblStatusTransacaoSelecionado.BorderStyle = BorderStyle.FixedSingle
        lblStatusTransacaoSelecionado.Location = New Point(481, 37)
        lblStatusTransacaoSelecionado.MaximumSize = New Size(150, 20)
        lblStatusTransacaoSelecionado.MinimumSize = New Size(150, 20)
        lblStatusTransacaoSelecionado.Name = "lblStatusTransacaoSelecionado"
        lblStatusTransacaoSelecionado.Size = New Size(150, 20)
        lblStatusTransacaoSelecionado.TabIndex = 7
        ' 
        ' lblValorTransacaoSelecionado
        ' 
        lblValorTransacaoSelecionado.AutoSize = True
        lblValorTransacaoSelecionado.BorderStyle = BorderStyle.FixedSingle
        lblValorTransacaoSelecionado.Location = New Point(481, 9)
        lblValorTransacaoSelecionado.MaximumSize = New Size(150, 20)
        lblValorTransacaoSelecionado.MinimumSize = New Size(150, 20)
        lblValorTransacaoSelecionado.Name = "lblValorTransacaoSelecionado"
        lblValorTransacaoSelecionado.Size = New Size(150, 20)
        lblValorTransacaoSelecionado.TabIndex = 6
        ' 
        ' lblDataTransacaoSelecionada
        ' 
        lblDataTransacaoSelecionada.AutoSize = True
        lblDataTransacaoSelecionada.BorderStyle = BorderStyle.FixedSingle
        lblDataTransacaoSelecionada.Location = New Point(145, 35)
        lblDataTransacaoSelecionada.MaximumSize = New Size(150, 20)
        lblDataTransacaoSelecionada.MinimumSize = New Size(150, 20)
        lblDataTransacaoSelecionada.Name = "lblDataTransacaoSelecionada"
        lblDataTransacaoSelecionada.Size = New Size(150, 20)
        lblDataTransacaoSelecionada.TabIndex = 5
        ' 
        ' lblFiltroCartaoSelecionado
        ' 
        lblFiltroCartaoSelecionado.AutoSize = True
        lblFiltroCartaoSelecionado.BorderStyle = BorderStyle.FixedSingle
        lblFiltroCartaoSelecionado.Location = New Point(145, 9)
        lblFiltroCartaoSelecionado.MaximumSize = New Size(150, 20)
        lblFiltroCartaoSelecionado.MinimumSize = New Size(150, 20)
        lblFiltroCartaoSelecionado.Name = "lblFiltroCartaoSelecionado"
        lblFiltroCartaoSelecionado.Size = New Size(150, 20)
        lblFiltroCartaoSelecionado.TabIndex = 4
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
        BtnBuscarTransacoes.Location = New Point(1039, 610)
        BtnBuscarTransacoes.MaximumSize = New Size(180, 38)
        BtnBuscarTransacoes.MinimumSize = New Size(180, 38)
        BtnBuscarTransacoes.Name = "BtnBuscarTransacoes"
        BtnBuscarTransacoes.Size = New Size(180, 38)
        BtnBuscarTransacoes.TabIndex = 10
        BtnBuscarTransacoes.Text = "Buscar Dados"
        BtnBuscarTransacoes.TextAlign = ContentAlignment.TopCenter
        BtnBuscarTransacoes.UseVisualStyleBackColor = False
        ' 
        ' NudPaginaca
        ' 
        NudPaginaca.Font = New Font("Segoe UI", 16.0F)
        NudPaginaca.Location = New Point(951, 611)
        NudPaginaca.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        NudPaginaca.MaximumSize = New Size(70, 0)
        NudPaginaca.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        NudPaginaca.MinimumSize = New Size(70, 0)
        NudPaginaca.Name = "NudPaginaca"
        NudPaginaca.Size = New Size(70, 36)
        NudPaginaca.TabIndex = 9
        NudPaginaca.TextAlign = HorizontalAlignment.Center
        NudPaginaca.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 16.0F)
        Label13.Location = New Point(835, 613)
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(1264, 681)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(NudPaginaca)
        Controls.Add(BtnBuscarTransacoes)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(Panel3)
        Controls.Add(btnSelecionarFiltro)
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
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(NudPaginaca, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub



    ' Construtor que aceita TransacaoRepository como dependência
    Public Sub New(transacaoService As ITransacaoService)
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        _transacaoService = transacaoService
    End Sub

    ' Exemplo de uso do repositório
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbStatusTransacao.DataSource = StatusTransacaoEnum.GetNames(GetType(StatusTransacaoEnum))

        AtualizarGrid()

        'Obter lista de transações com paginação e preencher o grid
        'Dim transacoes = _transacaoService.GetAllPaginado(NudPaginaca.Value, 10)
        'dgvTransacoes.DataSource = transacoes

        ' Ocultar a coluna IdTransacao
        dgvTransacoes.Columns("IdTransacao").Visible = False





        ' Faça algo com as transações
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
    Friend WithEvents btnSelecionarFiltro As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnBuscarTransacoes As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblFiltroCartaoSelecionado As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblStatusTransacaoSelecionado As Label
    Friend WithEvents lblValorTransacaoSelecionado As Label
    Friend WithEvents lblDataTransacaoSelecionada As Label
    Friend WithEvents nudValorTransacao As NumericUpDown
    Friend WithEvents mtbNumeroCartao As MaskedTextBox
    Friend WithEvents NudPaginaca As NumericUpDown

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        'instanciar os DTOs de create e update



        If String.IsNullOrEmpty(TxtIdTransacao.Text) Then
            ' Adicionar nova transação
            Dim numeroCartaoSemEspacos = mtbNumeroCartao.Text.Replace(" ", "")
            Dim statusTransacaoEnum As StatusTransacaoEnum = CType([Enum].Parse(GetType(StatusTransacaoEnum), cmbStatusTransacao.Text), StatusTransacaoEnum)
            Dim createTransacao As New CreateTransacaoDTO With {
            .NumeroCartao = numeroCartaoSemEspacos,
            .ValorTransacao = nudValorTransacao.Value,
            .DataTransacao = dtpDataTransacao.Value,
            .Descricao = txtDescricaoTransacao.Text,
            .StatusTransacao = statusTransacaoEnum
}

            _transacaoService.Add(createTransacao)

            MsgBox("Transação adicionada com sucesso!", MsgBoxStyle.Information, "Sucesso")

            LimparCampos()
            AtualizarGrid()
        Else
            ' Atualizar transação existente
            Dim numeroCartaoSemEspacos = mtbNumeroCartao.Text.Replace(" ", "")
            Dim statusTransacaoEnum As StatusTransacaoEnum = CType([Enum].Parse(GetType(StatusTransacaoEnum), cmbStatusTransacao.Text), StatusTransacaoEnum)
            Dim updateTransacao As New UpdateTransacaoDTO With {
            .IdTransacao = Integer.Parse(TxtIdTransacao.Text),
            .NumeroCartao = numeroCartaoSemEspacos,
            .ValorTransacao = nudValorTransacao.Value,
            .DataTransacao = dtpDataTransacao.Value,
            .Descricao = txtDescricaoTransacao.Text,
            .StatusTransacao = statusTransacaoEnum
            }

            _transacaoService.Update(updateTransacao)

            MsgBox("Transação atualizada com sucesso!", MsgBoxStyle.Information, "Sucesso")
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
End Class
