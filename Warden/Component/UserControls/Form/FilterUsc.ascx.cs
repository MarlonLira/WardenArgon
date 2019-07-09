using System;
using System.Data;
using Warden.Component.Common.Button;
using Warden.Component.Common.Dropdown;
using Brasdat.Gestor.Library.Core.Classes.Helpers;

namespace Warden.Component.UserControls.Form {
    public partial class FilterUsc : BaseUsc {
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            LoadFilters();

            btn_pesquisar.OnClick += new ButtonUsc.OnClickEvent(Btn_pesquisar_OnClick);
        }

        private void Btn_pesquisar_OnClick() {

            DataTable Table = new DataTable();
            
            Table = Sql.ExecuteReader(" SELECT A.[nome], A.[codigo], A.[email], A.[tel_celular] " +
                                        " FROM FITNESS.TBL_ALUNO AS A " +
                                        " INNER JOIN COMERCIAL.TBL_CONTRATO AS B " +
                                            " ON A.[ULT_CONTRATO_ID] = B.[ID] " +
                                        " WHERE(SELECT COUNT(*) FROM COMERCIAL.TBL_CONTRATO AS B1 WHERE B1.ALUNO_ID = A.ID) = 1 " +
                                            " AND B.[DATA_CADASTRO] BETWEEN " + "2019-06-19" + " AND " + "'2019-06-30' " +
                                           " AND A.[AUDITORIA] NOT LIKE '%RENOVAR%' " +
                                            " AND A.[AUDITORIA] NOT LIKE '%CANCELAR%' "
                                            );
            Session["TableEdit"] = Table;
        }

        SqlHlp Sql { get { return SqlHlp.Instance; } }

        public void LoadFilters() {
            DropdownUsc Dd_control = new DropdownUsc();
            DropdownUsc.NewItem Item = new DropdownUsc.NewItem() { Nome = "SELECIONE A UNIDADE", Value = "0" };
            DropdownUsc.NewItem Item1 = new DropdownUsc.NewItem() { Nome = "Hi Tamarineira", Value = "1" };
            DropdownUsc.NewItem Item2 = new DropdownUsc.NewItem() { Nome = "Hi Espinheiro", Value = "5" };
            DropdownUsc.NewItem Item3 = new DropdownUsc.NewItem() { Nome = "Hi Bv2", Value = "6" };
            DropdownUsc.NewItem Item4 = new DropdownUsc.NewItem() { Nome = "Hi Bv3", Value = "10" };
            DropdownUsc.NewItem Item5 = new DropdownUsc.NewItem() { Nome = "Hi Encruzilhada", Value = "31" };

            DropdownUsc.NewItem Tipo = new DropdownUsc.NewItem() { Nome = "SELECIONE O TIPO", Value = "0" };
            DropdownUsc.NewItem Tipo1 = new DropdownUsc.NewItem() { Nome = "ALUNO", Value = "1" };
            DropdownUsc.NewItem Tipo2 = new DropdownUsc.NewItem() { Nome = "VISITANTE", Value = "2" };

            DropdownUsc.NewItem Estado = new DropdownUsc.NewItem() { Nome = "SELECIONE O ESTADO", Value = "0" };
            DropdownUsc.NewItem Estado1 = new DropdownUsc.NewItem() { Nome = "NOVATO", Value = "1" };
            DropdownUsc.NewItem Estado2 = new DropdownUsc.NewItem() { Nome = "RENOVAÇÃO", Value = "2" };
            DropdownUsc.NewItem Estado3 = new DropdownUsc.NewItem() { Nome = "ANTECIPAÇÃO", Value = "3" };
            DropdownUsc.NewItem Estado4 = new DropdownUsc.NewItem() { Nome = "CANCELADO", Value = "4" };

            DropdownUsc.NewItem [] Empresas = new DropdownUsc.NewItem[] { Item, Item1, Item2, Item3, Item4, Item5 };
            DropdownUsc.NewItem [] Tipos = new DropdownUsc.NewItem[] { Tipo, Tipo1, Tipo2 };
            DropdownUsc.NewItem [] Estados = new DropdownUsc.NewItem[] { Estado, Estado1, Estado2, Estado3 };

            dd_tipo.LoadDataSource(Tipos);
            dd_empresa.LoadDataSource(Empresas);
            dd_estado.LoadDataSource(Estados);
        }
    }
}