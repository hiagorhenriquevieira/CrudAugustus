﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudAugustusFashion.Dao;
using CrudAugustusFashion.Model;
using CrudAugustusFashion.View;

namespace CrudAugustusFashion.Controller
{
    class CadastroColaboradorController
    {
        public void CadastrarColaborador(ColaboradorModel colaborador)
        {
            new ColaboradorDao().CadastrarColaborador(colaborador);
        }
        public void AbrirCadastroColaborador()
        {
            var frmCadastroColaborador = new FrmCadastroColaborador();
            frmCadastroColaborador.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmCadastroColaborador.Show();
        }
        public void AbrirListaColaborador()
        {
            var frmListaColaborador = new FrmListaColaborador();
            frmListaColaborador.MdiParent = MdiSingletonModel.InstanciarMDI();
            frmListaColaborador.Show();
        }
    }
}
